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
    internal partial class FrmBar : Form
    {
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
        YAMAB.YAMABManager m_YAMABManager;
        int m_frmPosX, m_frmPosY;

        internal FrmBar(YAMAB.YAMABManager YAMABManager,int frmPosY,int frmPosX)
        {
            InitializeComponent();
            m_YAMABManager = YAMABManager;
            m_frmPosY = frmPosY;
            m_frmPosX = frmPosX;
        }

        private void FrmBar_Load(object sender, EventArgs e)
        {
            if (m_frmPosY != -1)
            {
                this.Top = m_frmPosY;
            }
            if (m_frmPosX != -1)
            {
                this.Left = m_frmPosX;//m_frmPosY
            }

            bgwRead.RunWorkerAsync();
        }

        private void bgwRead_DoWork(object sender, DoWorkEventArgs e)
        {
            ReadItem readItem;

            while (bgwRead.CancellationPending == false)
            {
                try
                {
                    readItem = new ReadItem();
                    //lock (m_YAMABManager)
                    {
                        m_YAMABManager.GetAllSensorsInformation(out readItem.bazMode,
                                                                out readItem.traverseAngleGunnerMirror,
                                                                out readItem.jackingAngleGunnerMirror,
                                                                out readItem.solonoidJacking,
                                                                out readItem.solonoidTraverse,
                                                                out readItem.sachiputResetValueTraverse,
                                                                out readItem.sachiputResetValueJacking,
                                                                out readItem.driftStstus);

                        

                        bgwRead.ReportProgress(0, readItem);
                    }

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
                UpdateCommLabel(false);

            }
            else
            {
                UpdateGUI((ReadItem)e.UserState);
            }
        }

        private float ConvertMradToDeg(float val)
        {
            float retVal;

            retVal = (float)0.0573 * val;
            return retVal;
        }

        private void UpdateCommLabel(bool connected)
        {
            if (connected)
            {
                if (lblComm.Text != "Connected")
                {
                    lblComm.BackColor = Color.Lime;
                    lblComm.Text = "Connected";
                }
            }
            else
            {
                if (lblComm.Text != "Not Connected")
                {
                    lblComm.BackColor = Color.Red;
                    lblComm.Text = "Not Connected";
                }
            }
        }


        private void UpdateGUI(ReadItem readItem)
        {
            float elDeg,azDeg;
            int el, az;

            UpdateCommLabel(true);


            elDeg = ConvertMradToDeg((readItem.jackingAngleGunnerMirror) * 1000);
            azDeg = ConvertMradToDeg((readItem.traverseAngleGunnerMirror) * 1000);

            txtReadAZ_deg.Text = azDeg.ToString("0.00");
            txtReadEL_deg.Text = elDeg.ToString("0.00");

            el = (int)elDeg;
            az = (int)azDeg;

            if (az > tBarHorizontal.Maximum)
            {
                az = tBarHorizontal.Maximum;
            }
            else if (az < tBarHorizontal.Minimum)
            {
                az = tBarHorizontal.Minimum;
            }

            tBarHorizontal.Value = az;


            if (el > tBarVertical.Maximum)
            {
                el = tBarVertical.Maximum;
            }
            else if (el < tBarVertical.Minimum)
            {
                el = tBarVertical.Minimum;
            }

            tBarVertical.Value = el;
                       
        }

        private void FrmBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            bgwRead.CancelAsync();

            while (bgwRead.IsBusy)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
