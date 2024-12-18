using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YAMAB;
using System.IO;
using OrionTools;
using OTools;
using DeviceManager;
using TestExecutive;
using Math = System.Math;

namespace YAMABGUI
{
    public partial class FrmGyroTest : Form
    {

        YAMABManager m_yamabManager;
        FTP m_ftpManager = new FTP();
        EthernetCommManager m_ethernetCommManager = new EthernetCommManager();
        //SystemSteps m_systemSteps = new SystemSteps();
        FileManager m_fileManager = new FileManager();
        const string TEST_NAME = "T150";
        Strings m_stringsMnager = new Strings();
        TestExecutive.Math math_manager = new TestExecutive.Math();
        const string START_TEST = "Start Test";
        const string ABORT_TEST = "Abort Test";
        bool m_testModeActive = false;
        bool m_TestOK = false;

         Color PASS_COLOR = Color.LightGreen;
         Color FAIL_COLOR = Color.Salmon;

        public class Results
        {
           public double EL_AVG;
           public double AZ_AVG;
           public double EL_STD;
           public double AZ_STD;

           public double[] arrAzimuth;
           public double[] arrElevation;
        }

        Results m_results = new Results();

        public FrmGyroTest(YAMABManager yamabManager)
        {
            InitializeComponent();
            m_yamabManager = yamabManager;
        }

        private void FrmGyroTest_Load(object sender, EventArgs e)
        {

        }

        private string CreateTestFoldert()
        {
            string retVal;

            retVal = Program.appSettings.TestsResultsFolder + "\\" + "GyroTest" + "\\" + DateTime.Now.ToLongDateString();
            Directory.CreateDirectory(retVal);

            return retVal;
        }

        private void ClearFTPFIles()
        {
            string[] arrFiles, arrTempFiles;
            string fileName;

            m_ftpManager.GetFileList(Program.appSettings.IP, Program.appSettings.FTP_USER_ID, Program.appSettings.FTP_PASSWORD, Program.appSettings.FTP_FOLDER, out arrFiles, out arrTempFiles, false);
            for(int i=0; i< arrFiles.Length;i++)
            {
                fileName = arrFiles[i];
                fileName = fileName.Replace(Program.appSettings.FTP_FOLDER + "/", string.Empty);
                if(fileName.Contains(TEST_NAME))
                {
                    m_ftpManager.DeleteFile(Program.appSettings.IP, Program.appSettings.FTP_USER_ID, Program.appSettings.FTP_PASSWORD, Program.appSettings.FTP_FOLDER,fileName);
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        private string DownloadTestResultFTPFIle(string testFolder)
        {
            string[] arrFiles, arrTempFiles;
            string fileName,downloadedFileFullPath=string.Empty;
            string sourceFilePath;

            m_ftpManager.GetFileList(Program.appSettings.IP, Program.appSettings.FTP_USER_ID, Program.appSettings.FTP_PASSWORD, Program.appSettings.FTP_FOLDER, out arrFiles, out arrTempFiles, false);
            for (int i = 0; i < arrFiles.Length; i++)
            {
                fileName = arrFiles[i];
                fileName = fileName.Replace(Program.appSettings.FTP_FOLDER + "/", string.Empty);
                if (fileName.Contains(TEST_NAME))
                {
                    sourceFilePath = Program.appSettings.FTP_FOLDER + "/" + fileName;
                    m_ftpManager.DownloadFile(Program.appSettings.FTP_USER_ID, Program.appSettings.FTP_PASSWORD, sourceFilePath, testFolder, Program.appSettings.IP);
                    downloadedFileFullPath = testFolder + "\\" + fileName;
                }
                System.Threading.Thread.Sleep(100);
            }
            return downloadedFileFullPath;
        }

        private void AnalyzeTestFile(string filePath)
        {
            string strFileContent;
            double[] arrElevation, arrAzimuth;
            double avgElevation, avgAzimuth,azimuthSTD,elevarionSTD;
            
            m_fileManager.LoadTextFile(filePath, out strFileContent);
            m_stringsMnager.Concatenate("1,2,3,4,5,6,7,8,9,10,11,12,13,14,15" +
                                         ",16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32"+System.Environment.NewLine, strFileContent,out strFileContent);
           
            m_fileManager.WriteTextFile(filePath, strFileContent);
            m_fileManager.LoadNumericColumnFromDelimitedTextFile(filePath, ",", "31", out arrElevation);
            m_fileManager.LoadNumericColumnFromDelimitedTextFile(filePath, ",", "32", out arrAzimuth);

            math_manager.CalcAverage(arrElevation, out avgElevation);
            math_manager.CalcAverage(arrAzimuth, out avgAzimuth);



            //write to graph
            m_results.arrAzimuth = arrAzimuth;
            m_results.arrElevation = arrElevation;
            //UpdateGraph(arrElevation, arrAzimuth);

            //substract the avg value from each value of the array(EL,AZ)
            //for (int i=0;i<arrAzimuth.Length;i++)
            //{
            //    arrAzimuth[i] -= avgAzimuth;
            //    arrElevation[i] -= avgElevation;
            //}

            math_manager.STD(arrAzimuth, out azimuthSTD);
            math_manager.STD(arrElevation, out elevarionSTD);


             
            azimuthSTD = Math.Round(azimuthSTD, 8);
           // lblAZ_STD.Text = azimuthSTD.ToString();

            elevarionSTD = Math.Round(elevarionSTD, 8);
            //lblEL_STD.Text = elevarionSTD.ToString();

            avgAzimuth = Math.Round(avgAzimuth, 8);
            //lblAZ_avg.Text = avgAzimuth.ToString();

            avgElevation = Math.Round(avgElevation, 8);
            //lblEL_avg.Text = avgElevation.ToString();

            m_results.AZ_AVG = avgAzimuth;
            m_results.AZ_STD = azimuthSTD;
            m_results.EL_AVG = avgElevation;
            m_results.EL_STD = elevarionSTD;



        }

        private void UpdateGraph(double[] arrElevation, double[] arrAzimuth)
        {
          
            double xInterval,xPoint=0;

            xInterval=(double)(40/arrAzimuth.Length);


            for (int i=0;i<arrAzimuth.Length;i++)
            {
                ChartAzimuth.Series[0].Points.AddXY(xPoint, arrAzimuth[i]);
                chartElevation.Series[0].Points.AddXY(xPoint, arrElevation[i]);
                xPoint += xInterval;

            }
        }

        private void ClearResults()
        {
            lblEL_STD.Text = "NA";
            lblAZ_STD.Text = "NA";
            lblAZ_avg.Text = "NA";
            lblEL_avg.Text = "NA";

            chartElevation.Series[0].Points.Clear();
            ChartAzimuth.Series[0].Points.Clear();

            lblEL_STD.BackColor = Color.White;
            lblAZ_STD.BackColor = Color.White;
            lblAZ_avg.BackColor = Color.White;
            lblEL_avg.BackColor = Color.White;
        }


        private void btnStartTest_Click(object sender, EventArgs e)
        {
            string testFolder;
            string downloadedFilePath;

            //try
            //{
               // if (m_testModeActive == false)
                {
                    // m_testModeActive = true;
                    //btnStartTest.Text = ABORT_TEST;

                    lblProggress.Text = "Test in progress....";

                    btnStartTest.Enabled = false;
                   
                  
                   ClearResults();
                   bgw.RunWorkerAsync();
            //        testFolder = CreateTestFoldert();
            //        ClearFTPFIles();
            //        m_yamabManager.SetMainSystemMode(1);//Gun Slave
            //        System.Threading.Thread.Sleep(1000);
            //        SetYAMAB_AZ(0);
            //        SetYAMAB_EL(0);
            //        System.Threading.Thread.Sleep(500);
            //        m_ethernetCommManager.ClientConnect(Program.appSettings.IP, 23, 2000);
            //        System.Threading.Thread.Sleep(2000);
            //        m_ethernetCommManager.ClientSendMessageAsci("SetTest " + 150, 1, 0);
            //        System.Threading.Thread.Sleep(1000);
            //        if (!WaitForTestCompleted())
            //        {
            //            MessageBox.Show(Messages.Msg015);
            //        }
            //        else
            //        {
            //            downloadedFilePath = DownloadTestResultFTPFIle(testFolder);
            //            AnalyzeTestFile(downloadedFilePath);
            //            lblProggress.Text = "Test completed!";
            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    Shared.HandleError(ex, Messages.Msg014);
            //    lblProggress.Text = "";
            //}
            //finally
            //{
            //    try
            //    {
            //        m_ethernetCommManager.ClientDisconnect();
            //    }
            //    catch
            //    {

            //    }
            //    //m_testModeActive = false;
            //    //btnStartTest.Text = START_TEST;
            //    btnStartTest.Enabled = true;
            }

        }

        private bool WaitForTestCompleted()
        {
            bool retVal = false;
            string readString,strMain=string.Empty;
            DateTime dtStart=DateTime.Now;

            while ((DateTime.Now - dtStart).Minutes < 2)
            {
                m_ethernetCommManager.ClientReadMessageAsci(out readString);
                strMain += readString;
                if (strMain.Contains("Test task is done"))
                {
                    retVal = true;
                    break;
                }
                System.Threading.Thread.Sleep(100);
            }
            
            return retVal;
        }

        private void SetYAMAB_AZ(float posMrad)
        {
            byte bazMode, solonoidJacking, solonoidTraverse, driftCalibrationStatus;
            float traverseAngleGunnerMirror=0, jackingAngleGunnerMirror=0, sachiputResetValueTraverse, sachiputResetValueJacking;
            DateTime dtStart;   
            
            m_yamabManager.SetBazParameters(5, posMrad);
            System.Threading.Thread.Sleep(500);
            m_yamabManager.GetAllSensorsInformation(out bazMode,
                                                   out traverseAngleGunnerMirror,
                                                   out jackingAngleGunnerMirror,
                                                   out solonoidJacking,
                                                   out solonoidTraverse,
                                                   out sachiputResetValueTraverse,
                                                   out sachiputResetValueJacking, out driftCalibrationStatus);


            dtStart = DateTime.Now;
            while (Math.Abs((Math.Abs(((traverseAngleGunnerMirror * 1000)) - Math.Abs(posMrad))))> 0.01 && ((DateTime.Now- dtStart).Seconds<10))
            {
                m_yamabManager.GetAllSensorsInformation(out bazMode,
                                                    out traverseAngleGunnerMirror,
                                                    out jackingAngleGunnerMirror,
                                                    out solonoidJacking,
                                                    out solonoidTraverse,
                                                    out sachiputResetValueTraverse,
                                                    out sachiputResetValueJacking, out driftCalibrationStatus);
                System.Threading.Thread.Sleep(100);
            }

        }

        private void SetYAMAB_EL(float posMrad)
        {
            byte bazMode, solonoidJacking, solonoidTraverse, driftCalibrationStatus;
            float traverseAngleGunnerMirror = 0, jackingAngleGunnerMirror = 0, sachiputResetValueTraverse, sachiputResetValueJacking;
            DateTime dtStart;

            m_yamabManager.SetBazParameters(4, posMrad);
            System.Threading.Thread.Sleep(500);
            m_yamabManager.GetAllSensorsInformation(out bazMode,
                                                   out traverseAngleGunnerMirror,
                                                   out jackingAngleGunnerMirror,
                                                   out solonoidJacking,
                                                   out solonoidTraverse,
                                                   out sachiputResetValueTraverse,
                                                   out sachiputResetValueJacking, out driftCalibrationStatus);


            dtStart = DateTime.Now;
            while (Math.Abs((Math.Abs(((jackingAngleGunnerMirror * 1000)) - Math.Abs(posMrad)))) > 0.01 && ((DateTime.Now - dtStart).Seconds < 10))
            {
                m_yamabManager.GetAllSensorsInformation(out bazMode,
                                                    out traverseAngleGunnerMirror,
                                                    out jackingAngleGunnerMirror,
                                                    out solonoidJacking,
                                                    out solonoidTraverse,
                                                    out sachiputResetValueTraverse,
                                                    out sachiputResetValueJacking, out driftCalibrationStatus);
                System.Threading.Thread.Sleep(100);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            double avgElevation, avgAzimuth, azimuthSTD, elevarionSTD;
            double[] arrElevation, arrAzimuth;
            //string filePath= @"D:\Orion\Projects\YAMAB\NewDemmands\gyro.csv";
            string filePath = @"C:\efi\YAMAB\NewDemmands\gyro.csv";

            ClearResults();

            m_fileManager.LoadNumericColumnFromDelimitedTextFile(filePath, ",", "31", out arrElevation);
            m_fileManager.LoadNumericColumnFromDelimitedTextFile(filePath, ",", "32", out arrAzimuth);

            UpdateGraph(arrElevation, arrAzimuth);

            math_manager.CalcAverage(arrElevation, out avgElevation);
            math_manager.CalcAverage(arrAzimuth, out avgAzimuth);

            math_manager.STD(arrAzimuth, out azimuthSTD);
            math_manager.STD(arrElevation, out elevarionSTD);

            azimuthSTD = Math.Round(azimuthSTD, 8);
            lblAZ_STD.Text = azimuthSTD.ToString();

            elevarionSTD = Math.Round(elevarionSTD, 8);
            lblEL_STD.Text = elevarionSTD.ToString();

            avgAzimuth = Math.Round(avgAzimuth, 8);
            lblAZ_avg.Text = avgAzimuth.ToString();

            avgElevation = Math.Round(avgElevation, 8);
            lblEL_avg.Text = avgElevation.ToString();
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            string testFolder;
            string downloadedFilePath;

            try
            {
                testFolder = CreateTestFoldert();
                ClearFTPFIles();
                m_yamabManager.SetMainSystemMode(1);//Gun Slave
                System.Threading.Thread.Sleep(1000);
                SetYAMAB_AZ(0);
                SetYAMAB_EL(0);
                System.Threading.Thread.Sleep(500);
                m_ethernetCommManager.ClientConnect(Program.appSettings.IP, 23, 2000);
                System.Threading.Thread.Sleep(2000);
                m_ethernetCommManager.ClientSendMessageAsci("SetTest " + 150, 1, 0);
                System.Threading.Thread.Sleep(1000);
                if (!WaitForTestCompleted())
                {
                    m_TestOK = false;
                    // MessageBox.Show(Messages.Msg015);
                }
                else
                {
                    downloadedFilePath = DownloadTestResultFTPFIle(testFolder);
                    AnalyzeTestFile(downloadedFilePath);
                    m_TestOK = true;

                }
            }
            catch (Exception ex)
            {
                Shared.HandleError(ex, Messages.Msg014);
               
            }
            finally
            {
                try
                {
                    m_ethernetCommManager.ClientDisconnect();
                }
                catch
                {

                }
                //m_testModeActive = false;
                //btnStartTest.Text = START_TEST;
               // btnStartTest.Enabled = true;
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            UpdateResultsInGUI();
            btnStartTest.Enabled = true;
           
        }

        private void UpdateResultsInGUI()
        {
            if (m_TestOK)
            {
                UpdateResultDetails(lblAZ_STD, m_results.AZ_STD, Program.appSettings.Stability_AZ_STD_Min, Program.appSettings.Stability_AZ_STD_Max);
                UpdateResultDetails(lblEL_STD, m_results.EL_STD, Program.appSettings.Stability_EL_STD_Min, Program.appSettings.Stability_EL_STD_Max);
                UpdateResultDetails(lblAZ_avg, m_results.AZ_AVG, Program.appSettings.Stability_AZ_AVG_Min, Program.appSettings.Stability_AZ_AVG_Max);
                UpdateResultDetails(lblEL_avg, m_results.EL_AVG, Program.appSettings.Stability_EL_AVG_Min, Program.appSettings.Stability_EL_AVG_Max);

               
                UpdateGraph(m_results.arrElevation, m_results.arrAzimuth);

                lblProggress.Text = "Test completed!";
            }
            else
            {
                MessageBox.Show(Messages.Msg015);
                lblProggress.Text = "";
               
                ClearResults();
            }

        }

        private void UpdateResultDetails(Label lbl, double result, double min, double max)
        {
            lbl.Text = result.ToString();
            if (result >= min && result <= max)
            {
                lbl.BackColor = PASS_COLOR;
            }
            else
            {
                lbl.BackColor = FAIL_COLOR;
            }
        }
    }
}
