
namespace PeakTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbMinutes = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.timerText = new System.Windows.Forms.Label();
            this.lbTimeLeftFileName = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.cbTriggerTimer = new System.Windows.Forms.CheckBox();
            this.TimeTrigger = new System.Windows.Forms.DateTimePicker();
            this.lbZoneOffset = new System.Windows.Forms.Label();
            this.groupConfig = new System.Windows.Forms.GroupBox();
            this.lbFinalText = new System.Windows.Forms.Label();
            this.tbFinalText = new System.Windows.Forms.TextBox();
            this.groupTimer = new System.Windows.Forms.GroupBox();
            this.lbTimerTrigger = new System.Windows.Forms.Label();
            this.timerTrigger = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            this.groupConfig.SuspendLayout();
            this.groupTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(461, 87);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Event);
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(138, 27);
            this.lbMinutes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(50, 15);
            this.lbMinutes.TabIndex = 1;
            this.lbMinutes.Text = "Minutes";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.Location = new System.Drawing.Point(332, 27);
            this.lbSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(51, 15);
            this.lbSeconds.TabIndex = 2;
            this.lbSeconds.Text = "Seconds";
            // 
            // timerText
            // 
            this.timerText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerText.Location = new System.Drawing.Point(8, 34);
            this.timerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(525, 50);
            this.timerText.TabIndex = 3;
            this.timerText.Text = "Placeholder";
            this.timerText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeLeftFileName
            // 
            this.lbTimeLeftFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimeLeftFileName.Location = new System.Drawing.Point(13, 275);
            this.lbTimeLeftFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeLeftFileName.Name = "lbTimeLeftFileName";
            this.lbTimeLeftFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTimeLeftFileName.Size = new System.Drawing.Size(543, 23);
            this.lbTimeLeftFileName.TabIndex = 4;
            this.lbTimeLeftFileName.Text = "Time is stored in this file";
            this.lbTimeLeftFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMinutes
            // 
            this.nudMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nudMinutes.AutoSize = true;
            this.nudMinutes.Location = new System.Drawing.Point(7, 22);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudMinutes.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(124, 23);
            this.nudMinutes.TabIndex = 5;
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(201, 23);
            this.nudSeconds.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(124, 23);
            this.nudSeconds.TabIndex = 6;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(381, 87);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 45);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSet.Location = new System.Drawing.Point(415, 22);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(115, 82);
            this.btnSet.TabIndex = 13;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // cbTriggerTimer
            // 
            this.cbTriggerTimer.AutoSize = true;
            this.cbTriggerTimer.Location = new System.Drawing.Point(7, 55);
            this.cbTriggerTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbTriggerTimer.Name = "cbTriggerTimer";
            this.cbTriggerTimer.Size = new System.Drawing.Size(126, 19);
            this.cbTriggerTimer.TabIndex = 14;
            this.cbTriggerTimer.Text = "Set timer to start at";
            this.cbTriggerTimer.UseVisualStyleBackColor = true;
            this.cbTriggerTimer.CheckStateChanged += new System.EventHandler(this.ToggleTimeTrigger);
            // 
            // TimeTrigger
            // 
            this.TimeTrigger.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.TimeTrigger.Enabled = false;
            this.TimeTrigger.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeTrigger.Location = new System.Drawing.Point(153, 52);
            this.TimeTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeTrigger.Name = "TimeTrigger";
            this.TimeTrigger.ShowUpDown = true;
            this.TimeTrigger.Size = new System.Drawing.Size(172, 23);
            this.TimeTrigger.TabIndex = 15;
            this.TimeTrigger.Value = new System.DateTime(2021, 6, 2, 23, 41, 59, 0);
            // 
            // lbZoneOffset
            // 
            this.lbZoneOffset.AutoSize = true;
            this.lbZoneOffset.Enabled = false;
            this.lbZoneOffset.Location = new System.Drawing.Point(333, 57);
            this.lbZoneOffset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbZoneOffset.Name = "lbZoneOffset";
            this.lbZoneOffset.Size = new System.Drawing.Size(35, 15);
            this.lbZoneOffset.TabIndex = 16;
            this.lbZoneOffset.Text = "Local";
            // 
            // groupConfig
            // 
            this.groupConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupConfig.Controls.Add(this.lbFinalText);
            this.groupConfig.Controls.Add(this.tbFinalText);
            this.groupConfig.Controls.Add(this.nudMinutes);
            this.groupConfig.Controls.Add(this.lbZoneOffset);
            this.groupConfig.Controls.Add(this.lbMinutes);
            this.groupConfig.Controls.Add(this.TimeTrigger);
            this.groupConfig.Controls.Add(this.lbSeconds);
            this.groupConfig.Controls.Add(this.cbTriggerTimer);
            this.groupConfig.Controls.Add(this.nudSeconds);
            this.groupConfig.Controls.Add(this.btnSet);
            this.groupConfig.Location = new System.Drawing.Point(14, 14);
            this.groupConfig.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupConfig.Size = new System.Drawing.Size(541, 115);
            this.groupConfig.TabIndex = 17;
            this.groupConfig.TabStop = false;
            this.groupConfig.Text = "Config";
            // 
            // lbFinalText
            // 
            this.lbFinalText.AutoSize = true;
            this.lbFinalText.Location = new System.Drawing.Point(333, 85);
            this.lbFinalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFinalText.Name = "lbFinalText";
            this.lbFinalText.Size = new System.Drawing.Size(55, 15);
            this.lbFinalText.TabIndex = 17;
            this.lbFinalText.Text = "Final text";
            // 
            // tbFinalText
            // 
            this.tbFinalText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbFinalText.Location = new System.Drawing.Point(7, 82);
            this.tbFinalText.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbFinalText.Name = "tbFinalText";
            this.tbFinalText.Size = new System.Drawing.Size(318, 23);
            this.tbFinalText.TabIndex = 18;
            this.tbFinalText.Text = "Peak!";
            // 
            // groupTimer
            // 
            this.groupTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTimer.Controls.Add(this.lbTimerTrigger);
            this.groupTimer.Controls.Add(this.timerText);
            this.groupTimer.Controls.Add(this.btnStart);
            this.groupTimer.Controls.Add(this.btnStop);
            this.groupTimer.Location = new System.Drawing.Point(14, 134);
            this.groupTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupTimer.Name = "groupTimer";
            this.groupTimer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupTimer.Size = new System.Drawing.Size(541, 138);
            this.groupTimer.TabIndex = 18;
            this.groupTimer.TabStop = false;
            this.groupTimer.Text = "Timer";
            // 
            // lbTimerTrigger
            // 
            this.lbTimerTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTimerTrigger.Location = new System.Drawing.Point(8, 19);
            this.lbTimerTrigger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimerTrigger.Name = "lbTimerTrigger";
            this.lbTimerTrigger.Size = new System.Drawing.Size(525, 15);
            this.lbTimerTrigger.TabIndex = 12;
            this.lbTimerTrigger.Text = "Timer info";
            // 
            // timerTrigger
            // 
            this.timerTrigger.Interval = 1000;
            this.timerTrigger.Tick += new System.EventHandler(this.TimerTrigger_Event);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 307);
            this.Controls.Add(this.groupTimer);
            this.Controls.Add(this.groupConfig);
            this.Controls.Add(this.lbTimeLeftFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(585, 346);
            this.Name = "MainForm";
            this.Text = "Peak Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            this.groupConfig.ResumeLayout(false);
            this.groupConfig.PerformLayout();
            this.groupTimer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Label lbTimeLeftFileName;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.CheckBox cbTriggerTimer;
        private System.Windows.Forms.DateTimePicker TimeTrigger;
        private System.Windows.Forms.Label lbZoneOffset;
        private System.Windows.Forms.GroupBox groupConfig;
        private System.Windows.Forms.GroupBox groupTimer;
        private System.Windows.Forms.Timer timerTrigger;
        private System.Windows.Forms.Label lbTimerTrigger;
        private System.Windows.Forms.Label lbFinalText;
        private System.Windows.Forms.TextBox tbFinalText;
    }
}

