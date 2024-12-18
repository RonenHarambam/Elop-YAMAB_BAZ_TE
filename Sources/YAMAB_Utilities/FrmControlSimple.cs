using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAMAB_Utilities
{
    internal partial class FrmControlSimple : Form
    {
        enum ProgressType
        {
            initializing,
            initializeCompleted,
            UpdateGUI
        }

        class ReadItem
        {
           public byte bazMode;
           public float traverseAngleGunnerMirror;
           public float jackingAngleGunnerMirror;
           public byte solonoidJacking;
           public byte solonoidTraverse;
           public float sachiputResetValueTraverse;
           public float sachiputResetValueJacking;
           public byte driftStstus;
            public ProgressType progressType;

            public ReadItem Clone()
            {
                return (ReadItem)this.MemberwiseClone();
            }
        }


        YAMAB.YAMABManager m_YAMABManager;

        float m_movementBigStep, m_movementSmallStep;
      
        int m_frmPosX, m_frmPosY;
        float m_initialPosAZ, m_initialPosEL, m_currentPosAZ, m_currentPosEL;
      
        


        internal FrmControlSimple(YAMAB.YAMABManager YAMABManager, double movementBigStep_mrad, double movementSmallStep_mrad, double initialPosAZ, double initialPosEL, int frmPosX, int frmPosY)
        {
            InitializeComponent();
            m_YAMABManager = YAMABManager;
                     
            m_movementBigStep = (float)movementBigStep_mrad;
            m_movementSmallStep = (float)movementSmallStep_mrad;
          
            m_frmPosX = frmPosX;
            m_frmPosY = frmPosY;
                              
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            Init();
            bgwRead.RunWorkerAsync();
           
        }

        private void Init()
        {        

            if (m_frmPosY != -1)
            {
                this.Top = m_frmPosY;
            }
            if (m_frmPosX != -1)
            {
                this.Left = m_frmPosX;//m_frmPosY
            }

        }

       

        private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadItem readItem;
            bool readInitialValues = true;
            int counter = 0;
            while (bgwRead.CancellationPending == false)
            {
                try
                {
                    readItem = new ReadItem();

                    m_YAMABManager.GetAllSensorsInformation(out readItem.bazMode,
                                                            out readItem.traverseAngleGunnerMirror,
                                                            out readItem.jackingAngleGunnerMirror,
                                                            out readItem.solonoidJacking,
                                                            out readItem.solonoidTraverse,
                                                            out readItem.sachiputResetValueTraverse,
                                                            out readItem.sachiputResetValueJacking,
                                                            out readItem.driftStstus);


                    if (readInitialValues)
                    {
                        counter++;
                        if (counter == 20)
                        {
                            m_currentPosAZ = (float)(readItem.traverseAngleGunnerMirror * 1000);
                            m_currentPosEL = (float)(readItem.jackingAngleGunnerMirror * 1000);
                            m_initialPosAZ = m_currentPosAZ;
                            m_initialPosEL = m_currentPosEL;
                            readInitialValues = false;
                            readItem.progressType = ProgressType.initializeCompleted;
                            bgwRead.ReportProgress(0, readItem.Clone()); 
                        }
                    }

                    readItem.progressType = ProgressType.UpdateGUI;
                    bgwRead.ReportProgress(0, readItem.Clone());
                }
                catch
                {
                    bgwRead.ReportProgress(0, null);
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private void bgwRead_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == null)
            {
                lblComm.Text = "Error";
                              
            }
            else
            {
                switch (((ReadItem)e.UserState).progressType)
                {
                    case ProgressType.initializeCompleted:
                        pnlSightMovement.Enabled = true;
                        UpdateInitializationDetailsInGui();
                        break;
                    default:
                        UpdateGUI((ReadItem)e.UserState);
                        break;
                }
              
            }
        }

        private void UpdateInitializationDetailsInGui()
        {
            lblInitializationUpdate.Text = "Initial EL(Deg):" + (ConvertMradToDeg(m_initialPosEL)).ToString("0.00") + "  " + "Initial AZ(Deg):" + (ConvertMradToDeg(m_initialPosAZ)).ToString("0.00");

        }

        private float ConvertMradToDeg(float val)
        {
            float retVal;

            retVal = (float)0.0573 * val;
            return retVal;
        }

        private void UpdateGUI(ReadItem readItem)
        {
            lblComm.Text = "OK";

            txtReadEL_mrad.Text = ((readItem.jackingAngleGunnerMirror) *1000).ToString("0.00");
            txtReadEL_deg.Text = ConvertMradToDeg((readItem.jackingAngleGunnerMirror) * 1000).ToString("0.00");

            txtReadAZ_mrad.Text = ((readItem.traverseAngleGunnerMirror) * 1000).ToString("0.00");
            txtReadAZ_deg.Text = ConvertMradToDeg((readItem.traverseAngleGunnerMirror) * 1000).ToString("0.00");

            txtReadSystemMode.Text = GetBazModeDescription(readItem.bazMode);
            txtReadDriftStatus.Text = GetDriftStatusDescription(readItem.driftStstus);
            txtMicroSwStatus_AZ.Text = GetSolonoidDescription(readItem.solonoidTraverse);
            txtMicroSwStatus_EL.Text = GetSolonoidDescription(readItem.solonoidJacking);
        }

        private string GetBazModeDescription(byte mode)
        {
            string retVal = string.Empty;

            switch (mode)
            {
                case 0:
                    retVal = "Emergency";
                    break;
                case 1:
                    retVal = "Gun slave";
                    break;
                case 2:
                    retVal = "Sight slave";
                    break;
            }

            return retVal;
        }

        private string GetSolonoidDescription(byte mode)
        {
            string retVal = string.Empty;

            switch (mode)
            {
                case 0:
                    retVal = "Closed";
                    break;
                case 1:
                    retVal = "Open";
                    break;

            }

            return retVal;
        }

        private string GetDriftStatusDescription(byte mode)
        {
            string retVal = string.Empty;

            switch (mode)
            {
                case 0:
                    retVal = "Not Active";
                    break;
                case 1:
                    retVal = "Active";
                    break;

            }

            return retVal;
        }



        private void FrmControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgwRead.CancelAsync();
            while (bgwRead.IsBusy)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }

        }

        private void HandleExceptions(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }


        private void MoveSight(byte movementType, float step)
        {
            try
            {
                if (movementType == 4)//EL
                {
                    m_currentPosEL += step;
                    m_YAMABManager.SetBazParameters(movementType, m_currentPosEL);
                }
                else//AZ
                {
                    m_currentPosAZ += step;
                    m_YAMABManager.SetBazParameters(movementType, m_currentPosAZ);
                }
                
            }

            catch (Exception ex)
            {
                HandleExceptions(ex);
            }
        }

        private void btnUp_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, m_movementBigStep);
        }

        private void btnUp_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, m_movementSmallStep);
        }

        private void btnDown_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, -m_movementBigStep);
        }

        private void btnDown_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, -m_movementSmallStep);
        }

        private void btnRight_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, m_movementBigStep);
        }

        private void btnRight_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, m_movementSmallStep);
        }

        private void btnLeft_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, -m_movementBigStep);
        }

        private void btnLeft_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, -m_movementSmallStep);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                m_YAMABManager.SetBazParameters(4, m_initialPosEL);
                m_YAMABManager.SetBazParameters(5, m_initialPosAZ);
            }
            catch
            {

            }
        }

       
        
    }
}
