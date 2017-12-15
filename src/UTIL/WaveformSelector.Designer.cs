namespace Sermon_Record.UTIL
{
    partial class WaveformSelector
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
            this.imgWaveform = new System.Windows.Forms.PictureBox();
            this.handleLeft = new System.Windows.Forms.PictureBox();
            this.handleRight = new System.Windows.Forms.PictureBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.TextBox();
            this.endTime = new System.Windows.Forms.TextBox();
            this.originalDuration = new System.Windows.Forms.TextBox();
            this.lblOriginalDuration = new System.Windows.Forms.Label();
            this.newDuration = new System.Windows.Forms.TextBox();
            this.lblNewDuration = new System.Windows.Forms.Label();
            this.helptip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgWaveform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleRight)).BeginInit();
            this.SuspendLayout();
            // 
            // imgWaveform
            // 
            this.imgWaveform.BackColor = System.Drawing.Color.LightGray;
            this.imgWaveform.Location = new System.Drawing.Point(0, 0);
            this.imgWaveform.Margin = new System.Windows.Forms.Padding(0);
            this.imgWaveform.Name = "imgWaveform";
            this.imgWaveform.Size = new System.Drawing.Size(1356, 251);
            this.imgWaveform.TabIndex = 0;
            this.imgWaveform.TabStop = false;
            // 
            // handleLeft
            // 
            this.handleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.handleLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.handleLeft.Location = new System.Drawing.Point(184, 0);
            this.handleLeft.Margin = new System.Windows.Forms.Padding(0);
            this.handleLeft.Name = "handleLeft";
            this.handleLeft.Size = new System.Drawing.Size(10, 251);
            this.handleLeft.TabIndex = 2;
            this.handleLeft.TabStop = false;
            this.handleLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.handleLeft_MouseMove);
            // 
            // handleRight
            // 
            this.handleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.handleRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.handleRight.Location = new System.Drawing.Point(1255, 0);
            this.handleRight.Margin = new System.Windows.Forms.Padding(0);
            this.handleRight.Name = "handleRight";
            this.handleRight.Size = new System.Drawing.Size(10, 251);
            this.handleRight.TabIndex = 3;
            this.handleRight.TabStop = false;
            this.handleRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.handleRight_MouseMove);
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(1096, 269);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(110, 25);
            this.lblStartTime.TabIndex = 6;
            this.lblStartTime.Text = "Start Time";
            this.lblStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(1239, 269);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(103, 25);
            this.lblEndTime.TabIndex = 7;
            this.lblEndTime.Text = "End Time";
            this.lblEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(1101, 307);
            this.startTime.Name = "startTime";
            this.startTime.ReadOnly = true;
            this.startTime.Size = new System.Drawing.Size(100, 31);
            this.startTime.TabIndex = 8;
            this.startTime.TabStop = false;
            this.startTime.Text = "00:00:00";
            this.startTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(1240, 307);
            this.endTime.Name = "endTime";
            this.endTime.ReadOnly = true;
            this.endTime.Size = new System.Drawing.Size(100, 31);
            this.endTime.TabIndex = 9;
            this.endTime.TabStop = false;
            this.endTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // originalDuration
            // 
            this.originalDuration.Location = new System.Drawing.Point(189, 266);
            this.originalDuration.Name = "originalDuration";
            this.originalDuration.ReadOnly = true;
            this.originalDuration.Size = new System.Drawing.Size(100, 31);
            this.originalDuration.TabIndex = 11;
            this.originalDuration.TabStop = false;
            this.originalDuration.Text = "00:00:00";
            this.originalDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOriginalDuration
            // 
            this.lblOriginalDuration.AutoSize = true;
            this.lblOriginalDuration.Location = new System.Drawing.Point(10, 269);
            this.lblOriginalDuration.Name = "lblOriginalDuration";
            this.lblOriginalDuration.Size = new System.Drawing.Size(173, 25);
            this.lblOriginalDuration.TabIndex = 10;
            this.lblOriginalDuration.Text = "Original Duration";
            this.lblOriginalDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // newDuration
            // 
            this.newDuration.Location = new System.Drawing.Point(189, 307);
            this.newDuration.Name = "newDuration";
            this.newDuration.ReadOnly = true;
            this.newDuration.Size = new System.Drawing.Size(100, 31);
            this.newDuration.TabIndex = 13;
            this.newDuration.TabStop = false;
            this.newDuration.Text = "00:00:00";
            this.newDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNewDuration
            // 
            this.lblNewDuration.AutoSize = true;
            this.lblNewDuration.Location = new System.Drawing.Point(42, 310);
            this.lblNewDuration.Name = "lblNewDuration";
            this.lblNewDuration.Size = new System.Drawing.Size(141, 25);
            this.lblNewDuration.TabIndex = 12;
            this.lblNewDuration.Text = "New Duration";
            this.lblNewDuration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // helptip
            // 
            this.helptip.AutoSize = true;
            this.helptip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helptip.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.helptip.Location = new System.Drawing.Point(456, 291);
            this.helptip.Name = "helptip";
            this.helptip.Size = new System.Drawing.Size(438, 25);
            this.helptip.TabIndex = 14;
            this.helptip.Text = "Drag the above handles to trim the recording";
            this.helptip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaveformSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.helptip);
            this.Controls.Add(this.newDuration);
            this.Controls.Add(this.lblNewDuration);
            this.Controls.Add(this.originalDuration);
            this.Controls.Add(this.lblOriginalDuration);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.handleRight);
            this.Controls.Add(this.handleLeft);
            this.Controls.Add(this.imgWaveform);
            this.Name = "WaveformSelector";
            this.Size = new System.Drawing.Size(1356, 360);
            ((System.ComponentModel.ISupportInitialize)(this.imgWaveform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.handleRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgWaveform;
        private System.Windows.Forms.PictureBox handleLeft;
        private System.Windows.Forms.PictureBox handleRight;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.TextBox endTime;
        private System.Windows.Forms.TextBox originalDuration;
        private System.Windows.Forms.Label lblOriginalDuration;
        private System.Windows.Forms.TextBox newDuration;
        private System.Windows.Forms.Label lblNewDuration;
        private System.Windows.Forms.Label helptip;
    }
}
