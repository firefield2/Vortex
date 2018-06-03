namespace Vortex
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fourthTemp = new System.Windows.Forms.Label();
            this.secondTemp = new System.Windows.Forms.Label();
            this.thirdTemp = new System.Windows.Forms.Label();
            this.firstTemp = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.fourthLabel = new System.Windows.Forms.Label();
            this.actualTempBox = new System.Windows.Forms.GroupBox();
            this.alarmBox = new System.Windows.Forms.GroupBox();
            this.vesselCheckBox = new System.Windows.Forms.CheckBox();
            this.fourthTempAlarmBox = new System.Windows.Forms.TextBox();
            this.thirdTempAlarmBox = new System.Windows.Forms.TextBox();
            this.secondTempAlarmBox = new System.Windows.Forms.TextBox();
            this.firstTempAlarmBox = new System.Windows.Forms.TextBox();
            this.alarmAllOnOFFButton = new System.Windows.Forms.Button();
            this.fourthAlarmOn = new System.Windows.Forms.CheckBox();
            this.thirdAlarmOn = new System.Windows.Forms.CheckBox();
            this.secondAlarmOn = new System.Windows.Forms.CheckBox();
            this.firstAlarmOn = new System.Windows.Forms.CheckBox();
            this.thirdTempAlarm = new System.Windows.Forms.Label();
            this.fourthTempAlarm = new System.Windows.Forms.Label();
            this.secondTempAlarm = new System.Windows.Forms.Label();
            this.firstTempAlarm = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.chartButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.actualTempBox.SuspendLayout();
            this.alarmBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fourthTemp
            // 
            resources.ApplyResources(this.fourthTemp, "fourthTemp");
            this.fourthTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fourthTemp.Name = "fourthTemp";
            // 
            // secondTemp
            // 
            resources.ApplyResources(this.secondTemp, "secondTemp");
            this.secondTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.secondTemp.Name = "secondTemp";
            // 
            // thirdTemp
            // 
            resources.ApplyResources(this.thirdTemp, "thirdTemp");
            this.thirdTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.thirdTemp.Name = "thirdTemp";
            // 
            // firstTemp
            // 
            this.firstTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.firstTemp, "firstTemp");
            this.firstTemp.Name = "firstTemp";
            // 
            // thirdLabel
            // 
            resources.ApplyResources(this.thirdLabel, "thirdLabel");
            this.thirdLabel.Name = "thirdLabel";
            // 
            // secondLabel
            // 
            resources.ApplyResources(this.secondLabel, "secondLabel");
            this.secondLabel.Name = "secondLabel";
            // 
            // firstLabel
            // 
            resources.ApplyResources(this.firstLabel, "firstLabel");
            this.firstLabel.Name = "firstLabel";
            // 
            // fourthLabel
            // 
            resources.ApplyResources(this.fourthLabel, "fourthLabel");
            this.fourthLabel.Name = "fourthLabel";
            // 
            // actualTempBox
            // 
            this.actualTempBox.Controls.Add(this.secondTemp);
            this.actualTempBox.Controls.Add(this.firstTemp);
            this.actualTempBox.Controls.Add(this.thirdTemp);
            this.actualTempBox.Controls.Add(this.fourthTemp);
            resources.ApplyResources(this.actualTempBox, "actualTempBox");
            this.actualTempBox.Name = "actualTempBox";
            this.actualTempBox.TabStop = false;
            // 
            // alarmBox
            // 
            this.alarmBox.Controls.Add(this.vesselCheckBox);
            this.alarmBox.Controls.Add(this.fourthTempAlarmBox);
            this.alarmBox.Controls.Add(this.thirdTempAlarmBox);
            this.alarmBox.Controls.Add(this.secondTempAlarmBox);
            this.alarmBox.Controls.Add(this.firstTempAlarmBox);
            this.alarmBox.Controls.Add(this.alarmAllOnOFFButton);
            this.alarmBox.Controls.Add(this.fourthAlarmOn);
            this.alarmBox.Controls.Add(this.thirdAlarmOn);
            this.alarmBox.Controls.Add(this.secondAlarmOn);
            this.alarmBox.Controls.Add(this.firstAlarmOn);
            this.alarmBox.Controls.Add(this.thirdTempAlarm);
            this.alarmBox.Controls.Add(this.fourthTempAlarm);
            this.alarmBox.Controls.Add(this.secondTempAlarm);
            this.alarmBox.Controls.Add(this.firstTempAlarm);
            resources.ApplyResources(this.alarmBox, "alarmBox");
            this.alarmBox.Name = "alarmBox";
            this.alarmBox.TabStop = false;
            // 
            // vesselCheckBox
            // 
            resources.ApplyResources(this.vesselCheckBox, "vesselCheckBox");
            this.vesselCheckBox.Name = "vesselCheckBox";
            this.vesselCheckBox.UseVisualStyleBackColor = true;
            // 
            // fourthTempAlarmBox
            // 
            this.fourthTempAlarmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.fourthTempAlarmBox, "fourthTempAlarmBox");
            this.fourthTempAlarmBox.HideSelection = false;
            this.fourthTempAlarmBox.Name = "fourthTempAlarmBox";
            this.fourthTempAlarmBox.TabStop = false;
            this.fourthTempAlarmBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FourthAlarmBox_KeyDown);
            this.fourthTempAlarmBox.Leave += new System.EventHandler(this.FourthAlarmBox_Check);
            // 
            // thirdTempAlarmBox
            // 
            this.thirdTempAlarmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.thirdTempAlarmBox, "thirdTempAlarmBox");
            this.thirdTempAlarmBox.HideSelection = false;
            this.thirdTempAlarmBox.Name = "thirdTempAlarmBox";
            this.thirdTempAlarmBox.TabStop = false;
            this.thirdTempAlarmBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThirdAlarmBox_KeyDown);
            this.thirdTempAlarmBox.Leave += new System.EventHandler(this.ThirdAlarmBox_Check);
            // 
            // secondTempAlarmBox
            // 
            this.secondTempAlarmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.secondTempAlarmBox, "secondTempAlarmBox");
            this.secondTempAlarmBox.HideSelection = false;
            this.secondTempAlarmBox.Name = "secondTempAlarmBox";
            this.secondTempAlarmBox.TabStop = false;
            this.secondTempAlarmBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SecondAlarmBox_KeyDown);
            this.secondTempAlarmBox.Leave += new System.EventHandler(this.SecondAlarmBox_Check);
            // 
            // firstTempAlarmBox
            // 
            this.firstTempAlarmBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.firstTempAlarmBox, "firstTempAlarmBox");
            this.firstTempAlarmBox.HideSelection = false;
            this.firstTempAlarmBox.Name = "firstTempAlarmBox";
            this.firstTempAlarmBox.TabStop = false;
            this.firstTempAlarmBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FirstAlarmBox_KeyPress);
            this.firstTempAlarmBox.Leave += new System.EventHandler(this.FirstAlarmBox_Check);
            // 
            // alarmAllOnOFFButton
            // 
            resources.ApplyResources(this.alarmAllOnOFFButton, "alarmAllOnOFFButton");
            this.alarmAllOnOFFButton.Name = "alarmAllOnOFFButton";
            this.alarmAllOnOFFButton.TabStop = false;
            this.alarmAllOnOFFButton.UseVisualStyleBackColor = true;
            this.alarmAllOnOFFButton.Click += new System.EventHandler(this.AlarmAllOnOFFButton_Click);
            // 
            // fourthAlarmOn
            // 
            resources.ApplyResources(this.fourthAlarmOn, "fourthAlarmOn");
            this.fourthAlarmOn.Name = "fourthAlarmOn";
            this.fourthAlarmOn.UseVisualStyleBackColor = true;
            // 
            // thirdAlarmOn
            // 
            resources.ApplyResources(this.thirdAlarmOn, "thirdAlarmOn");
            this.thirdAlarmOn.Name = "thirdAlarmOn";
            this.thirdAlarmOn.UseVisualStyleBackColor = true;
            // 
            // secondAlarmOn
            // 
            resources.ApplyResources(this.secondAlarmOn, "secondAlarmOn");
            this.secondAlarmOn.Name = "secondAlarmOn";
            this.secondAlarmOn.UseVisualStyleBackColor = true;
            // 
            // firstAlarmOn
            // 
            resources.ApplyResources(this.firstAlarmOn, "firstAlarmOn");
            this.firstAlarmOn.Name = "firstAlarmOn";
            this.firstAlarmOn.UseVisualStyleBackColor = true;
            // 
            // thirdTempAlarm
            // 
            this.thirdTempAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.thirdTempAlarm, "thirdTempAlarm");
            this.thirdTempAlarm.Name = "thirdTempAlarm";
            this.thirdTempAlarm.DoubleClick += new System.EventHandler(this.ThirdAlarm_DoubleClick);
            // 
            // fourthTempAlarm
            // 
            this.fourthTempAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.fourthTempAlarm, "fourthTempAlarm");
            this.fourthTempAlarm.Name = "fourthTempAlarm";
            this.fourthTempAlarm.DoubleClick += new System.EventHandler(this.FourthAlarm_DoubleClick);
            // 
            // secondTempAlarm
            // 
            this.secondTempAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.secondTempAlarm, "secondTempAlarm");
            this.secondTempAlarm.Name = "secondTempAlarm";
            this.secondTempAlarm.DoubleClick += new System.EventHandler(this.SecondAlarm_DoubleClick);
            // 
            // firstTempAlarm
            // 
            this.firstTempAlarm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.firstTempAlarm, "firstTempAlarm");
            this.firstTempAlarm.Name = "firstTempAlarm";
            this.firstTempAlarm.DoubleClick += new System.EventHandler(this.FirstAlarm_DoubleClick);
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.TabStop = false;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // chartButton
            // 
            resources.ApplyResources(this.chartButton, "chartButton");
            this.chartButton.Name = "chartButton";
            this.chartButton.UseVisualStyleBackColor = true;
            this.chartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // connectionStatusLabel
            // 
            resources.ApplyResources(this.connectionStatusLabel, "connectionStatusLabel");
            this.connectionStatusLabel.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.chartButton);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.alarmBox);
            this.Controls.Add(this.fourthLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.actualTempBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Enter += new System.EventHandler(this.MainForm_Enter);
            this.actualTempBox.ResumeLayout(false);
            this.alarmBox.ResumeLayout(false);
            this.alarmBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label fourthLabel;
        private System.Windows.Forms.GroupBox actualTempBox;
        private System.Windows.Forms.GroupBox alarmBox;
        private System.Windows.Forms.Button alarmAllOnOFFButton;
        private System.Windows.Forms.TextBox firstTempAlarmBox;
        private System.Windows.Forms.TextBox fourthTempAlarmBox;
        private System.Windows.Forms.TextBox thirdTempAlarmBox;
        private System.Windows.Forms.TextBox secondTempAlarmBox;
        public System.Windows.Forms.Label firstTemp;
        public System.Windows.Forms.Label fourthTemp;
        public System.Windows.Forms.Label secondTemp;
        public System.Windows.Forms.Label thirdTemp;
        public System.Windows.Forms.Label secondTempAlarm;
        public System.Windows.Forms.Label thirdTempAlarm;
        public System.Windows.Forms.Label fourthTempAlarm;
        public System.Windows.Forms.CheckBox fourthAlarmOn;
        public System.Windows.Forms.CheckBox thirdAlarmOn;
        public System.Windows.Forms.CheckBox secondAlarmOn;
        public System.Windows.Forms.CheckBox firstAlarmOn;
        public System.Windows.Forms.Label firstTempAlarm;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button chartButton;
        public System.Windows.Forms.CheckBox vesselCheckBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatusLabel;
    }
}

