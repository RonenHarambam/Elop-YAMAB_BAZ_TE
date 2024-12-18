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
    internal partial class FrmControl : Form
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

        byte m_result=0;
        double m_parameterValue;
        YAMAB_Utilities.ButtonsType m_buttonsType= YAMAB_Utilities.ButtonsType.PASS_FAIL;
        float m_movementBigStep, m_movementSmallStep;
        string m_parameterCaption, m_btnOKCaption;
        int m_frmPosX, m_frmPosY;
        float m_initialPosAZ, m_initialPosEL, m_currentPosAZ, m_currentPosEL;
        byte m_initialPosActive;
        string m_picturePath;

        public byte Result { get { return m_result; } }
        public double ParameterValue { get { return m_parameterValue; } }

        internal FrmControl(YAMAB.YAMABManager YAMABManager, string testName, string testMessage, string parameterCaption, string btnOKCaption, YAMAB_Utilities.ButtonsType buttonsType, double movementBigStep_mrad, double movementSmallStep_mrad, double initialPosAZ, double initialPosEL, int frmPosX, int frmPosY, byte initialPosActive, string picturePath)
        {
            InitializeComponent();
            m_YAMABManager = YAMABManager;
            lblTestName.Text = testName;
            txtMessage.Text = testMessage;
            if (txtMessage.Text != string.Empty)
            {
                txtMessage.SelectionStart = txtMessage.Text.Length + 1;
            }
            m_buttonsType = buttonsType;
            m_movementBigStep = (float)movementBigStep_mrad;
            m_movementSmallStep = (float)movementSmallStep_mrad;
            m_parameterCaption = parameterCaption;
            m_btnOKCaption = btnOKCaption;
            m_frmPosX = frmPosX;
            m_frmPosY = frmPosY;
           // m_initialPosAZ = (float)initialPosAZ;
           // m_initialPosEL = (float)initialPosEL;
            m_initialPosActive = initialPosActive;
            m_picturePath = picturePath;
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            Init();
            bgwRead.RunWorkerAsync();
           
            //m_currentPosAZ = m_initialPosAZ;
           // m_currentPosEL = m_initialPosEL;
            try
            {
                if (m_initialPosActive == 1)
                {
                   // m_YAMABManager.SetBazParameters(4, m_initialPosEL);
                    //m_YAMABManager.SetBazParameters(5, m_initialPosAZ);
                }
            }
            catch
            { 
            
            }

           
        }

        private void Init()
        {
            if (m_parameterCaption == string.Empty)
            {
                pnlParameterValue.Visible = false;
            }
            lblParameterCaption.Text = m_parameterCaption;

            if (m_buttonsType == YAMAB_Utilities.ButtonsType.PASS_FAIL)
            {
                btnOK.Visible = false;
            }
            else
            {
                btnOK.Left = btnFail.Left;
                btnPass.Visible = false;
                btnFail.Visible = false;
            }
            btnOK.Text = m_btnOKCaption;

            if (m_frmPosY != -1)
            {
                this.Top = m_frmPosY;
            }
            if (m_frmPosX != -1)
            {
                this.Left = m_frmPosX;//m_frmPosY
            }

            if (m_picturePath != null && m_picturePath != string.Empty)
            {
                if (System.IO.File.Exists(m_picturePath))
                {
                    picImage.Load(m_picturePath);
                }
            }
            else
            {
                spMessage.Panel2Collapsed = true;
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

            if(picImage.Image!=null)
            {
                picImage.Image.Dispose();
                picImage.Image = null;
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

        private void numParameterValue_ValueChanged(object sender, EventArgs e)
        {
            m_parameterValue = (double)numParameterValue.Value;
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            m_result = 0;
            this.Close();
        }

        private void btnFail_Click(object sender, EventArgs e)
        {
            m_result = 1;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_result = 0;
            this.Close();
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

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
