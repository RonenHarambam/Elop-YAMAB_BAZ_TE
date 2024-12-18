namespace YAMAB_Utilities
{
    partial class FrmBar
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
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.lblComm = new System.Windows.Forms.Label();
            this.txtReadAZ_deg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadEL_deg = new System.Windows.Forms.TextBox();
            this.tBarVertical = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tBarHorizontal = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBarVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHorizontal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwRead
            // 
            this.bgwRead.WorkerReportsProgress = true;
            this.bgwRead.WorkerSupportsCancellation = true;
            this.bgwRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRead_DoWork);
            this.bgwRead.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRead_ProgressChanged);
            // 
            // lblComm
            // 
            this.lblComm.BackColor = System.Drawing.Color.Red;
            this.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblComm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblComm.ForeColor = System.Drawing.Color.Black;
            this.lblComm.Location = new System.Drawing.Point(0, 494);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(493, 37);
            this.lblComm.TabIndex = 77;
            this.lblComm.Text = "Not Conected";
            this.lblComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReadAZ_deg
            // 
            this.txtReadAZ_deg.BackColor = System.Drawing.Color.Black;
            this.txtReadAZ_deg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadAZ_deg.ForeColor = System.Drawing.Color.Lime;
            this.txtReadAZ_deg.Location = new System.Drawing.Point(180, 442);
            this.txtReadAZ_deg.Name = "txtReadAZ_deg";
            this.txtReadAZ_deg.ReadOnly = true;
            this.txtReadAZ_deg.Size = new System.Drawing.Size(110, 30);
            this.txtReadAZ_deg.TabIndex = 88;
            this.txtReadAZ_deg.Text = "0.00";
            this.txtReadAZ_deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(293, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 14);
            this.label4.TabIndex = 89;
            this.label4.Text = "[Deg]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(377, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 14);
            this.label3.TabIndex = 91;
            this.label3.Text = "[Deg]";
            // 
            // txtReadEL_deg
            // 
            this.txtReadEL_deg.BackColor = System.Drawing.Color.Black;
            this.txtReadEL_deg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadEL_deg.ForeColor = System.Drawing.Color.Lime;
            this.txtReadEL_deg.Location = new System.Drawing.Point(267, 205);
            this.txtReadEL_deg.Name = "txtReadEL_deg";
            this.txtReadEL_deg.ReadOnly = true;
            this.txtReadEL_deg.Size = new System.Drawing.Size(110, 30);
            this.txtReadEL_deg.TabIndex = 90;
            this.txtReadEL_deg.Text = "0.00";
            this.txtReadEL_deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBarVertical
            // 
            this.tBarVertical.BackColor = System.Drawing.Color.Black;
            this.tBarVertical.Enabled = false;
            this.tBarVertical.Location = new System.Drawing.Point(216, 30);
            this.tBarVertical.Maximum = 24;
            this.tBarVertical.Minimum = -15;
            this.tBarVertical.Name = "tBarVertical";
            this.tBarVertical.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tBarVertical.Size = new System.Drawing.Size(45, 316);
            this.tBarVertical.TabIndex = 92;
            this.tBarVertical.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 93;
            this.label1.Text = "0°";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tBarHorizontal
            // 
            this.tBarHorizontal.BackColor = System.Drawing.Color.Black;
            this.tBarHorizontal.Enabled = false;
            this.tBarHorizontal.Location = new System.Drawing.Point(32, 365);
            this.tBarHorizontal.Maximum = 4;
            this.tBarHorizontal.Minimum = -4;
            this.tBarHorizontal.Name = "tBarHorizontal";
            this.tBarHorizontal.Size = new System.Drawing.Size(412, 45);
            this.tBarHorizontal.TabIndex = 94;
            this.tBarHorizontal.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(175, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 95;
            this.label2.Text = "-15°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(175, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "24°";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(218, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 25);
            this.label6.TabIndex = 97;
            this.label6.Text = "0°";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(403, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 25);
            this.label7.TabIndex = 98;
            this.label7.Text = "4°";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(32, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 99;
            this.label8.Text = "-4°";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBarVertical);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtReadAZ_deg);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReadEL_deg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBarHorizontal);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 494);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // FrmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(493, 531);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblComm);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBar_FormClosing);
            this.Load += new System.EventHandler(this.FrmBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBarVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarHorizontal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.TextBox txtReadAZ_deg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReadEL_deg;
        private System.Windows.Forms.TrackBar tBarVertical;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBarHorizontal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}