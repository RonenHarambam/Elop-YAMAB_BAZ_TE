namespace YAMAB_Utilities
{
    partial class FrmControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControl));
            this.lblTestName = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.spMessage = new System.Windows.Forms.SplitContainer();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.txtReadEL_mrad = new System.Windows.Forms.TextBox();
            this.txtReadEL_deg = new System.Windows.Forms.TextBox();
            this.lblEL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReadAZ_deg = new System.Windows.Forms.TextBox();
            this.txtReadAZ_mrad = new System.Windows.Forms.TextBox();
            this.btnLeft_bigStep = new System.Windows.Forms.Button();
            this.btnRight_bigStep = new System.Windows.Forms.Button();
            this.btnDown_bigStep = new System.Windows.Forms.Button();
            this.btnUp_bigStep = new System.Windows.Forms.Button();
            this.btnLeft_smallStep = new System.Windows.Forms.Button();
            this.btnRight_smallStep = new System.Windows.Forms.Button();
            this.btnDown_smallStep = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUp_smallStep = new System.Windows.Forms.Button();
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.lblCommCaption = new System.Windows.Forms.Label();
            this.lblComm = new System.Windows.Forms.Label();
            this.txtReadSystemMode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReadDriftStatus = new System.Windows.Forms.TextBox();
            this.txtMicroSwStatus_AZ = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMicroSwStatus_EL = new System.Windows.Forms.TextBox();
            this.pnlParameterValue = new System.Windows.Forms.Panel();
            this.numParameterValue = new System.Windows.Forms.NumericUpDown();
            this.lblParameterCaption = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnFail = new System.Windows.Forms.Button();
            this.btnPass = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblAZ = new System.Windows.Forms.Label();
            this.pnlSightMovement = new System.Windows.Forms.Panel();
            this.lblSightMovement = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlYamabDetails = new System.Windows.Forms.Panel();
            this.lblInitializationUpdate = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spMessage)).BeginInit();
            this.spMessage.Panel1.SuspendLayout();
            this.spMessage.Panel2.SuspendLayout();
            this.spMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.pnlParameterValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParameterValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSightMovement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlYamabDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTestName
            // 
            this.lblTestName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblTestName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTestName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTestName.Location = new System.Drawing.Point(0, 0);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(1086, 47);
            this.lblTestName.TabIndex = 0;
            this.lblTestName.Text = "Test";
            this.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.BackColor = System.Drawing.SystemColors.Control;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.spMessage);
            this.pnlTop.Controls.Add(this.lblTestName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1088, 354);
            this.pnlTop.TabIndex = 1;
            // 
            // spMessage
            // 
            this.spMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMessage.Location = new System.Drawing.Point(0, 47);
            this.spMessage.Name = "spMessage";
            // 
            // spMessage.Panel1
            // 
            this.spMessage.Panel1.Controls.Add(this.txtMessage);
            // 
            // spMessage.Panel2
            // 
            this.spMessage.Panel2.Controls.Add(this.picImage);
            this.spMessage.Size = new System.Drawing.Size(1086, 305);
            this.spMessage.SplitterDistance = 590;
            this.spMessage.TabIndex = 3;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(590, 305);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.Text = "Message";
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // picImage
            // 
            this.picImage.BackColor = System.Drawing.Color.Black;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(492, 305);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
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
            this.lblCommCaption.Location = new System.Drawing.Point(8, 319);
            this.lblCommCaption.Name = "lblCommCaption";
            this.lblCommCaption.Size = new System.Drawing.Size(45, 14);
            this.lblCommCaption.TabIndex = 76;
            this.lblCommCaption.Text = "Comm";
            // 
            // lblComm
            // 
            this.lblComm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblComm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComm.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblComm.ForeColor = System.Drawing.Color.Lime;
            this.lblComm.Location = new System.Drawing.Point(56, 310);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(54, 32);
            this.lblComm.TabIndex = 75;
            this.lblComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnlParameterValue
            // 
            this.pnlParameterValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlParameterValue.Controls.Add(this.numParameterValue);
            this.pnlParameterValue.Controls.Add(this.lblParameterCaption);
            this.pnlParameterValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pnlParameterValue.Location = new System.Drawing.Point(3, 251);
            this.pnlParameterValue.Name = "pnlParameterValue";
            this.pnlParameterValue.Size = new System.Drawing.Size(285, 42);
            this.pnlParameterValue.TabIndex = 85;
            // 
            // numParameterValue
            // 
            this.numParameterValue.DecimalPlaces = 3;
            this.numParameterValue.Location = new System.Drawing.Point(175, 9);
            this.numParameterValue.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numParameterValue.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numParameterValue.Name = "numParameterValue";
            this.numParameterValue.Size = new System.Drawing.Size(104, 27);
            this.numParameterValue.TabIndex = 4;
            this.numParameterValue.ValueChanged += new System.EventHandler(this.numParameterValue_ValueChanged);
            // 
            // lblParameterCaption
            // 
            this.lblParameterCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblParameterCaption.Location = new System.Drawing.Point(3, 9);
            this.lblParameterCaption.Name = "lblParameterCaption";
            this.lblParameterCaption.Size = new System.Drawing.Size(137, 23);
            this.lblParameterCaption.TabIndex = 3;
            this.lblParameterCaption.Text = "Param Name";
            this.lblParameterCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOK.Location = new System.Drawing.Point(762, 303);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(221, 47);
            this.btnOK.TabIndex = 79;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnFail
            // 
            this.btnFail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFail.Location = new System.Drawing.Point(406, 303);
            this.btnFail.Name = "btnFail";
            this.btnFail.Size = new System.Drawing.Size(108, 47);
            this.btnFail.TabIndex = 78;
            this.btnFail.Text = "Fail";
            this.btnFail.UseVisualStyleBackColor = false;
            this.btnFail.Click += new System.EventHandler(this.btnFail_Click);
            // 
            // btnPass
            // 
            this.btnPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPass.Location = new System.Drawing.Point(520, 303);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(108, 47);
            this.btnPass.TabIndex = 77;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = false;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
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
            // pnlYamabDetails
            // 
            this.pnlYamabDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlYamabDetails.BackColor = System.Drawing.SystemColors.Control;
            this.pnlYamabDetails.Controls.Add(this.lblInitializationUpdate);
            this.pnlYamabDetails.Controls.Add(this.btnOK);
            this.pnlYamabDetails.Controls.Add(this.btnFail);
            this.pnlYamabDetails.Controls.Add(this.pnlSightMovement);
            this.pnlYamabDetails.Controls.Add(this.btnPass);
            this.pnlYamabDetails.Controls.Add(this.splitContainer1);
            this.pnlYamabDetails.Controls.Add(this.lblComm);
            this.pnlYamabDetails.Controls.Add(this.panel1);
            this.pnlYamabDetails.Controls.Add(this.lblCommCaption);
            this.pnlYamabDetails.Controls.Add(this.pnlParameterValue);
            this.pnlYamabDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlYamabDetails.Location = new System.Drawing.Point(0, 360);
            this.pnlYamabDetails.Name = "pnlYamabDetails";
            this.pnlYamabDetails.Size = new System.Drawing.Size(1088, 353);
            this.pnlYamabDetails.TabIndex = 93;
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
            // FrmControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 713);
            this.Controls.Add(this.pnlYamabDetails);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmControl";
            this.ShowIcon = false;
            this.Text = "YAMAB GUI Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmControl_FormClosing);
            this.Load += new System.EventHandler(this.FrmControl_Load);
            this.pnlTop.ResumeLayout(false);
            this.spMessage.Panel1.ResumeLayout(false);
            this.spMessage.Panel1.PerformLayout();
            this.spMessage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMessage)).EndInit();
            this.spMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.pnlParameterValue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numParameterValue)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlSightMovement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlYamabDetails.ResumeLayout(false);
            this.pnlYamabDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtReadEL_mrad;
        private System.Windows.Forms.TextBox txtReadEL_deg;
        private System.Windows.Forms.Label lblEL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReadAZ_deg;
        private System.Windows.Forms.TextBox txtReadAZ_mrad;
        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.Label lblCommCaption;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.Button btnLeft_bigStep;
        private System.Windows.Forms.Button btnRight_bigStep;
        private System.Windows.Forms.Button btnDown_bigStep;
        private System.Windows.Forms.Button btnUp_bigStep;
        private System.Windows.Forms.Button btnLeft_smallStep;
        private System.Windows.Forms.Button btnRight_smallStep;
        private System.Windows.Forms.Button btnDown_smallStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUp_smallStep;
        private System.Windows.Forms.TextBox txtReadSystemMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReadDriftStatus;
        private System.Windows.Forms.TextBox txtMicroSwStatus_AZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMicroSwStatus_EL;
        private System.Windows.Forms.Panel pnlParameterValue;
        private System.Windows.Forms.Label lblParameterCaption;
        private System.Windows.Forms.NumericUpDown numParameterValue;
        private System.Windows.Forms.Button btnPass;
        private System.Windows.Forms.Button btnFail;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblAZ;
        private System.Windows.Forms.Panel pnlSightMovement;
        private System.Windows.Forms.Label lblSightMovement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.SplitContainer spMessage;
        private System.Windows.Forms.Panel pnlYamabDetails;
        private System.Windows.Forms.Label lblInitializationUpdate;
    }
}