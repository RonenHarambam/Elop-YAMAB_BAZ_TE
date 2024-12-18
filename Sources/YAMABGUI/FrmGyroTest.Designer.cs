namespace YAMABGUI
{
    partial class FrmGyroTest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartAzimuth = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAZ_avg = new System.Windows.Forms.Label();
            this.lblEL_avg = new System.Windows.Forms.Label();
            this.lblAZ_STD = new System.Windows.Forms.Label();
            this.lblEL_STD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAzimuth = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.chartElevation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlElevation = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlGraphs = new System.Windows.Forms.Panel();
            this.spGraphs = new System.Windows.Forms.SplitContainer();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.lblProggress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ChartAzimuth)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlAzimuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartElevation)).BeginInit();
            this.pnlElevation.SuspendLayout();
            this.pnlGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spGraphs)).BeginInit();
            this.spGraphs.Panel1.SuspendLayout();
            this.spGraphs.Panel2.SuspendLayout();
            this.spGraphs.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartAzimuth
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartAzimuth.ChartAreas.Add(chartArea1);
            this.ChartAzimuth.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartAzimuth.Legends.Add(legend1);
            this.ChartAzimuth.Location = new System.Drawing.Point(0, 26);
            this.ChartAzimuth.Name = "ChartAzimuth";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Azimuth";
            this.ChartAzimuth.Series.Add(series1);
            this.ChartAzimuth.Size = new System.Drawing.Size(1113, 186);
            this.ChartAzimuth.TabIndex = 0;
            this.ChartAzimuth.Text = "chart1";
            // 
            // btnStartTest
            // 
            this.btnStartTest.BackColor = System.Drawing.Color.Blue;
            this.btnStartTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartTest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnStartTest.ForeColor = System.Drawing.Color.White;
            this.btnStartTest.Location = new System.Drawing.Point(0, 0);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(1113, 43);
            this.btnStartTest.TabIndex = 24;
            this.btnStartTest.Text = "Start Test";
            this.btnStartTest.UseVisualStyleBackColor = false;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAZ_avg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEL_avg, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAZ_STD, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEL_STD, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 282);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(744, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 96);
            this.label2.TabIndex = 3;
            this.label2.Text = "Elevation (mRad)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(4, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 96);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(4, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 86);
            this.label4.TabIndex = 5;
            this.label4.Text = "STD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 44);
            this.button1.TabIndex = 26;
            this.button1.Text = "DEbug";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAZ_avg
            // 
            this.lblAZ_avg.AutoSize = true;
            this.lblAZ_avg.BackColor = System.Drawing.Color.White;
            this.lblAZ_avg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAZ_avg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAZ_avg.Location = new System.Drawing.Point(374, 98);
            this.lblAZ_avg.Name = "lblAZ_avg";
            this.lblAZ_avg.Size = new System.Drawing.Size(363, 96);
            this.lblAZ_avg.TabIndex = 6;
            this.lblAZ_avg.Text = "NA";
            this.lblAZ_avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEL_avg
            // 
            this.lblEL_avg.AutoSize = true;
            this.lblEL_avg.BackColor = System.Drawing.Color.White;
            this.lblEL_avg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEL_avg.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEL_avg.Location = new System.Drawing.Point(744, 98);
            this.lblEL_avg.Name = "lblEL_avg";
            this.lblEL_avg.Size = new System.Drawing.Size(365, 96);
            this.lblEL_avg.TabIndex = 7;
            this.lblEL_avg.Text = "NA";
            this.lblEL_avg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAZ_STD
            // 
            this.lblAZ_STD.AutoSize = true;
            this.lblAZ_STD.BackColor = System.Drawing.Color.White;
            this.lblAZ_STD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAZ_STD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblAZ_STD.Location = new System.Drawing.Point(374, 195);
            this.lblAZ_STD.Name = "lblAZ_STD";
            this.lblAZ_STD.Size = new System.Drawing.Size(363, 86);
            this.lblAZ_STD.TabIndex = 8;
            this.lblAZ_STD.Text = "NA";
            this.lblAZ_STD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEL_STD
            // 
            this.lblEL_STD.AutoSize = true;
            this.lblEL_STD.BackColor = System.Drawing.Color.White;
            this.lblEL_STD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEL_STD.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEL_STD.Location = new System.Drawing.Point(744, 195);
            this.lblEL_STD.Name = "lblEL_STD";
            this.lblEL_STD.Size = new System.Drawing.Size(365, 86);
            this.lblEL_STD.TabIndex = 9;
            this.lblEL_STD.Text = "NA";
            this.lblEL_STD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(374, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 96);
            this.label1.TabIndex = 2;
            this.label1.Text = "Azimuth (mRad)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAzimuth
            // 
            this.pnlAzimuth.Controls.Add(this.ChartAzimuth);
            this.pnlAzimuth.Controls.Add(this.label11);
            this.pnlAzimuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAzimuth.Location = new System.Drawing.Point(0, 0);
            this.pnlAzimuth.Name = "pnlAzimuth";
            this.pnlAzimuth.Size = new System.Drawing.Size(1113, 212);
            this.pnlAzimuth.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1113, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "Azimuth";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartElevation
            // 
            chartArea2.Name = "ChartArea1";
            this.chartElevation.ChartAreas.Add(chartArea2);
            this.chartElevation.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartElevation.Legends.Add(legend2);
            this.chartElevation.Location = new System.Drawing.Point(0, 26);
            this.chartElevation.Name = "chartElevation";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Elevation";
            this.chartElevation.Series.Add(series2);
            this.chartElevation.Size = new System.Drawing.Size(1113, 188);
            this.chartElevation.TabIndex = 1;
            this.chartElevation.Text = "chart1";
            // 
            // pnlElevation
            // 
            this.pnlElevation.Controls.Add(this.chartElevation);
            this.pnlElevation.Controls.Add(this.label5);
            this.pnlElevation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlElevation.Location = new System.Drawing.Point(0, 0);
            this.pnlElevation.Name = "pnlElevation";
            this.pnlElevation.Size = new System.Drawing.Size(1113, 214);
            this.pnlElevation.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1113, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "Elevation";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGraphs
            // 
            this.pnlGraphs.Controls.Add(this.spGraphs);
            this.pnlGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraphs.Location = new System.Drawing.Point(0, 368);
            this.pnlGraphs.Name = "pnlGraphs";
            this.pnlGraphs.Size = new System.Drawing.Size(1113, 430);
            this.pnlGraphs.TabIndex = 29;
            // 
            // spGraphs
            // 
            this.spGraphs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spGraphs.Location = new System.Drawing.Point(0, 0);
            this.spGraphs.Name = "spGraphs";
            this.spGraphs.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spGraphs.Panel1
            // 
            this.spGraphs.Panel1.Controls.Add(this.pnlElevation);
            // 
            // spGraphs.Panel2
            // 
            this.spGraphs.Panel2.Controls.Add(this.pnlAzimuth);
            this.spGraphs.Size = new System.Drawing.Size(1113, 430);
            this.spGraphs.SplitterDistance = 214;
            this.spGraphs.TabIndex = 29;
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.lblProggress);
            this.pnlResults.Controls.Add(this.btnStartTest);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlResults.Location = new System.Drawing.Point(0, 282);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(1113, 86);
            this.pnlResults.TabIndex = 30;
            // 
            // lblProggress
            // 
            this.lblProggress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblProggress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProggress.Location = new System.Drawing.Point(0, 43);
            this.lblProggress.Name = "lblProggress";
            this.lblProggress.Size = new System.Drawing.Size(1113, 43);
            this.lblProggress.TabIndex = 0;
            this.lblProggress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pnlResults);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 368);
            this.panel1.TabIndex = 31;
            // 
            // bgw
            // 
            this.bgw.WorkerReportsProgress = true;
            this.bgw.WorkerSupportsCancellation = true;
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_DoWork);
            this.bgw.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_ProgressChanged);
            this.bgw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_RunWorkerCompleted);
            // 
            // FrmGyroTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 798);
            this.Controls.Add(this.pnlGraphs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "FrmGyroTest";
            this.Text = "Stability Test";
            this.Load += new System.EventHandler(this.FrmGyroTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartAzimuth)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlAzimuth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartElevation)).EndInit();
            this.pnlElevation.ResumeLayout(false);
            this.pnlGraphs.ResumeLayout(false);
            this.spGraphs.Panel1.ResumeLayout(false);
            this.spGraphs.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spGraphs)).EndInit();
            this.spGraphs.ResumeLayout(false);
            this.pnlResults.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartAzimuth;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAZ_avg;
        private System.Windows.Forms.Label lblEL_avg;
        private System.Windows.Forms.Label lblAZ_STD;
        private System.Windows.Forms.Label lblEL_STD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlAzimuth;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartElevation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlElevation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlGraphs;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProggress;
        private System.Windows.Forms.SplitContainer spGraphs;
        private System.ComponentModel.BackgroundWorker bgw;
    }
}