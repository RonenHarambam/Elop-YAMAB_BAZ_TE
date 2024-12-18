namespace YAMABGUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDriftStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSachiputResetValueJacking = new System.Windows.Forms.TextBox();
            this.lblSachiputResetValueJacking = new System.Windows.Forms.Label();
            this.txtSachiputResetValueTraverse = new System.Windows.Forms.TextBox();
            this.lblSachiputResetValueTraverse = new System.Windows.Forms.Label();
            this.txtSolonoidTraverse = new System.Windows.Forms.TextBox();
            this.lblSolonoidTraverse = new System.Windows.Forms.Label();
            this.txtSolonoidJacking = new System.Windows.Forms.TextBox();
            this.lblSolonoidJacking = new System.Windows.Forms.Label();
            this.txtJackingAngleGunnerMirror_Deg = new System.Windows.Forms.TextBox();
            this.lblJackingAngleGunnerMirror = new System.Windows.Forms.Label();
            this.txtTraverseAngleGunnerMirror_Deg = new System.Windows.Forms.TextBox();
            this.lblTraverseAngleGunnerMirror = new System.Windows.Forms.Label();
            this.txtBazMode = new System.Windows.Forms.TextBox();
            this.lblBazMode = new System.Windows.Forms.Label();
            this.gpGetAllBazFailures = new System.Windows.Forms.GroupBox();
            this.txtErrorNumber = new System.Windows.Forms.TextBox();
            this.lblErrorNumber = new System.Windows.Forms.Label();
            this.btnGetAllBazFailures = new System.Windows.Forms.Button();
            this.txtNumberOfFailures = new System.Windows.Forms.TextBox();
            this.lblNumberOfFailures = new System.Windows.Forms.Label();
            this.BazFailuresUpdate = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnGetBazFailuresUpdate = new System.Windows.Forms.Button();
            this.txtFailureNumber = new System.Windows.Forms.TextBox();
            this.lblFailureNumber = new System.Windows.Forms.Label();
            this.gpRequestErrorTable = new System.Windows.Forms.GroupBox();
            this.btnRequestErrorTable = new System.Windows.Forms.Button();
            this.txtRX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTX = new System.Windows.Forms.TextBox();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbConnect = new System.Windows.Forms.ToolStripButton();
            this.tsbDisconnect = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGyroTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMaintenance = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bgwRead = new System.ComponentModel.BackgroundWorker();
            this.lblComm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtJackingAngleGunnerMirror_Mrad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTraverseAngleGunnerMirror_Mrad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSetAZ_Mrad = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numSetAZ_Mrad = new System.Windows.Forms.NumericUpDown();
            this.btnSetAZ_Deg = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numSetAZ_Deg = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSetEL_Mrad = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.numSetEL_Mrad = new System.Windows.Forms.NumericUpDown();
            this.btnSetEL_Deg = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.numSetEL_Deg = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDrift = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.numSmallStep = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numBigStep = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUp_bigStep = new System.Windows.Forms.Button();
            this.btnLeft_smallStep = new System.Windows.Forms.Button();
            this.btnDown_bigStep = new System.Windows.Forms.Button();
            this.btnRight_smallStep = new System.Windows.Forms.Button();
            this.btnLeft_bigStep = new System.Windows.Forms.Button();
            this.btnDown_smallStep = new System.Windows.Forms.Button();
            this.btnUp_smallStep = new System.Windows.Forms.Button();
            this.btnRight_bigStep = new System.Windows.Forms.Button();
            this.gpGetAllBazFailures.SuspendLayout();
            this.BazFailuresUpdate.SuspendLayout();
            this.gpRequestErrorTable.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetAZ_Mrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetAZ_Deg)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetEL_Mrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetEL_Deg)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSmallStep)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBigStep)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 14);
            this.label9.TabIndex = 20;
            this.label9.Text = "[mrad]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "[mrad]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 14);
            this.label7.TabIndex = 18;
            this.label7.Text = "[deg]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 14);
            this.label6.TabIndex = 17;
            this.label6.Text = "[deg]";
            // 
            // txtDriftStatus
            // 
            this.txtDriftStatus.BackColor = System.Drawing.Color.Black;
            this.txtDriftStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDriftStatus.ForeColor = System.Drawing.Color.Lime;
            this.txtDriftStatus.Location = new System.Drawing.Point(190, 342);
            this.txtDriftStatus.Name = "txtDriftStatus";
            this.txtDriftStatus.ReadOnly = true;
            this.txtDriftStatus.Size = new System.Drawing.Size(140, 22);
            this.txtDriftStatus.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Drift Status";
            // 
            // txtSachiputResetValueJacking
            // 
            this.txtSachiputResetValueJacking.BackColor = System.Drawing.Color.Black;
            this.txtSachiputResetValueJacking.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSachiputResetValueJacking.ForeColor = System.Drawing.Color.Lime;
            this.txtSachiputResetValueJacking.Location = new System.Drawing.Point(190, 313);
            this.txtSachiputResetValueJacking.Name = "txtSachiputResetValueJacking";
            this.txtSachiputResetValueJacking.ReadOnly = true;
            this.txtSachiputResetValueJacking.Size = new System.Drawing.Size(140, 22);
            this.txtSachiputResetValueJacking.TabIndex = 14;
            // 
            // lblSachiputResetValueJacking
            // 
            this.lblSachiputResetValueJacking.AutoSize = true;
            this.lblSachiputResetValueJacking.Location = new System.Drawing.Point(11, 317);
            this.lblSachiputResetValueJacking.Name = "lblSachiputResetValueJacking";
            this.lblSachiputResetValueJacking.Size = new System.Drawing.Size(118, 14);
            this.lblSachiputResetValueJacking.TabIndex = 13;
            this.lblSachiputResetValueJacking.Text = "Drift Reset Elevation";
            this.lblSachiputResetValueJacking.Click += new System.EventHandler(this.lblSachiputResetValueJacking_Click);
            // 
            // txtSachiputResetValueTraverse
            // 
            this.txtSachiputResetValueTraverse.BackColor = System.Drawing.Color.Black;
            this.txtSachiputResetValueTraverse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSachiputResetValueTraverse.ForeColor = System.Drawing.Color.Lime;
            this.txtSachiputResetValueTraverse.Location = new System.Drawing.Point(190, 284);
            this.txtSachiputResetValueTraverse.Name = "txtSachiputResetValueTraverse";
            this.txtSachiputResetValueTraverse.ReadOnly = true;
            this.txtSachiputResetValueTraverse.Size = new System.Drawing.Size(140, 22);
            this.txtSachiputResetValueTraverse.TabIndex = 12;
            // 
            // lblSachiputResetValueTraverse
            // 
            this.lblSachiputResetValueTraverse.AutoSize = true;
            this.lblSachiputResetValueTraverse.Location = new System.Drawing.Point(11, 288);
            this.lblSachiputResetValueTraverse.Name = "lblSachiputResetValueTraverse";
            this.lblSachiputResetValueTraverse.Size = new System.Drawing.Size(113, 14);
            this.lblSachiputResetValueTraverse.TabIndex = 11;
            this.lblSachiputResetValueTraverse.Text = "Drift Reset Azimuth";
            // 
            // txtSolonoidTraverse
            // 
            this.txtSolonoidTraverse.BackColor = System.Drawing.Color.Black;
            this.txtSolonoidTraverse.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSolonoidTraverse.ForeColor = System.Drawing.Color.Lime;
            this.txtSolonoidTraverse.Location = new System.Drawing.Point(190, 255);
            this.txtSolonoidTraverse.Name = "txtSolonoidTraverse";
            this.txtSolonoidTraverse.ReadOnly = true;
            this.txtSolonoidTraverse.Size = new System.Drawing.Size(140, 22);
            this.txtSolonoidTraverse.TabIndex = 10;
            // 
            // lblSolonoidTraverse
            // 
            this.lblSolonoidTraverse.AutoSize = true;
            this.lblSolonoidTraverse.Location = new System.Drawing.Point(11, 259);
            this.lblSolonoidTraverse.Name = "lblSolonoidTraverse";
            this.lblSolonoidTraverse.Size = new System.Drawing.Size(101, 14);
            this.lblSolonoidTraverse.TabIndex = 9;
            this.lblSolonoidTraverse.Text = "Solonoid Azimuth";
            // 
            // txtSolonoidJacking
            // 
            this.txtSolonoidJacking.BackColor = System.Drawing.Color.Black;
            this.txtSolonoidJacking.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSolonoidJacking.ForeColor = System.Drawing.Color.Lime;
            this.txtSolonoidJacking.Location = new System.Drawing.Point(190, 226);
            this.txtSolonoidJacking.Name = "txtSolonoidJacking";
            this.txtSolonoidJacking.ReadOnly = true;
            this.txtSolonoidJacking.Size = new System.Drawing.Size(140, 22);
            this.txtSolonoidJacking.TabIndex = 7;
            // 
            // lblSolonoidJacking
            // 
            this.lblSolonoidJacking.AutoSize = true;
            this.lblSolonoidJacking.Location = new System.Drawing.Point(11, 230);
            this.lblSolonoidJacking.Name = "lblSolonoidJacking";
            this.lblSolonoidJacking.Size = new System.Drawing.Size(106, 14);
            this.lblSolonoidJacking.TabIndex = 6;
            this.lblSolonoidJacking.Text = "Solonoid Elevation";
            // 
            // txtJackingAngleGunnerMirror_Deg
            // 
            this.txtJackingAngleGunnerMirror_Deg.BackColor = System.Drawing.Color.Black;
            this.txtJackingAngleGunnerMirror_Deg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtJackingAngleGunnerMirror_Deg.ForeColor = System.Drawing.Color.Lime;
            this.txtJackingAngleGunnerMirror_Deg.Location = new System.Drawing.Point(190, 158);
            this.txtJackingAngleGunnerMirror_Deg.Name = "txtJackingAngleGunnerMirror_Deg";
            this.txtJackingAngleGunnerMirror_Deg.ReadOnly = true;
            this.txtJackingAngleGunnerMirror_Deg.Size = new System.Drawing.Size(140, 22);
            this.txtJackingAngleGunnerMirror_Deg.TabIndex = 5;
            // 
            // lblJackingAngleGunnerMirror
            // 
            this.lblJackingAngleGunnerMirror.AutoSize = true;
            this.lblJackingAngleGunnerMirror.Location = new System.Drawing.Point(11, 162);
            this.lblJackingAngleGunnerMirror.Name = "lblJackingAngleGunnerMirror";
            this.lblJackingAngleGunnerMirror.Size = new System.Drawing.Size(169, 14);
            this.lblJackingAngleGunnerMirror.TabIndex = 4;
            this.lblJackingAngleGunnerMirror.Text = "Elevation Angle Gunner Mirror";
            // 
            // txtTraverseAngleGunnerMirror_Deg
            // 
            this.txtTraverseAngleGunnerMirror_Deg.BackColor = System.Drawing.Color.Black;
            this.txtTraverseAngleGunnerMirror_Deg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTraverseAngleGunnerMirror_Deg.ForeColor = System.Drawing.Color.Lime;
            this.txtTraverseAngleGunnerMirror_Deg.Location = new System.Drawing.Point(190, 93);
            this.txtTraverseAngleGunnerMirror_Deg.Name = "txtTraverseAngleGunnerMirror_Deg";
            this.txtTraverseAngleGunnerMirror_Deg.ReadOnly = true;
            this.txtTraverseAngleGunnerMirror_Deg.Size = new System.Drawing.Size(140, 22);
            this.txtTraverseAngleGunnerMirror_Deg.TabIndex = 3;
            // 
            // lblTraverseAngleGunnerMirror
            // 
            this.lblTraverseAngleGunnerMirror.AutoSize = true;
            this.lblTraverseAngleGunnerMirror.Location = new System.Drawing.Point(11, 97);
            this.lblTraverseAngleGunnerMirror.Name = "lblTraverseAngleGunnerMirror";
            this.lblTraverseAngleGunnerMirror.Size = new System.Drawing.Size(164, 14);
            this.lblTraverseAngleGunnerMirror.TabIndex = 2;
            this.lblTraverseAngleGunnerMirror.Text = "Azimuth Angle Gunner Mirror";
            // 
            // txtBazMode
            // 
            this.txtBazMode.BackColor = System.Drawing.Color.Black;
            this.txtBazMode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBazMode.ForeColor = System.Drawing.Color.Lime;
            this.txtBazMode.Location = new System.Drawing.Point(190, 48);
            this.txtBazMode.Name = "txtBazMode";
            this.txtBazMode.ReadOnly = true;
            this.txtBazMode.Size = new System.Drawing.Size(140, 22);
            this.txtBazMode.TabIndex = 1;
            // 
            // lblBazMode
            // 
            this.lblBazMode.AutoSize = true;
            this.lblBazMode.Location = new System.Drawing.Point(11, 53);
            this.lblBazMode.Name = "lblBazMode";
            this.lblBazMode.Size = new System.Drawing.Size(81, 14);
            this.lblBazMode.TabIndex = 0;
            this.lblBazMode.Text = "System Mode";
            // 
            // gpGetAllBazFailures
            // 
            this.gpGetAllBazFailures.Controls.Add(this.txtErrorNumber);
            this.gpGetAllBazFailures.Controls.Add(this.lblErrorNumber);
            this.gpGetAllBazFailures.Controls.Add(this.btnGetAllBazFailures);
            this.gpGetAllBazFailures.Controls.Add(this.txtNumberOfFailures);
            this.gpGetAllBazFailures.Controls.Add(this.lblNumberOfFailures);
            this.gpGetAllBazFailures.Location = new System.Drawing.Point(1155, 131);
            this.gpGetAllBazFailures.Name = "gpGetAllBazFailures";
            this.gpGetAllBazFailures.Size = new System.Drawing.Size(266, 122);
            this.gpGetAllBazFailures.TabIndex = 23;
            this.gpGetAllBazFailures.TabStop = false;
            this.gpGetAllBazFailures.Text = "All Baz Failures";
            // 
            // txtErrorNumber
            // 
            this.txtErrorNumber.Location = new System.Drawing.Point(131, 53);
            this.txtErrorNumber.Name = "txtErrorNumber";
            this.txtErrorNumber.ReadOnly = true;
            this.txtErrorNumber.Size = new System.Drawing.Size(116, 22);
            this.txtErrorNumber.TabIndex = 11;
            // 
            // lblErrorNumber
            // 
            this.lblErrorNumber.AutoSize = true;
            this.lblErrorNumber.Location = new System.Drawing.Point(7, 56);
            this.lblErrorNumber.Name = "lblErrorNumber";
            this.lblErrorNumber.Size = new System.Drawing.Size(84, 14);
            this.lblErrorNumber.TabIndex = 10;
            this.lblErrorNumber.Text = "Error Number:";
            // 
            // btnGetAllBazFailures
            // 
            this.btnGetAllBazFailures.Location = new System.Drawing.Point(7, 89);
            this.btnGetAllBazFailures.Name = "btnGetAllBazFailures";
            this.btnGetAllBazFailures.Size = new System.Drawing.Size(240, 25);
            this.btnGetAllBazFailures.TabIndex = 9;
            this.btnGetAllBazFailures.Text = "Get";
            this.btnGetAllBazFailures.UseVisualStyleBackColor = true;
            this.btnGetAllBazFailures.Click += new System.EventHandler(this.btnGetAllBazFailures_Click);
            // 
            // txtNumberOfFailures
            // 
            this.txtNumberOfFailures.Location = new System.Drawing.Point(131, 25);
            this.txtNumberOfFailures.Name = "txtNumberOfFailures";
            this.txtNumberOfFailures.ReadOnly = true;
            this.txtNumberOfFailures.Size = new System.Drawing.Size(116, 22);
            this.txtNumberOfFailures.TabIndex = 1;
            // 
            // lblNumberOfFailures
            // 
            this.lblNumberOfFailures.AutoSize = true;
            this.lblNumberOfFailures.Location = new System.Drawing.Point(7, 28);
            this.lblNumberOfFailures.Name = "lblNumberOfFailures";
            this.lblNumberOfFailures.Size = new System.Drawing.Size(114, 14);
            this.lblNumberOfFailures.TabIndex = 0;
            this.lblNumberOfFailures.Text = "Number Of Failures:";
            // 
            // BazFailuresUpdate
            // 
            this.BazFailuresUpdate.Controls.Add(this.txtStatus);
            this.BazFailuresUpdate.Controls.Add(this.lblStatus);
            this.BazFailuresUpdate.Controls.Add(this.btnGetBazFailuresUpdate);
            this.BazFailuresUpdate.Controls.Add(this.txtFailureNumber);
            this.BazFailuresUpdate.Controls.Add(this.lblFailureNumber);
            this.BazFailuresUpdate.Location = new System.Drawing.Point(1155, 278);
            this.BazFailuresUpdate.Name = "BazFailuresUpdate";
            this.BazFailuresUpdate.Size = new System.Drawing.Size(266, 150);
            this.BazFailuresUpdate.TabIndex = 24;
            this.BazFailuresUpdate.TabStop = false;
            this.BazFailuresUpdate.Text = "Baz Failures Update";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(131, 55);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(116, 22);
            this.txtStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 58);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(46, 14);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // btnGetBazFailuresUpdate
            // 
            this.btnGetBazFailuresUpdate.Location = new System.Drawing.Point(7, 111);
            this.btnGetBazFailuresUpdate.Name = "btnGetBazFailuresUpdate";
            this.btnGetBazFailuresUpdate.Size = new System.Drawing.Size(240, 25);
            this.btnGetBazFailuresUpdate.TabIndex = 9;
            this.btnGetBazFailuresUpdate.Text = "Get";
            this.btnGetBazFailuresUpdate.UseVisualStyleBackColor = true;
            this.btnGetBazFailuresUpdate.Click += new System.EventHandler(this.btnGetBazFailuresUpdate_Click);
            // 
            // txtFailureNumber
            // 
            this.txtFailureNumber.Location = new System.Drawing.Point(131, 27);
            this.txtFailureNumber.Name = "txtFailureNumber";
            this.txtFailureNumber.ReadOnly = true;
            this.txtFailureNumber.Size = new System.Drawing.Size(116, 22);
            this.txtFailureNumber.TabIndex = 1;
            // 
            // lblFailureNumber
            // 
            this.lblFailureNumber.AutoSize = true;
            this.lblFailureNumber.Location = new System.Drawing.Point(7, 30);
            this.lblFailureNumber.Name = "lblFailureNumber";
            this.lblFailureNumber.Size = new System.Drawing.Size(92, 14);
            this.lblFailureNumber.TabIndex = 0;
            this.lblFailureNumber.Text = "Failure Number:";
            // 
            // gpRequestErrorTable
            // 
            this.gpRequestErrorTable.Controls.Add(this.btnRequestErrorTable);
            this.gpRequestErrorTable.Location = new System.Drawing.Point(1073, 471);
            this.gpRequestErrorTable.Name = "gpRequestErrorTable";
            this.gpRequestErrorTable.Size = new System.Drawing.Size(292, 62);
            this.gpRequestErrorTable.TabIndex = 25;
            this.gpRequestErrorTable.TabStop = false;
            this.gpRequestErrorTable.Text = "Request Error Table";
            // 
            // btnRequestErrorTable
            // 
            this.btnRequestErrorTable.Location = new System.Drawing.Point(7, 20);
            this.btnRequestErrorTable.Name = "btnRequestErrorTable";
            this.btnRequestErrorTable.Size = new System.Drawing.Size(278, 25);
            this.btnRequestErrorTable.TabIndex = 9;
            this.btnRequestErrorTable.Text = "Request";
            this.btnRequestErrorTable.UseVisualStyleBackColor = true;
            this.btnRequestErrorTable.Click += new System.EventHandler(this.btnRequestErrorTable_Click);
            // 
            // txtRX
            // 
            this.txtRX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtRX.Location = new System.Drawing.Point(86, 26);
            this.txtRX.Name = "txtRX";
            this.txtRX.Size = new System.Drawing.Size(489, 22);
            this.txtRX.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(16, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "RX (Hex):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(16, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "TX (Hex):";
            // 
            // txtTX
            // 
            this.txtTX.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTX.Location = new System.Drawing.Point(86, 54);
            this.txtTX.Name = "txtTX";
            this.txtTX.Size = new System.Drawing.Size(489, 22);
            this.txtTX.TabIndex = 30;
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.White;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConnect,
            this.tsbDisconnect,
            this.toolStripSeparator1,
            this.btnGyroTest,
            this.toolStripSeparator2,
            this.btnMaintenance,
            this.toolStripSeparator3});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(911, 59);
            this.tsMain.TabIndex = 128;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbConnect
            // 
            this.tsbConnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbConnect.ForeColor = System.Drawing.Color.Black;
            this.tsbConnect.Image = global::YAMABGUI.Properties.Resources.Play1;
            this.tsbConnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConnect.Name = "tsbConnect";
            this.tsbConnect.Size = new System.Drawing.Size(70, 56);
            this.tsbConnect.Text = "Connect";
            this.tsbConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbConnect.Click += new System.EventHandler(this.tsbConnect_Click);
            // 
            // tsbDisconnect
            // 
            this.tsbDisconnect.Enabled = false;
            this.tsbDisconnect.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDisconnect.ForeColor = System.Drawing.Color.Black;
            this.tsbDisconnect.Image = global::YAMABGUI.Properties.Resources.Stop3;
            this.tsbDisconnect.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDisconnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisconnect.Name = "tsbDisconnect";
            this.tsbDisconnect.Size = new System.Drawing.Size(90, 56);
            this.tsbDisconnect.Text = "Disconnect";
            this.tsbDisconnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDisconnect.Click += new System.EventHandler(this.tsbDisconnect_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnGyroTest
            // 
            this.btnGyroTest.BackColor = System.Drawing.Color.Transparent;
            this.btnGyroTest.Enabled = false;
            this.btnGyroTest.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGyroTest.ForeColor = System.Drawing.Color.Black;
            this.btnGyroTest.Image = global::YAMABGUI.Properties.Resources.Download1;
            this.btnGyroTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGyroTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGyroTest.Name = "btnGyroTest";
            this.btnGyroTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnGyroTest.Size = new System.Drawing.Size(103, 56);
            this.btnGyroTest.Text = "Stability Test";
            this.btnGyroTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGyroTest.Click += new System.EventHandler(this.btnGyroTest_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.BackColor = System.Drawing.Color.Transparent;
            this.btnMaintenance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMaintenance.ForeColor = System.Drawing.Color.Black;
            this.btnMaintenance.Image = global::YAMABGUI.Properties.Resources.Settings;
            this.btnMaintenance.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMaintenance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMaintenance.Size = new System.Drawing.Size(70, 56);
            this.btnMaintenance.Text = "Settings";
            this.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 59);
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
            this.lblComm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblComm.Location = new System.Drawing.Point(3, 82);
            this.lblComm.Name = "lblComm";
            this.lblComm.Size = new System.Drawing.Size(905, 45);
            this.lblComm.TabIndex = 128;
            this.lblComm.Text = "FAIL";
            this.lblComm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(389, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = " Sensors Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.txtJackingAngleGunnerMirror_Mrad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTraverseAngleGunnerMirror_Mrad);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblBazMode);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBazMode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTraverseAngleGunnerMirror);
            this.panel1.Controls.Add(this.txtDriftStatus);
            this.panel1.Controls.Add(this.txtTraverseAngleGunnerMirror_Deg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblJackingAngleGunnerMirror);
            this.panel1.Controls.Add(this.txtSachiputResetValueJacking);
            this.panel1.Controls.Add(this.txtJackingAngleGunnerMirror_Deg);
            this.panel1.Controls.Add(this.lblSachiputResetValueJacking);
            this.panel1.Controls.Add(this.lblSolonoidJacking);
            this.panel1.Controls.Add(this.txtSachiputResetValueTraverse);
            this.panel1.Controls.Add(this.txtSolonoidJacking);
            this.panel1.Controls.Add(this.lblSachiputResetValueTraverse);
            this.panel1.Controls.Add(this.lblSolonoidTraverse);
            this.panel1.Controls.Add(this.txtSolonoidTraverse);
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 379);
            this.panel1.TabIndex = 145;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(333, 186);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 14);
            this.label17.TabIndex = 25;
            this.label17.Text = "[mrad]";
            // 
            // txtJackingAngleGunnerMirror_Mrad
            // 
            this.txtJackingAngleGunnerMirror_Mrad.BackColor = System.Drawing.Color.Black;
            this.txtJackingAngleGunnerMirror_Mrad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtJackingAngleGunnerMirror_Mrad.ForeColor = System.Drawing.Color.Lime;
            this.txtJackingAngleGunnerMirror_Mrad.Location = new System.Drawing.Point(190, 182);
            this.txtJackingAngleGunnerMirror_Mrad.Name = "txtJackingAngleGunnerMirror_Mrad";
            this.txtJackingAngleGunnerMirror_Mrad.ReadOnly = true;
            this.txtJackingAngleGunnerMirror_Mrad.Size = new System.Drawing.Size(140, 22);
            this.txtJackingAngleGunnerMirror_Mrad.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "[mrad]";
            // 
            // txtTraverseAngleGunnerMirror_Mrad
            // 
            this.txtTraverseAngleGunnerMirror_Mrad.BackColor = System.Drawing.Color.Black;
            this.txtTraverseAngleGunnerMirror_Mrad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTraverseAngleGunnerMirror_Mrad.ForeColor = System.Drawing.Color.Lime;
            this.txtTraverseAngleGunnerMirror_Mrad.Location = new System.Drawing.Point(190, 117);
            this.txtTraverseAngleGunnerMirror_Mrad.Name = "txtTraverseAngleGunnerMirror_Mrad";
            this.txtTraverseAngleGunnerMirror_Mrad.ReadOnly = true;
            this.txtTraverseAngleGunnerMirror_Mrad.Size = new System.Drawing.Size(140, 22);
            this.txtTraverseAngleGunnerMirror_Mrad.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(410, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 290);
            this.panel2.TabIndex = 146;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button4.Location = new System.Drawing.Point(17, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 47);
            this.button4.TabIndex = 26;
            this.button4.Text = "Gun Slave And Tacho";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(17, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 47);
            this.button3.TabIndex = 25;
            this.button3.Text = "Sight Slave";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(17, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Gun Slave";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(17, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Emergency";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 26);
            this.label10.TabIndex = 22;
            this.label10.Text = "System Modes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnSetAZ_Mrad);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.numSetAZ_Mrad);
            this.panel4.Controls.Add(this.btnSetAZ_Deg);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.numSetAZ_Deg);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(607, 74);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(296, 101);
            this.panel4.TabIndex = 147;
            // 
            // btnSetAZ_Mrad
            // 
            this.btnSetAZ_Mrad.BackColor = System.Drawing.Color.White;
            this.btnSetAZ_Mrad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSetAZ_Mrad.Location = new System.Drawing.Point(13, 70);
            this.btnSetAZ_Mrad.Name = "btnSetAZ_Mrad";
            this.btnSetAZ_Mrad.Size = new System.Drawing.Size(81, 24);
            this.btnSetAZ_Mrad.TabIndex = 29;
            this.btnSetAZ_Mrad.Text = "Set";
            this.btnSetAZ_Mrad.UseVisualStyleBackColor = false;
            this.btnSetAZ_Mrad.Click += new System.EventHandler(this.btnSetAZ_Mrad_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(220, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 14);
            this.label12.TabIndex = 28;
            this.label12.Text = "[mrad]";
            // 
            // numSetAZ_Mrad
            // 
            this.numSetAZ_Mrad.DecimalPlaces = 2;
            this.numSetAZ_Mrad.Location = new System.Drawing.Point(100, 71);
            this.numSetAZ_Mrad.Maximum = new decimal(new int[] {
            384,
            0,
            0,
            0});
            this.numSetAZ_Mrad.Minimum = new decimal(new int[] {
            384,
            0,
            0,
            -2147483648});
            this.numSetAZ_Mrad.Name = "numSetAZ_Mrad";
            this.numSetAZ_Mrad.Size = new System.Drawing.Size(114, 22);
            this.numSetAZ_Mrad.TabIndex = 27;
            this.numSetAZ_Mrad.ValueChanged += new System.EventHandler(this.numSetAZ_Mrad_ValueChanged);
            // 
            // btnSetAZ_Deg
            // 
            this.btnSetAZ_Deg.BackColor = System.Drawing.Color.White;
            this.btnSetAZ_Deg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSetAZ_Deg.Location = new System.Drawing.Point(13, 36);
            this.btnSetAZ_Deg.Name = "btnSetAZ_Deg";
            this.btnSetAZ_Deg.Size = new System.Drawing.Size(81, 24);
            this.btnSetAZ_Deg.TabIndex = 26;
            this.btnSetAZ_Deg.Text = "Set";
            this.btnSetAZ_Deg.UseVisualStyleBackColor = false;
            this.btnSetAZ_Deg.Click += new System.EventHandler(this.btnSetAZ_Deg_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 14);
            this.label13.TabIndex = 25;
            this.label13.Text = "[deg]";
            // 
            // numSetAZ_Deg
            // 
            this.numSetAZ_Deg.DecimalPlaces = 2;
            this.numSetAZ_Deg.Location = new System.Drawing.Point(100, 37);
            this.numSetAZ_Deg.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numSetAZ_Deg.Minimum = new decimal(new int[] {
            22,
            0,
            0,
            -2147483648});
            this.numSetAZ_Deg.Name = "numSetAZ_Deg";
            this.numSetAZ_Deg.Size = new System.Drawing.Size(114, 22);
            this.numSetAZ_Deg.TabIndex = 24;
            this.numSetAZ_Deg.ValueChanged += new System.EventHandler(this.numSetAZ_Deg_ValueChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 26);
            this.label11.TabIndex = 22;
            this.label11.Text = "Azimuth Control";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnSetEL_Mrad);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.numSetEL_Mrad);
            this.panel5.Controls.Add(this.btnSetEL_Deg);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.numSetEL_Deg);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Location = new System.Drawing.Point(607, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 101);
            this.panel5.TabIndex = 148;
            // 
            // btnSetEL_Mrad
            // 
            this.btnSetEL_Mrad.BackColor = System.Drawing.Color.White;
            this.btnSetEL_Mrad.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSetEL_Mrad.Location = new System.Drawing.Point(13, 70);
            this.btnSetEL_Mrad.Name = "btnSetEL_Mrad";
            this.btnSetEL_Mrad.Size = new System.Drawing.Size(81, 24);
            this.btnSetEL_Mrad.TabIndex = 29;
            this.btnSetEL_Mrad.Text = "Set";
            this.btnSetEL_Mrad.UseVisualStyleBackColor = false;
            this.btnSetEL_Mrad.Click += new System.EventHandler(this.btnSetEL_Mrad_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(220, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 14);
            this.label14.TabIndex = 28;
            this.label14.Text = "[mrad]";
            // 
            // numSetEL_Mrad
            // 
            this.numSetEL_Mrad.DecimalPlaces = 2;
            this.numSetEL_Mrad.Location = new System.Drawing.Point(100, 71);
            this.numSetEL_Mrad.Maximum = new decimal(new int[] {
            384,
            0,
            0,
            0});
            this.numSetEL_Mrad.Minimum = new decimal(new int[] {
            384,
            0,
            0,
            -2147483648});
            this.numSetEL_Mrad.Name = "numSetEL_Mrad";
            this.numSetEL_Mrad.Size = new System.Drawing.Size(114, 22);
            this.numSetEL_Mrad.TabIndex = 27;
            this.numSetEL_Mrad.ValueChanged += new System.EventHandler(this.numSetEL_Mrad_ValueChanged);
            // 
            // btnSetEL_Deg
            // 
            this.btnSetEL_Deg.BackColor = System.Drawing.Color.White;
            this.btnSetEL_Deg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSetEL_Deg.Location = new System.Drawing.Point(13, 36);
            this.btnSetEL_Deg.Name = "btnSetEL_Deg";
            this.btnSetEL_Deg.Size = new System.Drawing.Size(81, 24);
            this.btnSetEL_Deg.TabIndex = 26;
            this.btnSetEL_Deg.Text = "Set";
            this.btnSetEL_Deg.UseVisualStyleBackColor = false;
            this.btnSetEL_Deg.Click += new System.EventHandler(this.btnSetEL_Deg_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(220, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 14);
            this.label15.TabIndex = 25;
            this.label15.Text = "[deg]";
            // 
            // numSetEL_Deg
            // 
            this.numSetEL_Deg.DecimalPlaces = 2;
            this.numSetEL_Deg.Location = new System.Drawing.Point(100, 37);
            this.numSetEL_Deg.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numSetEL_Deg.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            -2147483648});
            this.numSetEL_Deg.Name = "numSetEL_Deg";
            this.numSetEL_Deg.Size = new System.Drawing.Size(114, 22);
            this.numSetEL_Deg.TabIndex = 24;
            this.numSetEL_Deg.ValueChanged += new System.EventHandler(this.numSetEL_Deg_ValueChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(294, 26);
            this.label16.TabIndex = 22;
            this.label16.Text = "Elevation Control";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnDrift);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Location = new System.Drawing.Point(607, 302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(296, 63);
            this.panel6.TabIndex = 149;
            // 
            // btnDrift
            // 
            this.btnDrift.BackColor = System.Drawing.Color.White;
            this.btnDrift.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDrift.Location = new System.Drawing.Point(88, 34);
            this.btnDrift.Name = "btnDrift";
            this.btnDrift.Size = new System.Drawing.Size(114, 24);
            this.btnDrift.TabIndex = 26;
            this.btnDrift.Text = "Set Drift Mode";
            this.btnDrift.UseVisualStyleBackColor = false;
            this.btnDrift.Click += new System.EventHandler(this.btnDrift_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(0, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(294, 26);
            this.label19.TabIndex = 22;
            this.label19.Text = "Drift Control";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblComm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTX);
            this.groupBox1.Controls.Add(this.txtRX);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(0, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 130);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Status";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReset.Location = new System.Drawing.Point(306, 112);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 40);
            this.btnReset.TabIndex = 152;
            this.btnReset.Text = "H";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(185, 172);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 14);
            this.label18.TabIndex = 161;
            this.label18.Text = "[mrad]";
            // 
            // numSmallStep
            // 
            this.numSmallStep.DecimalPlaces = 2;
            this.numSmallStep.Location = new System.Drawing.Point(111, 169);
            this.numSmallStep.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSmallStep.Name = "numSmallStep";
            this.numSmallStep.Size = new System.Drawing.Size(68, 22);
            this.numSmallStep.TabIndex = 160;
            this.numSmallStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSmallStep.ValueChanged += new System.EventHandler(this.numSmallStep_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(16, 172);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 14);
            this.label20.TabIndex = 162;
            this.label20.Text = "Small Step Size";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.numBigStep);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnUp_bigStep);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btnLeft_smallStep);
            this.panel3.Controls.Add(this.numSmallStep);
            this.panel3.Controls.Add(this.btnDown_bigStep);
            this.panel3.Controls.Add(this.btnRight_smallStep);
            this.panel3.Controls.Add(this.btnLeft_bigStep);
            this.panel3.Controls.Add(this.btnDown_smallStep);
            this.panel3.Controls.Add(this.btnUp_smallStep);
            this.panel3.Controls.Add(this.btnRight_bigStep);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Location = new System.Drawing.Point(410, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(493, 244);
            this.panel3.TabIndex = 163;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(16, 203);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 14);
            this.label22.TabIndex = 165;
            this.label22.Text = "Big Step Size";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(185, 203);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 14);
            this.label23.TabIndex = 164;
            this.label23.Text = "[mrad]";
            // 
            // numBigStep
            // 
            this.numBigStep.DecimalPlaces = 2;
            this.numBigStep.Location = new System.Drawing.Point(111, 200);
            this.numBigStep.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBigStep.Name = "numBigStep";
            this.numBigStep.Size = new System.Drawing.Size(68, 22);
            this.numBigStep.TabIndex = 163;
            this.numBigStep.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numBigStep.ValueChanged += new System.EventHandler(this.numBigStep_ValueChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label21.ForeColor = System.Drawing.Color.Blue;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(491, 26);
            this.label21.TabIndex = 22;
            this.label21.Text = "Az/EL Adjusments";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUp_bigStep
            // 
            this.btnUp_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnUp_bigStep.Image")));
            this.btnUp_bigStep.Location = new System.Drawing.Point(306, 34);
            this.btnUp_bigStep.Name = "btnUp_bigStep";
            this.btnUp_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnUp_bigStep.TabIndex = 156;
            this.btnUp_bigStep.UseVisualStyleBackColor = true;
            this.btnUp_bigStep.Click += new System.EventHandler(this.btnUp_bigStep_Click);
            // 
            // btnLeft_smallStep
            // 
            this.btnLeft_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft_smallStep.Image")));
            this.btnLeft_smallStep.Location = new System.Drawing.Point(247, 112);
            this.btnLeft_smallStep.Name = "btnLeft_smallStep";
            this.btnLeft_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnLeft_smallStep.TabIndex = 155;
            this.btnLeft_smallStep.UseVisualStyleBackColor = true;
            this.btnLeft_smallStep.Click += new System.EventHandler(this.btnLeft_smallStep_Click);
            // 
            // btnDown_bigStep
            // 
            this.btnDown_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDown_bigStep.Image")));
            this.btnDown_bigStep.Location = new System.Drawing.Point(306, 190);
            this.btnDown_bigStep.Name = "btnDown_bigStep";
            this.btnDown_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnDown_bigStep.TabIndex = 157;
            this.btnDown_bigStep.UseVisualStyleBackColor = true;
            this.btnDown_bigStep.Click += new System.EventHandler(this.btnDown_bigStep_Click);
            // 
            // btnRight_smallStep
            // 
            this.btnRight_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnRight_smallStep.Image")));
            this.btnRight_smallStep.Location = new System.Drawing.Point(365, 112);
            this.btnRight_smallStep.Name = "btnRight_smallStep";
            this.btnRight_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnRight_smallStep.TabIndex = 154;
            this.btnRight_smallStep.UseVisualStyleBackColor = true;
            this.btnRight_smallStep.Click += new System.EventHandler(this.btnRight_smallStep_Click);
            // 
            // btnLeft_bigStep
            // 
            this.btnLeft_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft_bigStep.Image")));
            this.btnLeft_bigStep.Location = new System.Drawing.Point(188, 112);
            this.btnLeft_bigStep.Name = "btnLeft_bigStep";
            this.btnLeft_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnLeft_bigStep.TabIndex = 159;
            this.btnLeft_bigStep.UseVisualStyleBackColor = true;
            this.btnLeft_bigStep.Click += new System.EventHandler(this.btnLeft_bigStep_Click);
            // 
            // btnDown_smallStep
            // 
            this.btnDown_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnDown_smallStep.Image")));
            this.btnDown_smallStep.Location = new System.Drawing.Point(306, 151);
            this.btnDown_smallStep.Name = "btnDown_smallStep";
            this.btnDown_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnDown_smallStep.TabIndex = 153;
            this.btnDown_smallStep.UseVisualStyleBackColor = true;
            this.btnDown_smallStep.Click += new System.EventHandler(this.btnDown_smallStep_Click);
            // 
            // btnUp_smallStep
            // 
            this.btnUp_smallStep.Image = ((System.Drawing.Image)(resources.GetObject("btnUp_smallStep.Image")));
            this.btnUp_smallStep.Location = new System.Drawing.Point(306, 73);
            this.btnUp_smallStep.Name = "btnUp_smallStep";
            this.btnUp_smallStep.Size = new System.Drawing.Size(60, 40);
            this.btnUp_smallStep.TabIndex = 151;
            this.btnUp_smallStep.UseVisualStyleBackColor = true;
            this.btnUp_smallStep.Click += new System.EventHandler(this.btnUp_smallStep_Click);
            // 
            // btnRight_bigStep
            // 
            this.btnRight_bigStep.Image = ((System.Drawing.Image)(resources.GetObject("btnRight_bigStep.Image")));
            this.btnRight_bigStep.Location = new System.Drawing.Point(424, 112);
            this.btnRight_bigStep.Name = "btnRight_bigStep";
            this.btnRight_bigStep.Size = new System.Drawing.Size(60, 40);
            this.btnRight_bigStep.TabIndex = 158;
            this.btnRight_bigStep.UseVisualStyleBackColor = true;
            this.btnRight_bigStep.Click += new System.EventHandler(this.btnRight_bigStep_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 744);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.gpRequestErrorTable);
            this.Controls.Add(this.BazFailuresUpdate);
            this.Controls.Add(this.gpGetAllBazFailures);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "YAMAB GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpGetAllBazFailures.ResumeLayout(false);
            this.gpGetAllBazFailures.PerformLayout();
            this.BazFailuresUpdate.ResumeLayout(false);
            this.BazFailuresUpdate.PerformLayout();
            this.gpRequestErrorTable.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetAZ_Mrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetAZ_Deg)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSetEL_Mrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSetEL_Deg)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSmallStep)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBigStep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSolonoidJacking;
        private System.Windows.Forms.Label lblSolonoidJacking;
        private System.Windows.Forms.TextBox txtJackingAngleGunnerMirror_Deg;
        private System.Windows.Forms.Label lblJackingAngleGunnerMirror;
        private System.Windows.Forms.TextBox txtTraverseAngleGunnerMirror_Deg;
        private System.Windows.Forms.Label lblTraverseAngleGunnerMirror;
        private System.Windows.Forms.TextBox txtBazMode;
        private System.Windows.Forms.Label lblBazMode;
        private System.Windows.Forms.TextBox txtSachiputResetValueJacking;
        private System.Windows.Forms.Label lblSachiputResetValueJacking;
        private System.Windows.Forms.TextBox txtSachiputResetValueTraverse;
        private System.Windows.Forms.Label lblSachiputResetValueTraverse;
        private System.Windows.Forms.TextBox txtSolonoidTraverse;
        private System.Windows.Forms.Label lblSolonoidTraverse;
        private System.Windows.Forms.GroupBox gpGetAllBazFailures;
        private System.Windows.Forms.Button btnGetAllBazFailures;
        private System.Windows.Forms.TextBox txtNumberOfFailures;
        private System.Windows.Forms.Label lblNumberOfFailures;
        private System.Windows.Forms.TextBox txtErrorNumber;
        private System.Windows.Forms.Label lblErrorNumber;
        private System.Windows.Forms.GroupBox BazFailuresUpdate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnGetBazFailuresUpdate;
        private System.Windows.Forms.TextBox txtFailureNumber;
        private System.Windows.Forms.Label lblFailureNumber;
        private System.Windows.Forms.GroupBox gpRequestErrorTable;
        private System.Windows.Forms.Button btnRequestErrorTable;
        private System.Windows.Forms.TextBox txtDriftStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbConnect;
        private System.Windows.Forms.ToolStripButton tsbDisconnect;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnMaintenance;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.ComponentModel.BackgroundWorker bgwRead;
        private System.Windows.Forms.Label lblComm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numSetAZ_Deg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSetAZ_Deg;
        private System.Windows.Forms.Button btnSetAZ_Mrad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numSetAZ_Mrad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSetEL_Mrad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numSetEL_Mrad;
        private System.Windows.Forms.Button btnSetEL_Deg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numSetEL_Deg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnDrift;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTraverseAngleGunnerMirror_Mrad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtJackingAngleGunnerMirror_Mrad;
        private System.Windows.Forms.Button btnUp_bigStep;
        private System.Windows.Forms.Button btnLeft_bigStep;
        private System.Windows.Forms.Button btnUp_smallStep;
        private System.Windows.Forms.Button btnRight_bigStep;
        private System.Windows.Forms.Button btnDown_smallStep;
        private System.Windows.Forms.Button btnRight_smallStep;
        private System.Windows.Forms.Button btnDown_bigStep;
        private System.Windows.Forms.Button btnLeft_smallStep;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numSmallStep;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numBigStep;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolStripButton btnGyroTest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

