using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrionTools
{
    internal     partial  class frmMessageBox : Form
    {
        bool m_detailedMode=false;
        bool m_EnableAbort = false;//indicates if the abort button wil be visible
        bool m_abortForm=false;

        public bool AbortForm
        {
            get
            {
                return m_abortForm;
            }
        }

      
        public frmMessageBox(string caption, string message, string details, MessageBoxDetailed.sevirities level)
        {
            InitializeComponent();
            this.Text = caption;
            lblMessage.Text = message;
            txtDetails.Text = details;
            
            bool enableValue=false;
            if (details != null)
            {
                if (details != string.Empty)
                {
                    enableValue = true;
                }
            }
            btnDetails.Enabled = enableValue;
            btnAbort.Visible = m_EnableAbort;
        }

        public frmMessageBox(string caption, string message, string details, MessageBoxDetailed.sevirities level,bool enableAbort)
        {
            InitializeComponent();
            this.Text = caption;
            lblMessage.Text = message;
            txtDetails.Text = details;

            bool enableValue = false;
            if (details != null)
            {
                if (details != string.Empty)
                {
                    enableValue = true;
                }
            }

            
            btnDetails.Enabled = enableValue;

            m_EnableAbort = enableAbort;
            btnAbort.Visible = m_EnableAbort;
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (m_detailedMode)
            {
                this.Height = this.Height - txtDetails.Height - 10;
            }
            else
            {
                this.Height = this.Height + txtDetails.Height + 10;
            }
            m_detailedMode = !(m_detailedMode);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            m_abortForm = true;
            this.Close();
        }
    }

    public static class MessageBoxDetailed
    {
        static bool m_abortClass = false;

        public static bool Aborted
        {
            get 
            {
                return m_abortClass;
            }
        }

        public enum sevirities
        {
            warning,
            information,
            error,
            fatal
        }

        public static void Display(string caption, string message, string details, sevirities level)
        {
            frmMessageBox frmToLoad = new frmMessageBox(caption, message, details, level);
            frmToLoad.TopMost = true;//issue 9013 :fixed bug
            frmToLoad.ShowDialog();
        }

        public static void Display(string caption, string message, string details, sevirities level,bool enableAbort)
        {
            frmMessageBox frmToLoad = new frmMessageBox(caption, message, details, level, enableAbort);
            frmToLoad.TopMost = true;//issue 9013 :fixed bug
            frmToLoad.ShowDialog();
            m_abortClass = frmToLoad.AbortForm;
        }

        //public static void Display(string caption, string message, Exception ex, sevirities level)
        //{
        //    frmMessageBox frmToLoad = new frmMessageBox(caption, message, ex.Message+Environment.NewLine+ex.ToString(), level);
        //    frmToLoad.ShowDialog();
        //}
    }
}