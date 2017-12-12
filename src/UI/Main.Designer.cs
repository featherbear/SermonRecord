namespace Sermon_Record.UI
{
    partial class Main
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.elapsedTimeLbl = new System.Windows.Forms.Label();
            this.elapsedTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterG = new System.Windows.Forms.ProgressBar();
            this.soundMeterGTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterTTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterT = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(24, 119);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(200, 200);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "START";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.recordStartStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1400, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreferences.Location = new System.Drawing.Point(1300, 455);
            this.btnPreferences.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(200, 100);
            this.btnPreferences.TabIndex = 3;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // elapsedTimeLbl
            // 
            this.elapsedTimeLbl.AutoSize = true;
            this.elapsedTimeLbl.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeLbl.Location = new System.Drawing.Point(266, 207);
            this.elapsedTimeLbl.Name = "elapsedTimeLbl";
            this.elapsedTimeLbl.Size = new System.Drawing.Size(232, 56);
            this.elapsedTimeLbl.TabIndex = 4;
            this.elapsedTimeLbl.Text = "00:00:00";
            // 
            // elapsedTimeTimer
            // 
            this.elapsedTimeTimer.Interval = 1000;
            this.elapsedTimeTimer.Tick += new System.EventHandler(this.elapsedTimeTimer_Tick);
            // 
            // soundMeterG
            // 
            this.soundMeterG.Location = new System.Drawing.Point(24, 322);
            this.soundMeterG.Margin = new System.Windows.Forms.Padding(0);
            this.soundMeterG.MarqueeAnimationSpeed = 0;
            this.soundMeterG.Maximum = 66;
            this.soundMeterG.Name = "soundMeterG";
            this.soundMeterG.Size = new System.Drawing.Size(200, 23);
            this.soundMeterG.Step = 0;
            this.soundMeterG.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.soundMeterG.TabIndex = 5;
            // 
            // soundMeterGTimer
            // 
            this.soundMeterGTimer.Enabled = true;
            this.soundMeterGTimer.Interval = 30;
            this.soundMeterGTimer.Tick += new System.EventHandler(this.soundMeterGTimer_Tick);
            // 
            // soundMeterTTimer
            // 
            this.soundMeterTTimer.Enabled = true;
            this.soundMeterTTimer.Interval = 1000;
            this.soundMeterTTimer.Tick += new System.EventHandler(this.soundMeterTTimer_Tick);
            // 
            // soundMeterT
            // 
            this.soundMeterT.AutoSize = true;
            this.soundMeterT.Location = new System.Drawing.Point(19, 423);
            this.soundMeterT.Name = "soundMeterT";
            this.soundMeterT.Size = new System.Drawing.Size(163, 25);
            this.soundMeterT.TabIndex = 6;
            this.soundMeterT.Text = "(AUDIO LEVEL)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(800, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Compute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(1010, 185);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 8;
            this.Print.Text = "button2";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Print);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.soundMeterT);
            this.Controls.Add(this.soundMeterG);
            this.Controls.Add(this.elapsedTimeLbl);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecord);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1500, 555);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Timer elapsedTimeTimer;
        public System.Windows.Forms.Label elapsedTimeLbl;
        private System.Windows.Forms.ProgressBar soundMeterG;
        private System.Windows.Forms.Timer soundMeterGTimer;
        private System.Windows.Forms.Timer soundMeterTTimer;
        private System.Windows.Forms.Label soundMeterT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Print;
    }
}
