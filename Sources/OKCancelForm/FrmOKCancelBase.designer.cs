namespace OTools
{
    partial class FrmOKCancelBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlOKCancelRtl = new System.Windows.Forms.Panel();
            this.pnlOKCancel = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.pnlOKCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(3, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(86, 26);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(90, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 26);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.pnlOKCancelRtl);
            this.pnlBottom.Controls.Add(this.pnlOKCancel);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 210);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(411, 38);
            this.pnlBottom.TabIndex = 17;
            // 
            // pnlOKCancelRtl
            // 
            this.pnlOKCancelRtl.AutoSize = true;
            this.pnlOKCancelRtl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOKCancelRtl.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOKCancelRtl.Location = new System.Drawing.Point(0, 0);
            this.pnlOKCancelRtl.Name = "pnlOKCancelRtl";
            this.pnlOKCancelRtl.Size = new System.Drawing.Size(0, 36);
            this.pnlOKCancelRtl.TabIndex = 18;
            this.pnlOKCancelRtl.Visible = false;
            // 
            // pnlOKCancel
            // 
            this.pnlOKCancel.AutoSize = true;
            this.pnlOKCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOKCancel.Controls.Add(this.btnOK);
            this.pnlOKCancel.Controls.Add(this.btnCancel);
            this.pnlOKCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOKCancel.Location = new System.Drawing.Point(230, 0);
            this.pnlOKCancel.Name = "pnlOKCancel";
            this.pnlOKCancel.Size = new System.Drawing.Size(179, 36);
            this.pnlOKCancel.TabIndex = 17;
            // 
            // FrmOKCancelBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(411, 248);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmOKCancelBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmBase";
            this.Load += new System.EventHandler(this.FrmOKCancelBase_Load);
            this.RightToLeftChanged += new System.EventHandler(this.FrmOKCancelBase_RightToLeftChanged);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlOKCancel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlOKCancelRtl;
        protected System.Windows.Forms.Panel pnlOKCancel;
    }
}