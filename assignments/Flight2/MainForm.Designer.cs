namespace Flight2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.heightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.angleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.weightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.launchButton = new System.Windows.Forms.Button();
            this.labDistance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(12, 164);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(651, 452);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Angle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Speed";
            // 
            // heightNumericUpDown
            // 
            this.heightNumericUpDown.Location = new System.Drawing.Point(58, 13);
            this.heightNumericUpDown.Name = "heightNumericUpDown";
            this.heightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.heightNumericUpDown.TabIndex = 4;
            // 
            // angleNumericUpDown
            // 
            this.angleNumericUpDown.Location = new System.Drawing.Point(58, 54);
            this.angleNumericUpDown.Name = "angleNumericUpDown";
            this.angleNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.angleNumericUpDown.TabIndex = 5;
            this.angleNumericUpDown.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Location = new System.Drawing.Point(58, 99);
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.speedNumericUpDown.TabIndex = 6;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size";
            // 
            // weightNumericUpDown
            // 
            this.weightNumericUpDown.Location = new System.Drawing.Point(234, 54);
            this.weightNumericUpDown.Name = "weightNumericUpDown";
            this.weightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.weightNumericUpDown.TabIndex = 8;
            this.weightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Weight";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.DecimalPlaces = 2;
            this.sizeNumericUpDown.Location = new System.Drawing.Point(234, 14);
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sizeNumericUpDown.TabIndex = 10;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(234, 99);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(75, 23);
            this.launchButton.TabIndex = 11;
            this.launchButton.Text = "Launch";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // labDistance
            // 
            this.labDistance.AutoSize = true;
            this.labDistance.Location = new System.Drawing.Point(319, 104);
            this.labDistance.Name = "labDistance";
            this.labDistance.Size = new System.Drawing.Size(61, 13);
            this.labDistance.TabIndex = 12;
            this.labDistance.Text = "Distance: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 628);
            this.Controls.Add(this.labDistance);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weightNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.angleNumericUpDown);
            this.Controls.Add(this.heightNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "MainForm";
            this.Text = "Flight (With atmosphere)";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown heightNumericUpDown;
        private System.Windows.Forms.NumericUpDown angleNumericUpDown;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown weightNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label labDistance;
    }
}

