namespace YAMABGUI
{
    partial class FrmSettings
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
            this.txtYAMAB_IP = new System.Windows.Forms.TextBox();
            this.lblYAMBA_IP_Caption = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestResultsMainFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFTPUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFTPPassord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFTPFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numAZ_Stability_AVG_Min = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numAZ_Stability_STD_Min = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numAZ_Stability_STD_Max = new System.Windows.Forms.NumericUpDown();
            this.numAZ_Stability_AVG_Max = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numEL_Stability_STD_Max = new System.Windows.Forms.NumericUpDown();
            this.numEL_Stability_AVG_Min = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.numEL_Stability_AVG_Max = new System.Windows.Forms.NumericUpDown();
            this.numEL_Stability_STD_Min = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlBottom.SuspendLayout();
            this.pnlOKCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_AVG_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_STD_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_STD_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_AVG_Max)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_STD_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_AVG_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_AVG_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_STD_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Location = new System.Drawing.Point(0, 564);
            this.pnlBottom.Size = new System.Drawing.Size(510, 38);
            // 
            // pnlOKCancel
            // 
            this.pnlOKCancel.Location = new System.Drawing.Point(329, 0);
            // 
            // txtYAMAB_IP
            // 
            this.txtYAMAB_IP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtYAMAB_IP.Location = new System.Drawing.Point(106, 12);
            this.txtYAMAB_IP.Name = "txtYAMAB_IP";
            this.txtYAMAB_IP.Size = new System.Drawing.Size(120, 23);
            this.txtYAMAB_IP.TabIndex = 25;
            // 
            // lblYAMBA_IP_Caption
            // 
            this.lblYAMBA_IP_Caption.AutoSize = true;
            this.lblYAMBA_IP_Caption.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblYAMBA_IP_Caption.Location = new System.Drawing.Point(9, 15);
            this.lblYAMBA_IP_Caption.Name = "lblYAMBA_IP_Caption";
            this.lblYAMBA_IP_Caption.Size = new System.Drawing.Size(63, 16);
            this.lblYAMBA_IP_Caption.TabIndex = 24;
            this.lblYAMBA_IP_Caption.Text = "YAMAB IP";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(106, 43);
            this.numPort.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(120, 21);
            this.numPort.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "YAMAB Port";
            // 
            // txtTestResultsMainFolder
            // 
            this.txtTestResultsMainFolder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtTestResultsMainFolder.Location = new System.Drawing.Point(107, 176);
            this.txtTestResultsMainFolder.Name = "txtTestResultsMainFolder";
            this.txtTestResultsMainFolder.Size = new System.Drawing.Size(378, 23);
            this.txtTestResultsMainFolder.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(10, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Results Folder";
            // 
            // txtFTPUserID
            // 
            this.txtFTPUserID.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFTPUserID.Location = new System.Drawing.Point(106, 72);
            this.txtFTPUserID.Name = "txtFTPUserID";
            this.txtFTPUserID.Size = new System.Drawing.Size(120, 23);
            this.txtFTPUserID.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "FTP User ID";
            // 
            // txtFTPPassord
            // 
            this.txtFTPPassord.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFTPPassord.Location = new System.Drawing.Point(106, 103);
            this.txtFTPPassord.Name = "txtFTPPassord";
            this.txtFTPPassord.Size = new System.Drawing.Size(120, 23);
            this.txtFTPPassord.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(9, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "FTP Password";
            // 
            // txtFTPFolder
            // 
            this.txtFTPFolder.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtFTPFolder.Location = new System.Drawing.Point(106, 134);
            this.txtFTPFolder.Name = "txtFTPFolder";
            this.txtFTPFolder.Size = new System.Drawing.Size(120, 23);
            this.txtFTPFolder.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "FTP Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(8, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 336);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stability Test Criteria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(12, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Average";
            // 
            // numAZ_Stability_AVG_Min
            // 
            this.numAZ_Stability_AVG_Min.DecimalPlaces = 9;
            this.numAZ_Stability_AVG_Min.Location = new System.Drawing.Point(86, 53);
            this.numAZ_Stability_AVG_Min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAZ_Stability_AVG_Min.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numAZ_Stability_AVG_Min.Name = "numAZ_Stability_AVG_Min";
            this.numAZ_Stability_AVG_Min.Size = new System.Drawing.Size(153, 23);
            this.numAZ_Stability_AVG_Min.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.Location = new System.Drawing.Point(12, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "STD";
            // 
            // numAZ_Stability_STD_Min
            // 
            this.numAZ_Stability_STD_Min.DecimalPlaces = 9;
            this.numAZ_Stability_STD_Min.Location = new System.Drawing.Point(86, 91);
            this.numAZ_Stability_STD_Min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAZ_Stability_STD_Min.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numAZ_Stability_STD_Min.Name = "numAZ_Stability_STD_Min";
            this.numAZ_Stability_STD_Min.Size = new System.Drawing.Size(153, 23);
            this.numAZ_Stability_STD_Min.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(294, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Max";
            // 
            // numAZ_Stability_STD_Max
            // 
            this.numAZ_Stability_STD_Max.DecimalPlaces = 9;
            this.numAZ_Stability_STD_Max.Location = new System.Drawing.Point(259, 91);
            this.numAZ_Stability_STD_Max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAZ_Stability_STD_Max.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numAZ_Stability_STD_Max.Name = "numAZ_Stability_STD_Max";
            this.numAZ_Stability_STD_Max.Size = new System.Drawing.Size(153, 23);
            this.numAZ_Stability_STD_Max.TabIndex = 34;
            // 
            // numAZ_Stability_AVG_Max
            // 
            this.numAZ_Stability_AVG_Max.DecimalPlaces = 9;
            this.numAZ_Stability_AVG_Max.Location = new System.Drawing.Point(259, 53);
            this.numAZ_Stability_AVG_Max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAZ_Stability_AVG_Max.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numAZ_Stability_AVG_Max.Name = "numAZ_Stability_AVG_Max";
            this.numAZ_Stability_AVG_Max.Size = new System.Drawing.Size(153, 23);
            this.numAZ_Stability_AVG_Max.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.numAZ_Stability_STD_Max);
            this.groupBox2.Controls.Add(this.numAZ_Stability_AVG_Min);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numAZ_Stability_AVG_Max);
            this.groupBox2.Controls.Add(this.numAZ_Stability_STD_Min);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(25, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 136);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Azimuth";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(126, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 36;
            this.label10.Text = "Min";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.numEL_Stability_STD_Max);
            this.groupBox3.Controls.Add(this.numEL_Stability_AVG_Min);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.numEL_Stability_AVG_Max);
            this.groupBox3.Controls.Add(this.numEL_Stability_STD_Min);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox3.Location = new System.Drawing.Point(25, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 136);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elevation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.Location = new System.Drawing.Point(126, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(294, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Max";
            // 
            // numEL_Stability_STD_Max
            // 
            this.numEL_Stability_STD_Max.DecimalPlaces = 9;
            this.numEL_Stability_STD_Max.Location = new System.Drawing.Point(259, 91);
            this.numEL_Stability_STD_Max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEL_Stability_STD_Max.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numEL_Stability_STD_Max.Name = "numEL_Stability_STD_Max";
            this.numEL_Stability_STD_Max.Size = new System.Drawing.Size(153, 23);
            this.numEL_Stability_STD_Max.TabIndex = 34;
            // 
            // numEL_Stability_AVG_Min
            // 
            this.numEL_Stability_AVG_Min.DecimalPlaces = 9;
            this.numEL_Stability_AVG_Min.Location = new System.Drawing.Point(86, 53);
            this.numEL_Stability_AVG_Min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEL_Stability_AVG_Min.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numEL_Stability_AVG_Min.Name = "numEL_Stability_AVG_Min";
            this.numEL_Stability_AVG_Min.Size = new System.Drawing.Size(153, 23);
            this.numEL_Stability_AVG_Min.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.Location = new System.Drawing.Point(12, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "Average";
            // 
            // numEL_Stability_AVG_Max
            // 
            this.numEL_Stability_AVG_Max.DecimalPlaces = 9;
            this.numEL_Stability_AVG_Max.Location = new System.Drawing.Point(259, 53);
            this.numEL_Stability_AVG_Max.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEL_Stability_AVG_Max.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numEL_Stability_AVG_Max.Name = "numEL_Stability_AVG_Max";
            this.numEL_Stability_AVG_Max.Size = new System.Drawing.Size(153, 23);
            this.numEL_Stability_AVG_Max.TabIndex = 33;
            // 
            // numEL_Stability_STD_Min
            // 
            this.numEL_Stability_STD_Min.DecimalPlaces = 9;
            this.numEL_Stability_STD_Min.Location = new System.Drawing.Point(86, 91);
            this.numEL_Stability_STD_Min.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numEL_Stability_STD_Min.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numEL_Stability_STD_Min.Name = "numEL_Stability_STD_Min";
            this.numEL_Stability_STD_Min.Size = new System.Drawing.Size(153, 23);
            this.numEL_Stability_STD_Min.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.Location = new System.Drawing.Point(12, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 16);
            this.label14.TabIndex = 31;
            this.label14.Text = "STD";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 602);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtFTPFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFTPPassord);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFTPUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTestResultsMainFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.txtYAMAB_IP);
            this.Controls.Add(this.lblYAMBA_IP_Caption);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSettings";
            this.OkCancelVisible = true;
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.Controls.SetChildIndex(this.pnlBottom, 0);
            this.Controls.SetChildIndex(this.lblYAMBA_IP_Caption, 0);
            this.Controls.SetChildIndex(this.txtYAMAB_IP, 0);
            this.Controls.SetChildIndex(this.numPort, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtTestResultsMainFolder, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtFTPUserID, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtFTPPassord, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtFTPFolder, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlOKCancel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_AVG_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_STD_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_STD_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAZ_Stability_AVG_Max)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_STD_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_AVG_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_AVG_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEL_Stability_STD_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYAMAB_IP;
        private System.Windows.Forms.Label lblYAMBA_IP_Caption;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestResultsMainFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFTPUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFTPPassord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFTPFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numAZ_Stability_AVG_Min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numAZ_Stability_STD_Min;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numAZ_Stability_STD_Max;
        private System.Windows.Forms.NumericUpDown numAZ_Stability_AVG_Max;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numEL_Stability_STD_Max;
        private System.Windows.Forms.NumericUpDown numEL_Stability_AVG_Min;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numEL_Stability_AVG_Max;
        private System.Windows.Forms.NumericUpDown numEL_Stability_STD_Min;
        private System.Windows.Forms.Label label14;
    }
}