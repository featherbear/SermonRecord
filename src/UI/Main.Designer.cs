using System.Windows.Forms;
using Sermon_Record.UTIL;

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
            this.soundMeterGTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterTTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterT = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.fileSize = new System.Windows.Forms.Label();
            this.fileSizeTimer = new System.Windows.Forms.Timer(this.components);
            this.soundMeterG = new Sermon_Record.UTIL.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(553, 325);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(200, 200);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "START";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.RecordStartStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1207, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 100);
            this.btnExit.TabIndex = 2;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Location = new System.Drawing.Point(0, 0);
            this.btnPreferences.Margin = new System.Windows.Forms.Padding(0);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(200, 100);
            this.btnPreferences.TabIndex = 3;
            this.btnPreferences.TabStop = false;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.BtnPreferences_Click);
            // 
            // elapsedTimeLbl
            // 
            this.elapsedTimeLbl.AutoSize = true;
            this.elapsedTimeLbl.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTimeLbl.Location = new System.Drawing.Point(342, 92);
            this.elapsedTimeLbl.Name = "elapsedTimeLbl";
            this.elapsedTimeLbl.Size = new System.Drawing.Size(623, 150);
            this.elapsedTimeLbl.TabIndex = 4;
            this.elapsedTimeLbl.Text = "00:00:00";
            this.elapsedTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // elapsedTimeTimer
            // 
            this.elapsedTimeTimer.Interval = 700;
            this.elapsedTimeTimer.Tick += new System.EventHandler(this.ElapsedTimeTimer_Tick);
            // 
            // soundMeterGTimer
            // 
            this.soundMeterGTimer.Enabled = true;
            this.soundMeterGTimer.Interval = 30;
            this.soundMeterGTimer.Tick += new System.EventHandler(this.SoundMeterGTimer_Tick);
            // 
            // soundMeterTTimer
            // 
            this.soundMeterTTimer.Enabled = true;
            this.soundMeterTTimer.Interval = 1000;
            this.soundMeterTTimer.Tick += new System.EventHandler(this.SoundMeterTTimer_Tick);
            // 
            // soundMeterT
            // 
            this.soundMeterT.AutoSize = true;
            this.soundMeterT.Location = new System.Drawing.Point(3, 500);
            this.soundMeterT.Name = "soundMeterT";
            this.soundMeterT.Size = new System.Drawing.Size(0, 25);
            this.soundMeterT.TabIndex = 6;
            this.soundMeterT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(548, 253);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(107, 25);
            this.lblFileSize.TabIndex = 19;
            this.lblFileSize.Text = "File Size: ";
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFileSize.Visible = false;
            // 
            // fileSize
            // 
            this.fileSize.AutoSize = true;
            this.fileSize.Location = new System.Drawing.Point(646, 253);
            this.fileSize.Name = "fileSize";
            this.fileSize.Size = new System.Drawing.Size(0, 25);
            this.fileSize.TabIndex = 20;
            this.fileSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileSize.Visible = false;
            // 
            // fileSizeTimer
            // 
            this.fileSizeTimer.Interval = 1500;
            this.fileSizeTimer.Tick += new System.EventHandler(this.FileSizeTimer_Tick);
            // 
            // soundMeterG
            // 
            this.soundMeterG.Location = new System.Drawing.Point(8, 267);
            this.soundMeterG.Margin = new System.Windows.Forms.Padding(0);
            this.soundMeterG.MarqueeAnimationSpeed = 0;
            this.soundMeterG.Maximum = 66;
            this.soundMeterG.Name = "soundMeterG";
            this.soundMeterG.Size = new System.Drawing.Size(40, 224);
            this.soundMeterG.Step = 0;
            this.soundMeterG.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.soundMeterG.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.fileSize);
            this.Controls.Add(this.soundMeterT);
            this.Controls.Add(this.soundMeterG);
            this.Controls.Add(this.elapsedTimeLbl);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.lblFileSize);
            this.Name = "Main";
            this.Size = new System.Drawing.Size(1307, 555);
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
        private VerticalProgressBar soundMeterG;
        private System.Windows.Forms.Timer soundMeterGTimer;
        private System.Windows.Forms.Timer soundMeterTTimer;
        private System.Windows.Forms.Label soundMeterT;
        private Label lblFileSize;
        private Label fileSize;
        private Timer fileSizeTimer;
    }
}
