using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OTools
{
    public partial class FrmOKCancelBase : Form
    {
        protected bool m_OK = false;
        protected bool m_dirty = false;

        public FrmOKCancelBase()
        {
            InitializeComponent();
        }

        protected virtual bool SaveImplementation()
        {
            return true;
        }

        protected virtual bool SaveChanges(out string errDetails)
        {
            errDetails = string.Empty;
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Ronen issue #1229. 
        /// </remarks>
        public bool OkCancelVisible
        {
            get
            {
                return pnlBottom.Visible;
            }
            set
            {
                if ((value == false)&& (pnlBottom.Visible))
                {
                    this.Height = this.Height - pnlBottom.Height - 10;
                }
                pnlBottom.Visible = value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_OK = true;
            SaveImplementation();
        }

        protected virtual void CancelClick()
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            m_OK = false;
            CancelClick();
        }

        public bool OK
        {
            get
            {
                return m_OK;
            }
        }

        public bool Dirty
        {
            get
            {
                return m_dirty;
            }
        }

        /// <summary>
        /// Return true if any change has been done in the form data and the the user exit the form
        /// by pressing OK
        /// </summary>
        public bool FormChanged
        {
            get
            {
                return (m_OK && m_dirty);
            }
        }

        public void EnableOK(bool value)
        {
            btnOK.Enabled = value;
        }

        protected virtual void InitGUI()
        {
        }

        private void FrmOKCancelBase_Load(object sender, EventArgs e)
        {
            InitGUI();
        }

        private void FrmOKCancelBase_RightToLeftChanged(object sender, EventArgs e)
        {
            if (this.RightToLeft == RightToLeft.Yes)
            {
                pnlOKCancelRtl.Visible = true;
                pnlOKCancel.Visible = false;
            }
            else
            {
                pnlOKCancelRtl.Visible = false;
                pnlOKCancel.Visible = true;
            }
        }
    }
}