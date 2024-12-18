using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMABGUI
{
    class Paths
    {
        const string INI_FOLDER = "INI";
        const string APPLICATION_NAME = "YAMAB GUI";

        public static string SettingFilePath()
        {
            return IniFolderPath + @"\Settings.xml";
        }

        public static string IniFolderPath
        {
            get
            {
                return AppLocalDataPath + @"\" + APPLICATION_NAME + @"\" + INI_FOLDER;
            }
        }

        public static string AppLocalDataPath
        {
            get
            {
                return System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            }
        }
    }
}
