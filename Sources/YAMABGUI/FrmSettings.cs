using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OTools;
namespace YAMABGUI
{
    public partial class FrmSettings :  FrmOKCancelBase
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            txtYAMAB_IP.Text = Program.appSettings.IP;
            numPort.Value = Program.appSettings.PORT;
            txtTestResultsMainFolder.Text = Program.appSettings.TestsResultsFolder;
            txtFTPFolder.Text = Program.appSettings.FTP_FOLDER;
            txtFTPPassord.Text = Program.appSettings.FTP_PASSWORD;
            txtFTPUserID.Text = Program.appSettings.FTP_USER_ID;

            numAZ_Stability_AVG_Max.Value =(decimal) Program.appSettings.Stability_AZ_AVG_Max;
            numAZ_Stability_AVG_Min.Value = (decimal)Program.appSettings.Stability_AZ_AVG_Min;
            numAZ_Stability_STD_Max.Value = (decimal)Program.appSettings.Stability_AZ_STD_Max;
            numAZ_Stability_STD_Min.Value = (decimal)Program.appSettings.Stability_AZ_STD_Min;

            numEL_Stability_AVG_Max.Value = (decimal)Program.appSettings.Stability_EL_AVG_Max;
            numEL_Stability_AVG_Min.Value = (decimal)Program.appSettings.Stability_EL_AVG_Min;
            numEL_Stability_STD_Max.Value = (decimal)Program.appSettings.Stability_EL_STD_Max;
            numEL_Stability_STD_Min.Value = (decimal)Program.appSettings.Stability_EL_STD_Min;
        }

        protected override bool SaveImplementation()
        {
            Settings s = new Settings();
            s.IP = txtYAMAB_IP.Text;
            s.PORT = (int)numPort.Value;
            s.TestsResultsFolder = txtTestResultsMainFolder.Text;
            s.FTP_FOLDER = txtFTPFolder.Text;
            s.FTP_PASSWORD = txtFTPPassord.Text;
            s.FTP_USER_ID = txtFTPUserID.Text;

            s.Stability_AZ_AVG_Max = (double)numAZ_Stability_AVG_Max.Value;
            s.Stability_AZ_AVG_Min = (double)numAZ_Stability_AVG_Min.Value;
            s.Stability_AZ_STD_Max = (double)numAZ_Stability_STD_Max.Value;
            s.Stability_AZ_STD_Min = (double)numAZ_Stability_STD_Min.Value;

            s.Stability_EL_AVG_Max = (double)numEL_Stability_AVG_Max.Value;
            s.Stability_EL_AVG_Min = (double)numEL_Stability_AVG_Min.Value;
            s.Stability_EL_STD_Max = (double)numEL_Stability_STD_Max.Value;
            s.Stability_EL_STD_Min = (double)numEL_Stability_STD_Min.Value;




            if (Program.SaveSettingsToXML(s))
            {
                Program.appSettings = s.Clone();

                this.Close();
            }

            return true;
        }
    }
}
