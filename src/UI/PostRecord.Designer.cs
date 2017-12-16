namespace Sermon_Record.UI
{
    partial class PostRecord
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.lblWaveform = new System.Windows.Forms.Label();
            this.lblSermonDetails = new System.Windows.Forms.Label();
            this._series = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this._title = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this._speaker = new System.Windows.Forms.TextBox();
            this.lblSpeaker = new System.Windows.Forms.Label();
            this._passage = new System.Windows.Forms.TextBox();
            this.lblPassage = new System.Windows.Forms.Label();
            this.saveLocationDlg = new System.Windows.Forms.SaveFileDialog();
            this.saveLocation = new System.Windows.Forms.TextBox();
            this.saveLocationBtn = new System.Windows.Forms.Button();
            this.lblSaveLocation = new System.Windows.Forms.Label();
            this.waveform = new Sermon_Record.UTIL.WaveformSelector();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1165, 655);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 100);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscard.Location = new System.Drawing.Point(1165, 9);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(200, 100);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // lblWaveform
            // 
            this.lblWaveform.AutoSize = true;
            this.lblWaveform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblWaveform.Location = new System.Drawing.Point(4, 259);
            this.lblWaveform.Name = "lblWaveform";
            this.lblWaveform.Size = new System.Drawing.Size(213, 31);
            this.lblWaveform.TabIndex = 27;
            this.lblWaveform.Text = "Trim Recording";
            // 
            // lblSermonDetails
            // 
            this.lblSermonDetails.AutoSize = true;
            this.lblSermonDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSermonDetails.Location = new System.Drawing.Point(4, 9);
            this.lblSermonDetails.Name = "lblSermonDetails";
            this.lblSermonDetails.Size = new System.Drawing.Size(213, 31);
            this.lblSermonDetails.TabIndex = 28;
            this.lblSermonDetails.Text = "Sermon Details";
            // 
            // _series
            // 
            this._series.Location = new System.Drawing.Point(137, 109);
            this._series.Name = "_series";
            this._series.Size = new System.Drawing.Size(371, 31);
            this._series.TabIndex = 2;
            this._series.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblSeries
            // 
            this.lblSeries.AutoSize = true;
            this.lblSeries.Location = new System.Drawing.Point(48, 110);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(73, 25);
            this.lblSeries.TabIndex = 35;
            this.lblSeries.Text = "Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _title
            // 
            this._title.Location = new System.Drawing.Point(137, 58);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(371, 31);
            this._title.TabIndex = 1;
            this._title.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(68, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(53, 25);
            this.lblTitle.TabIndex = 37;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _speaker
            // 
            this._speaker.Location = new System.Drawing.Point(137, 211);
            this._speaker.Name = "_speaker";
            this._speaker.Size = new System.Drawing.Size(371, 31);
            this._speaker.TabIndex = 4;
            this._speaker.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblSpeaker
            // 
            this.lblSpeaker.AutoSize = true;
            this.lblSpeaker.Location = new System.Drawing.Point(29, 214);
            this.lblSpeaker.Name = "lblSpeaker";
            this.lblSpeaker.Size = new System.Drawing.Size(92, 25);
            this.lblSpeaker.TabIndex = 39;
            this.lblSpeaker.Text = "Speaker";
            this.lblSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _passage
            // 
            this._passage.Location = new System.Drawing.Point(137, 160);
            this._passage.Name = "_passage";
            this._passage.Size = new System.Drawing.Size(371, 31);
            this._passage.TabIndex = 3;
            this._passage.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lblPassage
            // 
            this.lblPassage.AutoSize = true;
            this.lblPassage.Location = new System.Drawing.Point(25, 162);
            this.lblPassage.Name = "lblPassage";
            this.lblPassage.Size = new System.Drawing.Size(96, 25);
            this.lblPassage.TabIndex = 41;
            this.lblPassage.Text = "Passage";
            this.lblPassage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saveLocationDlg
            // 
            this.saveLocationDlg.DefaultExt = "mp3";
            this.saveLocationDlg.Filter = "MP3 File|*.mp3";
            // 
            // saveLocation
            // 
            this.saveLocation.Location = new System.Drawing.Point(12, 700);
            this.saveLocation.Name = "saveLocation";
            this.saveLocation.ReadOnly = true;
            this.saveLocation.Size = new System.Drawing.Size(1141, 31);
            this.saveLocation.TabIndex = 5;
            this.saveLocation.TabStop = false;
            // 
            // saveLocationBtn
            // 
            this.saveLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.saveLocationBtn.Location = new System.Drawing.Point(12, 747);
            this.saveLocationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.saveLocationBtn.Name = "saveLocationBtn";
            this.saveLocationBtn.Size = new System.Drawing.Size(111, 53);
            this.saveLocationBtn.TabIndex = 6;
            this.saveLocationBtn.Text = "Change";
            this.saveLocationBtn.UseVisualStyleBackColor = true;
            this.saveLocationBtn.Click += new System.EventHandler(this.saveLocationBtn_Click);
            // 
            // lblSaveLocation
            // 
            this.lblSaveLocation.AutoSize = true;
            this.lblSaveLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblSaveLocation.Location = new System.Drawing.Point(4, 657);
            this.lblSaveLocation.Name = "lblSaveLocation";
            this.lblSaveLocation.Size = new System.Drawing.Size(199, 31);
            this.lblSaveLocation.TabIndex = 46;
            this.lblSaveLocation.Text = "Save Location";
            // 
            // waveform
            // 
            this.waveform.Location = new System.Drawing.Point(9, 304);
            this.waveform.Name = "waveform";
            this.waveform.Size = new System.Drawing.Size(1356, 338);
            this.waveform.TabIndex = 52;
            // 
            // PostRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 809);
            this.ControlBox = false;
            this.Controls.Add(this.waveform);
            this.Controls.Add(this.lblSaveLocation);
            this.Controls.Add(this.saveLocationBtn);
            this.Controls.Add(this.saveLocation);
            this.Controls.Add(this._passage);
            this.Controls.Add(this.lblPassage);
            this.Controls.Add(this._speaker);
            this.Controls.Add(this.lblSpeaker);
            this.Controls.Add(this._title);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this._series);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblSermonDetails);
            this.Controls.Add(this.lblWaveform);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSave);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 880);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 880);
            this.Name = "PostRecord";
            this.ShowIcon = false;
            this.Text = "Recording Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PostRecord_FormClosed);
            this.Load += new System.EventHandler(this.PostRecord_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PostRecord_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label lblWaveform;
        private System.Windows.Forms.Label lblSermonDetails;
        private System.Windows.Forms.TextBox _series;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.TextBox _title;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox _speaker;
        private System.Windows.Forms.Label lblSpeaker;
        private System.Windows.Forms.TextBox _passage;
        private System.Windows.Forms.Label lblPassage;
        private System.Windows.Forms.SaveFileDialog saveLocationDlg;
        private System.Windows.Forms.TextBox saveLocation;
        private System.Windows.Forms.Button saveLocationBtn;
        private System.Windows.Forms.Label lblSaveLocation;
        private UTIL.WaveformSelector waveform;
    }
}