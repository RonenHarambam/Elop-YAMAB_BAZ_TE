namespace YAMAB_Utilities
{
    partial class FrmControlSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlSimple));
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.lblCommCaption = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReadSystemMode = new System.Windows.Forms.TextBox();
            this.txtReadDriftStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComm = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReadEL_mrad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReadEL_deg = new System.Windows.Forms.TextBox();
            this.txtMicroSwStatus_EL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblAZ = new System.Windows.Forms.Label();
            this.txtReadAZ_mrad = new System.Windows.Forms.TextBox();
            this.txtReadAZ_deg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMicroSwStatus_AZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSightMovement = new System.Windows.Forms.Panel();
            this.lblSightMovement = new System.Windows.Forms.Label();
            this.btnUp_bigStep = new System.Windows.Forms.Button();
            this.btnLeft_bigStep = new System.Windows.Forms.Button();
            this.btnUp_smallStep = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRight_bigStep = new System.Windows.Forms.Button();
            this.btnDown_smallStep = new System.Windows.Forms.Button();
            this.btnRight_smallStep = new System.Windows.Forms.Button();
            this.btnDown_bigStep = new System.Windows.Forms.Button();
            this.btnLeft_smallStep = new System.Windows.Forms.Button();
            this.lblInitializationUpdate = new System.Windows.Forms.Label();
            this.pnlYamabDetails = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSightMovement.SuspendLayout();
            this.pnlYamabDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwRead
            // 
            this.bgwRead.WorkerReportsProgress = true;
            this.bgwRead.WorkerSupportsCancellation = true;
            this.bgwRead.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwRead_DoWork);
            this.bgwRead.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwRead_ProgressChanged);
            // 
            // lblCommCaption
            // 
            this.lblCommCaption.AutoSize = true;
            this.lblCommCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCommCaption.Location = new System.Drawing.Point(8, 269);
            this.lblCommCaption.Name = "lblCommCaption";
            this.lblCommCaption.Size = new System.Drawing.Size(45, 14);
            this.lblCommCaption.TabIndex = 76;
            this.lblCommCaption.Text = "Comm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtReadSystemMode);
            this.panel1.Controls.Add(this.txtReadDriftStatus);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(5, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 65);
            this.panel1.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 78;
            this.label1.Text = "System Mode";
            // 
            // txtReadSystemMode
            // 
            this.txtReadSystemMode.BackColor = System.Drawing.Color.Black;
            this.txtReadSystemMode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadSystemMode.ForeColor = System.Drawing.Color.Lime;
            this.txtReadSystemMode.Location = new System.Drawing.Point(157, 4);
            this.txtReadSystemMode.Name = "txtReadSystemMode";
            this.txtReadSystemMode.Size = new System.Drawing.Size(200, 27);
            this.txtReadSystemMode.TabIndex = 77;
            this.txtReadSystemMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadDriftStatus
            // 
            this.txtReadDriftStatus.BackColor = System.Drawing.Color.Black;
            this.txtReadDriftStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadDriftStatus.ForeColor = System.Drawing.Color.Lime;
            this.txtReadDriftStatus.Location = new System.Drawing.Point(157, 33);
            this.txtReadDriftStatus.Name = "txtReadDriftStatus";
            this.txtReadDriftStatus.Size = new System.Drawing.Size(200, 27);
            this.txtReadDriftStatus.TabIndex = 79;
            this.txtReadDriftStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 80;
            this.label6.Text = "Drift Status";
            // 
            // lblComm
            // 
            this.lblComm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblComm.ForeColor = System.Drawing.Color.Lime;
            this.lblComm.Location = new System.Drawing.Point(56, 260);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(73, 32);
            this.lblComm.TabIndex = 75;
            this.lblComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(5, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblEL);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtReadEL_mrad);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtReadEL_deg);
            this.splitContainer1.Panel1.Controls.Add(this.txtMicroSwStatus_EL);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblAZ);
            this.splitContainer1.Panel2.Controls.Add(this.txtReadAZ_mrad);
            this.splitContainer1.Panel2.Controls.Add(this.txtReadAZ_deg);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtMicroSwStatus_AZ);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(584, 174);
            this.splitContainer1.SplitterDistance = 285;
            this.splitContainer1.TabIndex = 90;
            // 
            // lblEL
            // 
            this.lblEL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblEL.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEL.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEL.Location = new System.Drawing.Point(0, 0);
            this.lblEL.Name = "lblEL";
            this.lblEL.Size = new System.Drawing.Size(283, 23);
            this.lblEL.TabIndex = 2;
            this.lblEL.Text = "Elevation";
            this.lblEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(205, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 89;
            this.label3.Text = "[Deg]";
            // 
            // txtReadEL_mrad
            // 
            this.txtReadEL_mrad.BackColor = System.Drawing.Color.Black;
            this.txtReadEL_mrad.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadEL_mrad.ForeColor = System.Drawing.Color.Lime;
            this.txtReadEL_mrad.Location = new System.Drawing.Point(43, 42);
            this.txtReadEL_mrad.Name = "txtReadEL_mrad";
            this.txtReadEL_mrad.Size = new System.Drawing.Size(160, 33);
            this.txtReadEL_mrad.TabIndex = 2;
            this.txtReadEL_mrad.Text = "0.00";
            this.txtReadEL_mrad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(205, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 88;
            this.label2.Text = "[mRad]";
            // 
            // txtReadEL_deg
            // 
            this.txtReadEL_deg.BackColor = System.Drawing.Color.Black;
            this.txtReadEL_deg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadEL_deg.ForeColor = System.Drawing.Color.Lime;
            this.txtReadEL_deg.Location = new System.Drawing.Point(43, 77);
            this.txtReadEL_deg.Name = "txtReadEL_deg";
            this.txtReadEL_deg.Size = new System.Drawing.Size(160, 33);
            this.txtReadEL_deg.TabIndex = 3;
            this.txtReadEL_deg.Text = "0.00";
            this.txtReadEL_deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMicroSwStatus_EL
            // 
            this.txtMicroSwStatus_EL.BackColor = System.Drawing.Color.Black;
            this.txtMicroSwStatus_EL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMicroSwStatus_EL.ForeColor = System.Drawing.Color.Lime;
            this.txtMicroSwStatus_EL.Location = new System.Drawing.Point(43, 141);
            this.txtMicroSwStatus_EL.Name = "txtMicroSwStatus_EL";
            this.txtMicroSwStatus_EL.Size = new System.Drawing.Size(160, 27);
            this.txtMicroSwStatus_EL.TabIndex = 83;
            this.txtMicroSwStatus_EL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.Location = new System.Drawing.Point(43, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 18);
            this.label8.TabIndex = 84;
            this.label8.Text = "Micro Switch Status";
            // 
            // lblAZ
            // 
            this.lblAZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblAZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAZ.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAZ.Location = new System.Drawing.Point(0, 0);
            this.lblAZ.Name = "lblAZ";
            this.lblAZ.Size = new System.Drawing.Size(293, 23);
            this.lblAZ.TabIndex = 3;
            this.lblAZ.Text = "Azimuth";
            this.lblAZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReadAZ_mrad
            // 
            this.txtReadAZ_mrad.BackColor = System.Drawing.Color.Black;
            this.txtReadAZ_mrad.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadAZ_mrad.ForeColor = System.Drawing.Color.Lime;
            this.txtReadAZ_mrad.Location = new System.Drawing.Point(45, 42);
            this.txtReadAZ_mrad.Name = "txtReadAZ_mrad";
            this.txtReadAZ_mrad.Size = new System.Drawing.Size(160, 33);
            this.txtReadAZ_mrad.TabIndex = 6;
            this.txtReadAZ_mrad.Text = "0.00";
            this.txtReadAZ_mrad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReadAZ_deg
            // 
            this.txtReadAZ_deg.BackColor = System.Drawing.Color.Black;
            this.txtReadAZ_deg.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtReadAZ_deg.ForeColor = System.Drawing.Color.Lime;
            this.txtReadAZ_deg.Location = new System.Drawing.Point(45, 77);
            this.txtReadAZ_deg.Name = "txtReadAZ_deg";
            this.txtReadAZ_deg.Size = new System.Drawing.Size(160, 33);
            this.txtReadAZ_deg.TabIndex = 8;
            this.txtReadAZ_deg.Text = "0.00";
            this.txtReadAZ_deg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(207, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 87;
            this.label4.Text = "[Deg]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(207, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "[mRad]";
            // 
            // txtMicroSwStatus_AZ
            // 
            this.txtMicroSwStatus_AZ.BackColor = System.Drawing.Color.Black;
            this.txtMicroSwStatus_AZ.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMicroSwStatus_AZ.ForeColor = System.Drawing.Color.Lime;
            this.txtMicroSwStatus_AZ.Location = new System.Drawing.Point(45, 141);
            this.txtMicroSwStatus_AZ.Name = "txtMicroSwStatus_AZ";
            this.txtMicroSwStatus_AZ.Size = new System.Drawing.Size(160, 27);
            this.txtMicroSwStatus_AZ.TabIndex = 81;
            this.txtMicroSwStatus_AZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(45, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Micro Switch Status";
            // 
            // pnlSightMovement
            // 
            this.pnlSightMovement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSightMovement.Controls.Add(this.lblSightMovement);
            this.pnlSightMovement.Controls.Add(this.btnUp_bigStep);
            this.pnlSightMovement.Controls.Add(this.btnLeft_bigStep);
            this.pnlSightMovement.Controls.Add(this.btnUp_smallStep);
            this.pnlSightMovement.Controls.Add(this.btnReset);
            this.pnlSightMovement.Controls.Add(this.btnRight_bigStep);
            this.pnlSightMovement.Controls.Add(this.btnDown_smallStep);
            this.pnlSightMovement.Controls.Add(this.btnRight_smallStep);
            this.pnlSightMovement.Controls.Add(this.btnDown_bigStep);
            this.pnlSightMovement.Controls.Add(this.btnLeft_smallStep);
            this.pnlSightMovement.Enabled = false;
            this.pnlSightMovement.Location = new System.Drawing.Point(595, 7);
            this.pnlSightMovement.Name = "pnlSightMovement";
            this.pnlSightMovement.Size = new System.Drawing.Size(488, 242);
            this.pnlSightMovement.TabIndex = 91;
            // 
            // lblSightMovement
            // 
            this.lblSightMovement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSightMovement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSightMovement.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSightMovement.Location = new System.Drawing.Point(0, 0);
            this.lblSightMovement.Name = "lblSightMovement";
            this.lblSightMovement.Size = new System.Drawing.Size(486, 23);
            this.lblSightMovement.TabIndex = 4;
            this.lblSightMovement.Text = "Sight Movement";
            this.lblSightMovement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp_bigStep
            // 
            this.btnUp_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnUp_bigStep.Image")));
            this.btnUp_bigStep.Location = new System.Drawing.Point(209, 35);
            this.btnUp_bigStep.Name = "btnUp_bigStep";
            this.btnUp_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnUp_bigStep.TabIndex = 22;
            this.btnUp_bigStep.UseVisualStyleBackColor = true;
            this.btnUp_bigStep.Click += new System.EventHandler(this.btnUp_bigStep_Click);
            // 
            // btnLeft_bigStep
            // 
            this.btnLeft_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft_bigStep.Image")));
            this.btnLeft_bigStep.Location = new System.Drawing.Point(91, 113);
            this.btnLeft_bigStep.Name = "btnLeft_bigStep";
            this.btnLeft_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnLeft_bigStep.TabIndex = 25;
            this.btnLeft_bigStep.UseVisualStyleBackColor = true;
            this.btnLeft_bigStep.Click += new System.EventHandler(this.btnLeft_bigStep_Click);
            // 
            // btnUp_smallStep
            // 
            this.btnUp_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnUp_smallStep.Image")));
            this.btnUp_smallStep.Location = new System.Drawing.Point(209, 74);
            this.btnUp_smallStep.Name = "btnUp_smallStep";
            this.btnUp_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnUp_smallStep.TabIndex = 17;
            this.btnUp_smallStep.UseVisualStyleBackColor = true;
            this.btnUp_smallStep.Click += new System.EventHandler(this.btnUp_smallStep_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReset.Location = new System.Drawing.Point(209, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 40);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "H";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRight_bigStep
            // 
            this.btnRight_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnRight_bigStep.Image")));
            this.btnRight_bigStep.Location = new System.Drawing.Point(327, 113);
            this.btnRight_bigStep.Name = "btnRight_bigStep";
            this.btnRight_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnRight_bigStep.TabIndex = 24;
            this.btnRight_bigStep.UseVisualStyleBackColor = true;
            this.btnRight_bigStep.Click += new System.EventHandler(this.btnRight_bigStep_Click);
            // 
            // btnDown_smallStep
            // 
            this.btnDown_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDown_smallStep.Image")));
            this.btnDown_smallStep.Location = new System.Drawing.Point(209, 152);
            this.btnDown_smallStep.Name = "btnDown_smallStep";
            this.btnDown_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnDown_smallStep.TabIndex = 19;
            this.btnDown_smallStep.UseVisualStyleBackColor = true;
            this.btnDown_smallStep.Click += new System.EventHandler(this.btnDown_smallStep_Click);
            // 
            // btnRight_smallStep
            // 
            this.btnRight_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnRight_smallStep.Image")));
            this.btnRight_smallStep.Location = new System.Drawing.Point(268, 113);
            this.btnRight_smallStep.Name = "btnRight_smallStep";
            this.btnRight_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnRight_smallStep.TabIndex = 20;
            this.btnRight_smallStep.UseVisualStyleBackColor = true;
            this.btnRight_smallStep.Click += new System.EventHandler(this.btnRight_smallStep_Click);
            // 
            // btnDown_bigStep
            // 
            this.btnDown_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDown_bigStep.Image")));
            this.btnDown_bigStep.Location = new System.Drawing.Point(209, 191);
            this.btnDown_bigStep.Name = "btnDown_bigStep";
            this.btnDown_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnDown_bigStep.TabIndex = 23;
            this.btnDown_bigStep.UseVisualStyleBackColor = true;
            this.btnDown_bigStep.Click += new System.EventHandler(this.btnDown_bigStep_Click);
            // 
            // btnLeft_smallStep
            // 
            this.btnLeft_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft_smallStep.Image")));
            this.btnLeft_smallStep.Location = new System.Drawing.Point(150, 113);
            this.btnLeft_smallStep.Name = "btnLeft_smallStep";
            this.btnLeft_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnLeft_smallStep.TabIndex = 21;
            this.btnLeft_smallStep.UseVisualStyleBackColor = true;
            this.btnLeft_smallStep.Click += new System.EventHandler(this.btnLeft_smallStep_Click);
            // 
            // lblInitializationUpdate
            // 
            this.lblInitializationUpdate.AutoSize = true;
            this.lblInitializationUpdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblInitializationUpdate.Location = new System.Drawing.Point(597, 252);
            this.lblInitializationUpdate.Name = "lblInitializationUpdate";
            this.lblInitializationUpdate.Size = new System.Drawing.Size(97, 19);
            this.lblInitializationUpdate.TabIndex = 26;
            this.lblInitializationUpdate.Text = "Initializing...";
            this.lblInitializationUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlYamabDetails
            // 
            this.pnlYamabDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlYamabDetails.BackColor = System.Drawing.SystemColors.Control;
            this.pnlYamabDetails.Controls.Add(this.lblInitializationUpdate);
            this.pnlYamabDetails.Controls.Add(this.pnlSightMovement);
            this.pnlYamabDetails.Controls.Add(this.splitContainer1);
            this.pnlYamabDetails.Controls.Add(this.lblComm);
            this.pnlYamabDetails.Controls.Add(this.panel1);
            this.pnlYamabDetails.Controls.Add(this.lblCommCaption);
            this.pnlYamabDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlYamabDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlYamabDetails.Name = "pnlYamabDetails";
            this.pnlYamabDetails.Size = new System.Drawing.Size(1088, 308);
            this.pnlYamabDetails.TabIndex = 93;
            // 
            // FrmControlSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 308);
            this.Controls.Add(this.pnlYamabDetails);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmControlSimple";
            this.ShowIcon = false;
            this.Text = "YAMAB GUI Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControl_FormClosing);
            this.Load += new System.EventHandler(this.FrmControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSightMovement.ResumeLayout(false);
            this.pnlYamabDetails.ResumeLayout(false);
            this.pnlYamabDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.Label lblCommCaption;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReadSystemMode;
        private System.Windows.Forms.TextBox txtReadDriftStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReadEL_mrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReadEL_deg;
        private System.Windows.Forms.TextBox txtMicroSwStatus_EL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblAZ;
        private System.Windows.Forms.TextBox txtReadAZ_mrad;
        private System.Windows.Forms.TextBox txtReadAZ_deg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMicroSwStatus_AZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSightMovement;
        private System.Windows.Forms.Label lblSightMovement;
        private System.Windows.Forms.Button btnUp_bigStep;
        private System.Windows.Forms.Button btnLeft_bigStep;
        private System.Windows.Forms.Button btnUp_smallStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRight_bigStep;
        private System.Windows.Forms.Button btnDown_smallStep;
        private System.Windows.Forms.Button btnRight_smallStep;
        private System.Windows.Forms.Button btnDown_bigStep;
        private System.Windows.Forms.Button btnLeft_smallStep;
        private System.Windows.Forms.Label lblInitializationUpdate;
        private System.Windows.Forms.Panel pnlYamabDetails;
    }
}