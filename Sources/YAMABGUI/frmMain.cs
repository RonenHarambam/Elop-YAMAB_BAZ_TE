using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YAMAB;

namespace YAMABGUI
{
    public partial class frmMain : Form
    {
        private YAMABManager m_yamabManager;
        const string COMM_OK = "OK";
        const string COMM_FAIL = "FAIL";
        bool m_previousCommStatus = false;

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
        }

        ReadItem m_readItem = new ReadItem();
        int m_currentSystemMode=-1;

        float   m_currentPosAZ, m_currentPosEL;
        float m_movementBigStep = (float)0.2;
        float m_movementSmallStep = (float)0.1;

        public frmMain()
        {
            m_yamabManager = new YAMABManager();
            InitializeComponent();
        }

   


        private string GetBazModeDescription(byte mode)
        {
            string retVal=string.Empty;

            switch (mode)
            { 
                case 0:
                    retVal = "Emergency";
                    break;
                case 1:
                    retVal = "Gun Slave";
                    break;
                case 2:
                    retVal = "Sight Slave";
                    break;
                case 3:
                    retVal = "Gun Slave And Tacho";
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
                    retVal = "Not in process";
                    break;
                case 1:
                    retVal = "In process";
                    break;

            }

            return retVal;
        }


        private void btnGetAllSensorsInformation_Click(object sender, EventArgs e)
        {
            byte bazMode;
            float traverseAngleGunnerMirror;
            float jackingAngleGunnerMirror;
            byte solonoidJacking;
            byte solonoidTraverse;
            float sachiputResetValueTraverse;
            float sachiputResetValueJacking;
            byte driftStstus;
            try
            {
                m_yamabManager.GetAllSensorsInformation(out bazMode,
                                                            out traverseAngleGunnerMirror, 
                                                            out jackingAngleGunnerMirror,
                                                            out solonoidJacking,
                                                            out solonoidTraverse,
                                                            out sachiputResetValueTraverse,
                                                            out sachiputResetValueJacking,
                                                            out driftStstus);

                txtBazMode.Text = GetBazModeDescription(bazMode);

                txtTraverseAngleGunnerMirror_Deg.Text =ConvertMradToDeg(traverseAngleGunnerMirror*1000).ToString();
                txtJackingAngleGunnerMirror_Deg.Text = ConvertMradToDeg(jackingAngleGunnerMirror*1000).ToString();
                txtSolonoidJacking.Text =GetSolonoidDescription(solonoidJacking);
                txtSolonoidTraverse.Text =GetSolonoidDescription(solonoidTraverse);
                txtSachiputResetValueTraverse.Text = sachiputResetValueTraverse.ToString();
                txtSachiputResetValueJacking.Text = sachiputResetValueJacking.ToString();
                txtDriftStatus.Text = GetDriftStatusDescription(driftStstus);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetAllBazFailures_Click(object sender, EventArgs e)
        {
            ushort numberOfFailures;
            ushort errorNumber;

            try
            {
                m_yamabManager.GetAllBazFailures(out numberOfFailures, out errorNumber);

                txtNumberOfFailures.Text = numberOfFailures.ToString();
                txtErrorNumber.Text = errorNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetBazFailuresUpdate_Click(object sender, EventArgs e)
        {
            ushort failureNumber;
            byte status;

            try
            {
                m_yamabManager.GetBazFailuresUpdate(out failureNumber, out status);

                txtFailureNumber.Text = failureNumber.ToString();
                txtStatus.Text = status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SetSystemMode(byte mode)
        {
            try
            {
                m_yamabManager.SetMainSystemMode(mode);
            }
            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg007);
            }
        }

     

        private float ConvertDegToMrad(float val)
        {
            float retVal;

            retVal = (float)17.45 * val;
            return retVal;
        }

        private float ConvertMradToDeg(float val)
        {
            float retVal;

            retVal = (float)0.0573 * val;
            return retVal;
        }

      


        private void SetBazParameters(byte bazParamType,float mradValue)
        {
            try
            {
                m_yamabManager.SetBazParameters(bazParamType, mradValue);
            }
            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg007);
            }
        }


        private void btnSetDriftMode_Click(object sender, EventArgs e)
        {
            try
            {
                m_yamabManager.SetDriftMode();
            }
            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg010);
            }
        }
        
        private void btnRequestErrorTable_Click(object sender, EventArgs e)
        {
            try
            {
                m_yamabManager.RequestErrorTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text += "  Ver " + Application.ProductVersion;
         
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //     lock (m_yamabManager)
        //    {
        //        m_yamabManager.SendEcho();
               
        //    }
        //}

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(Messages.Msg008, Messages.Msg009, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

            try
            {
                bgwRead.CancelAsync();

                while (bgwRead.IsBusy)
                {
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                }

                m_yamabManager.Disconnect();
            }

            catch (Exception ex)
            {

            }

        }

        private void lblSachiputResetValueJacking_Click(object sender, EventArgs e)
        {

        }

      

        private static string FormatBuffer2HexString(int startIndex, byte[] buffer)
        {
            string retVal = null;

            for (int i = startIndex; i < buffer.Length; i++)
            {
                retVal += buffer[i].ToString("X2") + " ";
            }
            return retVal;
        }

        //private void tmrRXTX_Tick(object sender, EventArgs e)
        //{
        //    if (m_yamabManager.RX != null)
        //    {
        //        txtRX.Text = FormatBuffer2HexString(0, m_yamabManager.RX);
        //    }

        //    if (m_yamabManager.TX != null)
        //    {
        //        txtTX.Text = FormatBuffer2HexString(0, m_yamabManager.TX);
        //    }
        //}

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  YAMAB_Utilities.FrmBar frm = new YAMAB_Utilities.FrmBar(m_yamabManager);
          //  frm.ShowDialog();

        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Messages.Msg011, Messages.Msg012, MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    m_yamabManager.Connect(Program.appSettings.IP);
                    tsbConnect.Enabled = false;
                    tsbDisconnect.Enabled = true;
                    btnMaintenance.Enabled = false;
                    bgwRead.RunWorkerAsync();
                    btnGyroTest.Enabled = true;

                }
                catch (Exception ex)
                {
                    Shared.HandleError(ex, Messages.Msg004);
                    tsbConnect.Enabled = true;
                    tsbDisconnect.Enabled = false;
                    btnGyroTest.Enabled = false;
                }
            }
        }

        private void tsbDisconnect_Click(object sender, EventArgs e)
        {
            try
            {               
                tsbDisconnect.Enabled = false;
                bgwRead.CancelAsync();

                while (bgwRead.IsBusy)
                {
                    System.Threading.Thread.Sleep(1);
                    Application.DoEvents();
                }

                m_yamabManager.Disconnect();
                
            }

            catch (Exception ex)
            {
               
            }

            finally
            {
                tsbConnect.Enabled = true;
                btnMaintenance.Enabled = true;
                UpdateCommStatusInGUI(false);
                btnGyroTest.Enabled = false;
            }


        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }

        private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
        {
            while (bgwRead.CancellationPending == false)
            {
                try
                {
                    m_yamabManager.GetAllSensorsInformation(out m_readItem.bazMode,
                                                                out m_readItem.traverseAngleGunnerMirror,
                                                                out m_readItem.jackingAngleGunnerMirror,
                                                                out m_readItem.solonoidJacking,
                                                                out m_readItem.solonoidTraverse,
                                                                out m_readItem.sachiputResetValueTraverse,
                                                                out m_readItem.sachiputResetValueJacking,
                                                                out m_readItem.driftStstus);


                    m_currentSystemMode = m_readItem.bazMode;
                   bgwRead.ReportProgress(0, m_readItem);

                }
                catch (Exception ex)
                {
                    m_currentSystemMode = -1;
                    bgwRead.ReportProgress(0, null);
                }

                System.Threading.Thread.Sleep(500);
            }
        }

        private void bgwRead_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                ReadItem readItem = (ReadItem)e.UserState;

                txtBazMode.Text = GetBazModeDescription(readItem.bazMode);

                txtTraverseAngleGunnerMirror_Deg.Text = ConvertMradToDeg(readItem.traverseAngleGunnerMirror * 1000).ToString();
                txtTraverseAngleGunnerMirror_Mrad.Text = (readItem.traverseAngleGunnerMirror * 1000).ToString();
                txtJackingAngleGunnerMirror_Deg.Text = ConvertMradToDeg(readItem.jackingAngleGunnerMirror * 1000).ToString();
                txtJackingAngleGunnerMirror_Mrad.Text = (readItem.jackingAngleGunnerMirror * 1000).ToString();

                txtSolonoidJacking.Text = GetSolonoidDescription(readItem.solonoidJacking);
                txtSolonoidTraverse.Text = GetSolonoidDescription(readItem.solonoidTraverse);
                txtSachiputResetValueTraverse.Text = readItem.sachiputResetValueTraverse.ToString();
                txtSachiputResetValueJacking.Text = readItem.sachiputResetValueJacking.ToString();
                txtDriftStatus.Text = GetDriftStatusDescription(readItem.driftStstus);

                m_currentPosAZ = readItem.traverseAngleGunnerMirror * 1000;
                m_currentPosEL = readItem.jackingAngleGunnerMirror * 1000;

                UpdateCommStatusInGUI(true);

                if (m_yamabManager.RX != null)
                {
                    txtRX.Text = FormatBuffer2HexString(0, m_yamabManager.RX);
                }

                if (m_yamabManager.TX != null)
                {
                    txtTX.Text = FormatBuffer2HexString(0, m_yamabManager.TX);
                }
            }
            else
            {
                UpdateCommStatusInGUI(false);
            }
        }

        private void UpdateCommStatusInGUI(bool CommStatus)
        {
            if (m_previousCommStatus != CommStatus)
            {
                m_previousCommStatus = CommStatus;
                if (CommStatus == true)
                {
                    lblComm.Text = COMM_OK;
                    lblComm.BackColor = Color.Lime;
                }
                else
                {
                    lblComm.Text = COMM_FAIL;
                    lblComm.BackColor = Color.Red;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSystemMode(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSystemMode(1);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SetSystemMode(2);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SetSystemMode(3);
        }

        private void btnDrift_Click(object sender, EventArgs e)
        {
            try
            {
                m_yamabManager.SetDriftMode();
            }
            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg010);
            }
        }

        private bool ValidateSystemMode()
        {
            bool retVal = true;

            if (m_currentSystemMode != 1)
            {
                MessageBox.Show(Messages.Msg013, Messages.Msg012, MessageBoxButtons.OK, MessageBoxIcon.Information);
                retVal = false;
            }
            return retVal;
        }
           

        private void btnSetAZ_Deg_Click(object sender, EventArgs e)
        {
            if(ValidateSystemMode()==false)
            {
                return;
            }
            float value = Convert.ToSingle(numSetAZ_Deg.Value);
            float mradValue = ConvertDegToMrad(value);
           
            SetBazParameters(5, mradValue);
        }

        private void btnSetAZ_Mrad_Click(object sender, EventArgs e)
        {
            if (ValidateSystemMode() == false)
            {
                return;
            }
            float mradValue = Convert.ToSingle(numSetAZ_Mrad.Value);

            SetBazParameters(5, mradValue);
        }

        private void btnSetEL_Deg_Click(object sender, EventArgs e)
        {
            if (ValidateSystemMode() == false)
            {
                return;
            }
            float value = Convert.ToSingle(numSetEL_Deg.Value);
            float mradValue = ConvertDegToMrad(value);

            SetBazParameters(4, mradValue);
        }

        private void btnSetEL_Mrad_Click(object sender, EventArgs e)
        {
            if (ValidateSystemMode() == false)
            {
                return;
            }
            float mradValue = Convert.ToSingle(numSetEL_Mrad.Value);

            SetBazParameters(4, mradValue);
        }

        private void numSetAZ_Deg_ValueChanged(object sender, EventArgs e)
        {
            float value = Convert.ToSingle(numSetAZ_Deg.Value);
            float mradValue = ConvertDegToMrad(value);
           // 
            this.numSetAZ_Mrad.ValueChanged -= new System.EventHandler(this.numSetAZ_Mrad_ValueChanged);
            numSetAZ_Mrad.Value = (decimal)mradValue;
            this.numSetAZ_Mrad.ValueChanged += new System.EventHandler(this.numSetAZ_Mrad_ValueChanged);
        }

        private void numSetAZ_Mrad_ValueChanged(object sender, EventArgs e)
        {
            this.numSetAZ_Deg.ValueChanged -= new System.EventHandler(this.numSetAZ_Deg_ValueChanged);
            float value = Convert.ToSingle(numSetAZ_Mrad.Value);
            float degValue = ConvertMradToDeg(value);
            numSetAZ_Deg.Value = (decimal)degValue;
            this.numSetAZ_Deg.ValueChanged += new System.EventHandler(this.numSetAZ_Deg_ValueChanged);
        }

        private void numSetEL_Deg_ValueChanged(object sender, EventArgs e)
        {
            this.numSetEL_Mrad.ValueChanged -= new System.EventHandler(this.numSetEL_Mrad_ValueChanged);
            float value = Convert.ToSingle(numSetEL_Deg.Value);
            float mradValue = ConvertDegToMrad(value);
            numSetEL_Mrad.Value = (decimal)mradValue;
            this.numSetEL_Mrad.ValueChanged += new System.EventHandler(this.numSetEL_Mrad_ValueChanged);
        }

        private void numSetEL_Mrad_ValueChanged(object sender, EventArgs e)
        {
            this.numSetEL_Deg.ValueChanged -= new System.EventHandler(this.numSetEL_Deg_ValueChanged);
            float value = Convert.ToSingle(numSetEL_Mrad.Value);
            float degValue = ConvertMradToDeg(value);
            numSetEL_Deg.Value = (decimal)degValue;
            this.numSetEL_Deg.ValueChanged += new System.EventHandler(this.numSetEL_Deg_ValueChanged);
        }

        private void btnUp_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, m_movementBigStep);
        }

        private void btnUp_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, m_movementSmallStep);
        }

        private void btnRight_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, m_movementBigStep);
        }

        private void btnRight_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, m_movementSmallStep);
        }

        private void btnDown_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, -m_movementSmallStep);
        }

        private void btnDown_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(4, -m_movementBigStep);
        }

        private void btnLeft_smallStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, -m_movementSmallStep);
        }

        private void btnLeft_bigStep_Click(object sender, EventArgs e)
        {
            MoveSight(5, -m_movementBigStep);
        }

        private void numBigStep_ValueChanged(object sender, EventArgs e)
        {
            m_movementBigStep = (float)numBigStep.Value;
        }

        private void numSmallStep_ValueChanged(object sender, EventArgs e)
        {
            m_movementSmallStep= (float)numSmallStep.Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetBazParameters(4, m_currentPosEL);
            System.Threading.Thread.Sleep(200);
            SetBazParameters(5, m_currentPosAZ);
        }

        private void btnGyroTest_Click(object sender, EventArgs e)
        {
            FrmGyroTest FrmGyroTest = new FrmGyroTest(m_yamabManager);
            FrmGyroTest.ShowDialog();

        }

        private void MoveSight(byte movementType, float step)
        {
            float movement;
            try
            {
                if (movementType == 4)//EL
                {
                    movement = m_currentPosEL;
                    movement += step;
                    SetBazParameters(4, movement);
                   
                }
                else//AZ
                {
                    movement = m_currentPosAZ;
                    movement += step;
                    m_currentPosAZ += step;
                    SetBazParameters(5, movement);
                   
                }

            }

            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg007);
            }
        }
    }
}
