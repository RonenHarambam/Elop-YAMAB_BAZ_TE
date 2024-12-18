using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YAMAB;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace YAMAB_Utilities
{
    public class YAMAB_Utilities
    {
        SynchronizationContext m_syncContext;
        FrmBar frmBar;
        FrmControlSimple frmControlSimple;

       public enum ButtonsType
        { 
            OK,
            PASS_FAIL
        }


        public YAMAB_Utilities()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);
            
        }

        System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            string assembliesDir;
            string assemblyFolder;

            assemblyFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            assembliesDir = assemblyFolder + @"\YAMAB.dll";
                     

            System.Reflection.Assembly asm = System.Reflection.Assembly.LoadFrom(assembliesDir);
            return asm;
        }


        private void ReleaseForm(Form frm)
        {
            frm = null;
            frm = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

       

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameterValue"></param>
        /// <param name="result">0:Pass; 1:Fail</param>
        /// <param name="controllerInstance"></param>
        /// <param name="testName"></param>
        /// <param name="testMessage"></param>
        /// <param name="parameterCaption"></param>
        /// <param name="btnOKCaption"></param>
        /// <param name="buttonsType"></param>
        /// <param name="movementBigStep_mrad"></param>
        /// <param name="movementSmallStep_mrad"></param>
        /// <param name="initialPosAZ"></param>
        /// <param name="initialPosEL"></param>
        /// <param name="frmPosX"></param>
        /// <param name="frmPosY"></param>
        /// <param name="initialPosActive"></param>
        public void DisplayControlForm(out double parameterValue, out byte result, object controllerInstance, string testName, string testMessage, string parameterCaption, string btnOKCaption, ButtonsType buttonsType, double movementBigStep_mrad = 0.2, double movementSmallStep_mrad = 0.02,double initialPosAZ=0,double initialPosEL=0, int frmPosX=-1, int frmPosY=-1,byte initialPosActive=0,string picturePath=null)
        {
            FrmControl frm = new FrmControl((YAMAB.YAMABManager)controllerInstance, testName, testMessage, parameterCaption, btnOKCaption, buttonsType, movementBigStep_mrad, movementSmallStep_mrad, initialPosAZ, initialPosEL, frmPosX, frmPosY, initialPosActive, picturePath);
            frm.ShowDialog();
            parameterValue = frm.ParameterValue;
            result = frm.Result;
            ReleaseForm(frm);
        }

        public void DisplayBarForm(object controllerInstance, int frmPosY=-1, int frmPosX=-1)
        {
            frmBar = new FrmBar((YAMAB.YAMABManager)controllerInstance, frmPosY, frmPosX);
            m_syncContext.Send(callback => frmBar.Show(), null);
           
        }

        public void CloseBarForm()
        {
            if (frmBar != null)
            {
                frmBar.Close();
                frmBar = null;
            }
        }


        public void DisplayControlSimpleForm(object controllerInstance, double movementBigStep_mrad = 0.2, double movementSmallStep_mrad = 0.02, double initialPosAZ = 0, double initialPosEL = 0, int frmPosY = -1, int frmPosX = -1)
        {           
            frmControlSimple = new FrmControlSimple((YAMAB.YAMABManager)controllerInstance,  movementBigStep_mrad = 0.2,  movementSmallStep_mrad = 0.02,  initialPosAZ = 0,  initialPosEL = 0,frmPosY, frmPosX);
            m_syncContext.Send(callback => frmControlSimple.Show(), null);

        }

        public void CloseControlSimplerForm()
        {
            if (frmControlSimple != null)
            {
                frmControlSimple.Close();
                frmControlSimple = null;
            }
        }


        /// <summary>
        /// Use for displaying a none modal form.
        /// </summary>
        /// <param name="syncContext"></param>
        public void SetSyncronizationContext(SynchronizationContext syncContext)
        {
            m_syncContext = syncContext;
        }

        public void SplitCSV(string fileContent, string splitter,bool removeEmptyEntries, out string[] arr)
        {
            List<string> lstSplitter = new List<string>();

            if (splitter == "\\n")
            {
                splitter = "\n";
            }

            lstSplitter.Add(splitter);

            if (removeEmptyEntries)
            {
                arr = fileContent.Split(lstSplitter.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                arr = fileContent.Split(lstSplitter.ToArray(), StringSplitOptions.None);
            }
        }

        public void RoundArray(double[]arr,int digits,out double[]arrRound)
        {
            arrRound = new double[arr.Length];
            double val;

            for(int i=0;i<arr.Length;i++)
            {
                val = Math.Round(arr[i], digits);
                arrRound[i] = val;
            }
                
        }

    }
}
