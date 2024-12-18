using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YAMABGUI
{
    [Serializable()]
    public class Settings
    {
        string m_IP_Address="132.4.5.50";
        int m_port=3000;
        string m_testsResultsFolder = string.Empty;
        string m_FTP_USER_ID = "target";
        string m_FTP_PASSWORD = "target";
        string m_FTP_FOLDER = "/ata1";

        double m_stability_AZ_AVG_Min = 0;
        double m_stability_AZ_AVG_Max = 0;
        double m_stability_AZ_STD_Min = 0;
        double m_stability_AZ_STD_Max = 0;

        double m_stability_EL_AVG_Min = 0;
        double m_stability_EL_AVG_Max = 0;
        double m_stability_EL_STD_Min = 0;
        double m_stability_EL_STD_Max = 0;

        public string IP
        {
            get
            {
                return m_IP_Address;
            }
            set
            {
                m_IP_Address = value;
            }
        }

        public int PORT
        {
            get
            {
                return m_port;
            }
            set
            {
                m_port = value;
            }
        }

        public string TestsResultsFolder
        {
            get
            {
                return m_testsResultsFolder;
            }
            set
            {
                m_testsResultsFolder = value;
            }
        }

        public string FTP_USER_ID
        {
            get
            {
                return m_FTP_USER_ID;
            }
            set
            {
                m_FTP_USER_ID = value;
            }
        }

        public string FTP_PASSWORD
        {
            get
            {
                return m_FTP_PASSWORD;
            }
            set
            {
                m_FTP_PASSWORD = value;
            }
        }

        public string FTP_FOLDER
        {
            get
            {
                return m_FTP_FOLDER;
            }
            set
            {
                m_FTP_FOLDER = value;
            }
        }


        public double Stability_AZ_AVG_Min
        {
            get
            {
                return m_stability_AZ_AVG_Min;
            }
            set
            {
                m_stability_AZ_AVG_Min = value;
            }
        }

        public double Stability_AZ_AVG_Max
        {
            get
            {
                return m_stability_AZ_AVG_Max;
            }
            set
            {
                m_stability_AZ_AVG_Max = value;
            }
        }

        public double Stability_AZ_STD_Max
        {
            get
            {
                return m_stability_AZ_STD_Max;
            }
            set
            {
                m_stability_AZ_STD_Max = value;
            }
        }
        public double Stability_AZ_STD_Min
        {
            get
            {
                return m_stability_AZ_STD_Min;
            }
            set
            {
                m_stability_AZ_STD_Min = value;
            }
        }

        public double Stability_EL_AVG_Min
        {
            get
            {
                return m_stability_EL_AVG_Min;
            }
            set
            {
                m_stability_EL_AVG_Min = value;
            }
        }

        public double Stability_EL_AVG_Max
        {
            get
            {
                return m_stability_EL_AVG_Max;
            }
            set
            {
                m_stability_EL_AVG_Max = value;
            }
        }

        public double Stability_EL_STD_Max
        {
            get
            {
                return m_stability_EL_STD_Max;
            }
            set
            {
                m_stability_EL_STD_Max = value;
            }
        }
        public double Stability_EL_STD_Min
        {
            get
            {
                return m_stability_EL_STD_Min;
            }
            set
            {
                m_stability_EL_STD_Min = value;
            }
        }



        public Settings Clone()
        {
            Settings retVal = (Settings)this.MemberwiseClone();
            return retVal;
        }
    }
}
