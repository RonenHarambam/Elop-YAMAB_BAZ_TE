using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using SerializationManager;
using OrionTools;

namespace YAMABGUI
{
    static class Program
    {

        public static Settings appSettings = new Settings();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadSettingsFromXML();
            Application.Run(new frmMain());
        }

        private static bool LoadSettingsFromXML()
        {
            bool retVal = true;

            try
            {
                if (File.Exists(Paths.SettingFilePath()))
                {
                    appSettings = (Settings)SerializationTools.DeserializeObject(Paths.SettingFilePath(), appSettings);
                }
            }
            catch (Exception ex)
            {
                MessageBoxDetailed.Display(Messages.Msg001, Messages.Msg002, ex.Message, MessageBoxDetailed.sevirities.error);
                retVal = false;
            }
            return retVal;
        }

        public static bool SaveSettingsToXML(Settings s)
        {
            bool retVal = true;

            try
            {
                if (Directory.Exists(Paths.IniFolderPath) == false)
                {
                    Directory.CreateDirectory(Paths.IniFolderPath);
                }

                SerializationTools.SerializeObject(Paths.SettingFilePath(), s);
            }
            catch (Exception ex)
            {
                MessageBoxDetailed.Display(Messages.Msg001, Messages.Msg003, ex.Message, MessageBoxDetailed.sevirities.error);
                retVal = false;
            }
            return retVal;
        }
    }
}
