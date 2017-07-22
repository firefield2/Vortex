namespace Vortex
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperature1CheckBox = new System.Windows.Forms.CheckBox();
            this.temperature2CheckBox = new System.Windows.Forms.CheckBox();
            this.temperature3CheckBox = new System.Windows.Forms.CheckBox();
            this.temperature4CheckBox = new System.Windows.Forms.CheckBox();
            this.temperature = new System.Windows.Forms.GroupBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minTimePicker = new System.Windows.Forms.DateTimePicker();
            this.minLabel = new System.Windows.Forms.Label();
            this.minMaxCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.temperature.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.LabelStyle.Format = "HH:mm";
            chartArea1.AxisX.Title = "Godzina";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.Title = "Temperatura [°C]";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart.Location = new System.Drawing.Point(12, 12);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chart.Size = new System.Drawing.Size(423, 334);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // temperature1CheckBox
            // 
            this.temperature1CheckBox.AutoSize = true;
            this.temperature1CheckBox.BackColor = System.Drawing.Color.DarkBlue;
            this.temperature1CheckBox.Checked = true;
            this.temperature1CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temperature1CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperature1CheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperature1CheckBox.Location = new System.Drawing.Point(6, 19);
            this.temperature1CheckBox.Name = "temperature1CheckBox";
            this.temperature1CheckBox.Size = new System.Drawing.Size(121, 21);
            this.temperature1CheckBox.TabIndex = 1;
            this.temperature1CheckBox.Text = "Temperatura 1";
            this.temperature1CheckBox.UseVisualStyleBackColor = false;
            this.temperature1CheckBox.CheckedChanged += new System.EventHandler(this.Form2_Load);
            // 
            // temperature2CheckBox
            // 
            this.temperature2CheckBox.AutoSize = true;
            this.temperature2CheckBox.BackColor = System.Drawing.Color.DarkGreen;
            this.temperature2CheckBox.Checked = true;
            this.temperature2CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temperature2CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperature2CheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperature2CheckBox.Location = new System.Drawing.Point(6, 42);
            this.temperature2CheckBox.Name = "temperature2CheckBox";
            this.temperature2CheckBox.Size = new System.Drawing.Size(121, 21);
            this.temperature2CheckBox.TabIndex = 2;
            this.temperature2CheckBox.Text = "Temperatura 2";
            this.temperature2CheckBox.UseVisualStyleBackColor = false;
            this.temperature2CheckBox.CheckedChanged += new System.EventHandler(this.Form2_Load);
            // 
            // temperature3CheckBox
            // 
            this.temperature3CheckBox.AutoSize = true;
            this.temperature3CheckBox.BackColor = System.Drawing.Color.Red;
            this.temperature3CheckBox.Checked = true;
            this.temperature3CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temperature3CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperature3CheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperature3CheckBox.Location = new System.Drawing.Point(6, 65);
            this.temperature3CheckBox.Name = "temperature3CheckBox";
            this.temperature3CheckBox.Size = new System.Drawing.Size(121, 21);
            this.temperature3CheckBox.TabIndex = 3;
            this.temperature3CheckBox.Text = "Temperatura 3";
            this.temperature3CheckBox.UseVisualStyleBackColor = false;
            this.temperature3CheckBox.CheckedChanged += new System.EventHandler(this.Form2_Load);
            // 
            // temperature4CheckBox
            // 
            this.temperature4CheckBox.AutoSize = true;
            this.temperature4CheckBox.BackColor = System.Drawing.Color.Purple;
            this.temperature4CheckBox.Checked = true;
            this.temperature4CheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.temperature4CheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.temperature4CheckBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.temperature4CheckBox.Location = new System.Drawing.Point(6, 88);
            this.temperature4CheckBox.Name = "temperature4CheckBox";
            this.temperature4CheckBox.Size = new System.Drawing.Size(121, 21);
            this.temperature4CheckBox.TabIndex = 4;
            this.temperature4CheckBox.Text = "Temperatura 4";
            this.temperature4CheckBox.UseVisualStyleBackColor = false;
            this.temperature4CheckBox.CheckedChanged += new System.EventHandler(this.Form2_Load);
            // 
            // temperature
            // 
            this.temperature.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.temperature.Controls.Add(this.temperature1CheckBox);
            this.temperature.Controls.Add(this.temperature4CheckBox);
            this.temperature.Controls.Add(this.temperature2CheckBox);
            this.temperature.Controls.Add(this.temperature3CheckBox);
            this.temperature.Location = new System.Drawing.Point(441, 12);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(131, 122);
            this.temperature.TabIndex = 5;
            this.temperature.TabStop = false;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.refreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.Location = new System.Drawing.Point(441, 296);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(126, 49);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Odśwież";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.Form2_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.maxTimePicker);
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.minTimePicker);
            this.groupBox1.Controls.Add(this.minLabel);
            this.groupBox1.Controls.Add(this.minMaxCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(447, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 149);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Min/Max godziny:";
            // 
            // maxTimePicker
            // 
            this.maxTimePicker.Checked = false;
            this.maxTimePicker.CustomFormat = " dd.MM HH:mm";
            this.maxTimePicker.Enabled = false;
            this.maxTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.maxTimePicker.Location = new System.Drawing.Point(7, 116);
            this.maxTimePicker.Name = "maxTimePicker";
            this.maxTimePicker.ShowUpDown = true;
            this.maxTimePicker.Size = new System.Drawing.Size(99, 23);
            this.maxTimePicker.TabIndex = 4;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxLabel.Location = new System.Drawing.Point(7, 95);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(78, 17);
            this.maxLabel.TabIndex = 3;
            this.maxLabel.Text = "Maksimum:";
            // 
            // minTimePicker
            // 
            this.minTimePicker.Checked = false;
            this.minTimePicker.CustomFormat = " dd.MM HH:mm";
            this.minTimePicker.Enabled = false;
            this.minTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.minTimePicker.Location = new System.Drawing.Point(7, 69);
            this.minTimePicker.Name = "minTimePicker";
            this.minTimePicker.ShowUpDown = true;
            this.minTimePicker.Size = new System.Drawing.Size(99, 23);
            this.minTimePicker.TabIndex = 2;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLabel.Location = new System.Drawing.Point(7, 48);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(67, 17);
            this.minLabel.TabIndex = 1;
            this.minLabel.Text = "Minimum:";
            // 
            // minMaxCheckBox
            // 
            this.minMaxCheckBox.AutoSize = true;
            this.minMaxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minMaxCheckBox.Location = new System.Drawing.Point(7, 20);
            this.minMaxCheckBox.Name = "minMaxCheckBox";
            this.minMaxCheckBox.Size = new System.Drawing.Size(99, 21);
            this.minMaxCheckBox.TabIndex = 0;
            this.minMaxCheckBox.Text = "Zmień czas";
            this.minMaxCheckBox.UseVisualStyleBackColor = true;
            this.minMaxCheckBox.CheckedChanged += new System.EventHandler(this.MinMaxCheckBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.chart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form2";
            this.Text = "Wykres";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.temperature.ResumeLayout(false);
            this.temperature.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.CheckBox temperature1CheckBox;
        private System.Windows.Forms.CheckBox temperature2CheckBox;
        private System.Windows.Forms.CheckBox temperature3CheckBox;
        private System.Windows.Forms.CheckBox temperature4CheckBox;
        private System.Windows.Forms.GroupBox temperature;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker minTimePicker;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.CheckBox minMaxCheckBox;
        private System.Windows.Forms.DateTimePicker maxTimePicker;
        private System.Windows.Forms.Label maxLabel;
    }
}