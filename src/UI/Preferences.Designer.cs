namespace Sermon_Record.UI
{
    partial class Preferences
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
            this.prefRecordingDevice = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.prefRecordingDeviceLbl = new System.Windows.Forms.Label();
            this.prefTempLocation = new System.Windows.Forms.TextBox();
            this.groupRecordingAdvanced = new System.Windows.Forms.GroupBox();
            this.prefTempLocationErrorLbl = new System.Windows.Forms.Label();
            this.prefTempLocationBtn = new System.Windows.Forms.Button();
            this.prefTempLocationLbl = new System.Windows.Forms.Label();
            this.prefRecordingChannelsLbl = new System.Windows.Forms.Label();
            this.prefRecordingDepthLbl = new System.Windows.Forms.Label();
            this.prefRecordingRateLbl = new System.Windows.Forms.Label();
            this.prefRecordingChannels = new System.Windows.Forms.ComboBox();
            this.prefRecordingDepth = new System.Windows.Forms.ComboBox();
            this.prefRecordingRate = new System.Windows.Forms.ComboBox();
            this.prefRecordingLocationLbl = new System.Windows.Forms.Label();
            this.prefTempLocationDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.prefRecordingLocationDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.prefRecordingLocationBtn = new System.Windows.Forms.Button();
            this.prefRecordingLocation = new System.Windows.Forms.TextBox();
            this.prefRecordingLocationErrorLbl = new System.Windows.Forms.Label();
            this.prefRecordingAdvanced = new System.Windows.Forms.TableLayoutPanel();
            this.prefRecordingAdvanced_FALSE = new System.Windows.Forms.RadioButton();
            this.prefRecordingAdvanced_TRUE = new System.Windows.Forms.RadioButton();
            this.RecordingAdvancedLbl = new System.Windows.Forms.Label();
            this.groupRecordingAdvanced.SuspendLayout();
            this.prefRecordingAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // prefRecordingDevice
            // 
            this.prefRecordingDevice.BackColor = System.Drawing.Color.White;
            this.prefRecordingDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefRecordingDevice.FormattingEnabled = true;
            this.prefRecordingDevice.Location = new System.Drawing.Point(244, 154);
            this.prefRecordingDevice.Name = "prefRecordingDevice";
            this.prefRecordingDevice.Size = new System.Drawing.Size(396, 33);
            this.prefRecordingDevice.TabIndex = 1;
            this.prefRecordingDevice.SelectedValueChanged += new System.EventHandler(this.ChangeMade);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1207, 505);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 50);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // prefRecordingDeviceLbl
            // 
            this.prefRecordingDeviceLbl.AutoSize = true;
            this.prefRecordingDeviceLbl.Location = new System.Drawing.Point(61, 157);
            this.prefRecordingDeviceLbl.Name = "prefRecordingDeviceLbl";
            this.prefRecordingDeviceLbl.Size = new System.Drawing.Size(182, 25);
            this.prefRecordingDeviceLbl.TabIndex = 6;
            this.prefRecordingDeviceLbl.Text = "Recording Device";
            this.prefRecordingDeviceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefTempLocation
            // 
            this.prefTempLocation.BackColor = System.Drawing.Color.White;
            this.prefTempLocation.Location = new System.Drawing.Point(173, 261);
            this.prefTempLocation.Name = "prefTempLocation";
            this.prefTempLocation.Size = new System.Drawing.Size(362, 31);
            this.prefTempLocation.TabIndex = 12;
            this.prefTempLocation.TextChanged += new System.EventHandler(this.PrefTempLocation_TextChanged);
            // 
            // groupRecordingAdvanced
            // 
            this.groupRecordingAdvanced.Controls.Add(this.prefTempLocationErrorLbl);
            this.groupRecordingAdvanced.Controls.Add(this.prefTempLocationBtn);
            this.groupRecordingAdvanced.Controls.Add(this.prefTempLocationLbl);
            this.groupRecordingAdvanced.Controls.Add(this.prefTempLocation);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingChannelsLbl);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingDepthLbl);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingRateLbl);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingChannels);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingDepth);
            this.groupRecordingAdvanced.Controls.Add(this.prefRecordingRate);
            this.groupRecordingAdvanced.Location = new System.Drawing.Point(701, 107);
            this.groupRecordingAdvanced.Name = "groupRecordingAdvanced";
            this.groupRecordingAdvanced.Size = new System.Drawing.Size(619, 368);
            this.groupRecordingAdvanced.TabIndex = 13;
            this.groupRecordingAdvanced.TabStop = false;
            this.groupRecordingAdvanced.Text = "Advanced Recording";
            // 
            // prefTempLocationErrorLbl
            // 
            this.prefTempLocationErrorLbl.AutoSize = true;
            this.prefTempLocationErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.prefTempLocationErrorLbl.Location = new System.Drawing.Point(168, 294);
            this.prefTempLocationErrorLbl.Name = "prefTempLocationErrorLbl";
            this.prefTempLocationErrorLbl.Size = new System.Drawing.Size(401, 25);
            this.prefTempLocationErrorLbl.TabIndex = 26;
            this.prefTempLocationErrorLbl.Text = "Directory does not exist or is not writable";
            this.prefTempLocationErrorLbl.Visible = false;
            // 
            // prefTempLocationBtn
            // 
            this.prefTempLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefTempLocationBtn.Location = new System.Drawing.Point(538, 261);
            this.prefTempLocationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.prefTempLocationBtn.Name = "prefTempLocationBtn";
            this.prefTempLocationBtn.Size = new System.Drawing.Size(31, 31);
            this.prefTempLocationBtn.TabIndex = 22;
            this.prefTempLocationBtn.Text = "...";
            this.prefTempLocationBtn.UseVisualStyleBackColor = true;
            this.prefTempLocationBtn.Click += new System.EventHandler(this.PrefTempLocationBtn_Click);
            // 
            // prefTempLocationLbl
            // 
            this.prefTempLocationLbl.AutoSize = true;
            this.prefTempLocationLbl.Location = new System.Drawing.Point(13, 265);
            this.prefTempLocationLbl.Name = "prefTempLocationLbl";
            this.prefTempLocationLbl.Size = new System.Drawing.Size(154, 25);
            this.prefTempLocationLbl.TabIndex = 20;
            this.prefTempLocationLbl.Text = "Temp Location";
            this.prefTempLocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefRecordingChannelsLbl
            // 
            this.prefRecordingChannelsLbl.AutoSize = true;
            this.prefRecordingChannelsLbl.Location = new System.Drawing.Point(64, 193);
            this.prefRecordingChannelsLbl.Name = "prefRecordingChannelsLbl";
            this.prefRecordingChannelsLbl.Size = new System.Drawing.Size(103, 25);
            this.prefRecordingChannelsLbl.TabIndex = 21;
            this.prefRecordingChannelsLbl.Text = "Channels";
            this.prefRecordingChannelsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefRecordingDepthLbl
            // 
            this.prefRecordingDepthLbl.AutoSize = true;
            this.prefRecordingDepthLbl.Location = new System.Drawing.Point(67, 121);
            this.prefRecordingDepthLbl.Name = "prefRecordingDepthLbl";
            this.prefRecordingDepthLbl.Size = new System.Drawing.Size(100, 25);
            this.prefRecordingDepthLbl.TabIndex = 20;
            this.prefRecordingDepthLbl.Text = "Bit Depth";
            this.prefRecordingDepthLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefRecordingRateLbl
            // 
            this.prefRecordingRateLbl.AutoSize = true;
            this.prefRecordingRateLbl.Location = new System.Drawing.Point(15, 49);
            this.prefRecordingRateLbl.Name = "prefRecordingRateLbl";
            this.prefRecordingRateLbl.Size = new System.Drawing.Size(152, 25);
            this.prefRecordingRateLbl.TabIndex = 19;
            this.prefRecordingRateLbl.Text = "Sampling Rate";
            this.prefRecordingRateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefRecordingChannels
            // 
            this.prefRecordingChannels.BackColor = System.Drawing.Color.White;
            this.prefRecordingChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefRecordingChannels.FormattingEnabled = true;
            this.prefRecordingChannels.Items.AddRange(new object[] {
            "1",
            "2"});
            this.prefRecordingChannels.Location = new System.Drawing.Point(173, 189);
            this.prefRecordingChannels.Name = "prefRecordingChannels";
            this.prefRecordingChannels.Size = new System.Drawing.Size(127, 33);
            this.prefRecordingChannels.TabIndex = 29;
            this.prefRecordingChannels.SelectedValueChanged += new System.EventHandler(this.ChangeMade);
            // 
            // prefRecordingDepth
            // 
            this.prefRecordingDepth.BackColor = System.Drawing.Color.White;
            this.prefRecordingDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefRecordingDepth.FormattingEnabled = true;
            this.prefRecordingDepth.Items.AddRange(new object[] {
            "16",
            "24",
            "32"});
            this.prefRecordingDepth.Location = new System.Drawing.Point(173, 117);
            this.prefRecordingDepth.Name = "prefRecordingDepth";
            this.prefRecordingDepth.Size = new System.Drawing.Size(127, 33);
            this.prefRecordingDepth.TabIndex = 30;
            this.prefRecordingDepth.SelectedValueChanged += new System.EventHandler(this.ChangeMade);
            // 
            // prefRecordingRate
            // 
            this.prefRecordingRate.BackColor = System.Drawing.Color.White;
            this.prefRecordingRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefRecordingRate.FormattingEnabled = true;
            this.prefRecordingRate.Items.AddRange(new object[] {
            "44100",
            "48000"});
            this.prefRecordingRate.Location = new System.Drawing.Point(173, 47);
            this.prefRecordingRate.Name = "prefRecordingRate";
            this.prefRecordingRate.Size = new System.Drawing.Size(127, 33);
            this.prefRecordingRate.TabIndex = 31;
            this.prefRecordingRate.SelectedValueChanged += new System.EventHandler(this.ChangeMade);
            // 
            // prefRecordingLocationLbl
            // 
            this.prefRecordingLocationLbl.AutoSize = true;
            this.prefRecordingLocationLbl.Location = new System.Drawing.Point(45, 229);
            this.prefRecordingLocationLbl.Name = "prefRecordingLocationLbl";
            this.prefRecordingLocationLbl.Size = new System.Drawing.Size(198, 25);
            this.prefRecordingLocationLbl.TabIndex = 19;
            this.prefRecordingLocationLbl.Text = "Recording Location";
            this.prefRecordingLocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // prefTempLocationDlg
            // 
            this.prefTempLocationDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // prefRecordingLocationDlg
            // 
            this.prefRecordingLocationDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // prefRecordingLocationBtn
            // 
            this.prefRecordingLocationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefRecordingLocationBtn.Location = new System.Drawing.Point(609, 226);
            this.prefRecordingLocationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.prefRecordingLocationBtn.Name = "prefRecordingLocationBtn";
            this.prefRecordingLocationBtn.Size = new System.Drawing.Size(31, 31);
            this.prefRecordingLocationBtn.TabIndex = 24;
            this.prefRecordingLocationBtn.Text = "...";
            this.prefRecordingLocationBtn.UseVisualStyleBackColor = true;
            this.prefRecordingLocationBtn.Click += new System.EventHandler(this.PrefRecordingLocationBtn_Click);
            // 
            // prefRecordingLocation
            // 
            this.prefRecordingLocation.BackColor = System.Drawing.Color.White;
            this.prefRecordingLocation.Location = new System.Drawing.Point(244, 226);
            this.prefRecordingLocation.Name = "prefRecordingLocation";
            this.prefRecordingLocation.Size = new System.Drawing.Size(362, 31);
            this.prefRecordingLocation.TabIndex = 23;
            this.prefRecordingLocation.TextChanged += new System.EventHandler(this.PrefRecordingLocation_TextChanged);
            // 
            // prefRecordingLocationErrorLbl
            // 
            this.prefRecordingLocationErrorLbl.AutoSize = true;
            this.prefRecordingLocationErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.prefRecordingLocationErrorLbl.Location = new System.Drawing.Point(239, 257);
            this.prefRecordingLocationErrorLbl.Name = "prefRecordingLocationErrorLbl";
            this.prefRecordingLocationErrorLbl.Size = new System.Drawing.Size(401, 25);
            this.prefRecordingLocationErrorLbl.TabIndex = 25;
            this.prefRecordingLocationErrorLbl.Text = "Directory does not exist or is not writable";
            this.prefRecordingLocationErrorLbl.Visible = false;
            // 
            // prefRecordingAdvanced
            // 
            this.prefRecordingAdvanced.ColumnCount = 2;
            this.prefRecordingAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.prefRecordingAdvanced.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.prefRecordingAdvanced.Controls.Add(this.prefRecordingAdvanced_FALSE, 0, 0);
            this.prefRecordingAdvanced.Controls.Add(this.prefRecordingAdvanced_TRUE, 1, 0);
            this.prefRecordingAdvanced.Location = new System.Drawing.Point(1064, 63);
            this.prefRecordingAdvanced.Margin = new System.Windows.Forms.Padding(0);
            this.prefRecordingAdvanced.Name = "prefRecordingAdvanced";
            this.prefRecordingAdvanced.RowCount = 1;
            this.prefRecordingAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.prefRecordingAdvanced.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.prefRecordingAdvanced.Size = new System.Drawing.Size(206, 41);
            this.prefRecordingAdvanced.TabIndex = 26;
            // 
            // prefRecordingAdvanced_FALSE
            // 
            this.prefRecordingAdvanced_FALSE.Appearance = System.Windows.Forms.Appearance.Button;
            this.prefRecordingAdvanced_FALSE.AutoSize = true;
            this.prefRecordingAdvanced_FALSE.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prefRecordingAdvanced_FALSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefRecordingAdvanced_FALSE.FlatAppearance.BorderSize = 0;
            this.prefRecordingAdvanced_FALSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.prefRecordingAdvanced_FALSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prefRecordingAdvanced_FALSE.Location = new System.Drawing.Point(0, 0);
            this.prefRecordingAdvanced_FALSE.Margin = new System.Windows.Forms.Padding(0);
            this.prefRecordingAdvanced_FALSE.Name = "prefRecordingAdvanced_FALSE";
            this.prefRecordingAdvanced_FALSE.Size = new System.Drawing.Size(103, 41);
            this.prefRecordingAdvanced_FALSE.TabIndex = 28;
            this.prefRecordingAdvanced_FALSE.TabStop = true;
            this.prefRecordingAdvanced_FALSE.Text = "OFF";
            this.prefRecordingAdvanced_FALSE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prefRecordingAdvanced_FALSE.UseVisualStyleBackColor = true;
            this.prefRecordingAdvanced_FALSE.CheckedChanged += new System.EventHandler(this.PrefRecordingAdvanced_CheckedChanged);
            // 
            // prefRecordingAdvanced_TRUE
            // 
            this.prefRecordingAdvanced_TRUE.Appearance = System.Windows.Forms.Appearance.Button;
            this.prefRecordingAdvanced_TRUE.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prefRecordingAdvanced_TRUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prefRecordingAdvanced_TRUE.FlatAppearance.BorderSize = 0;
            this.prefRecordingAdvanced_TRUE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.prefRecordingAdvanced_TRUE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prefRecordingAdvanced_TRUE.Location = new System.Drawing.Point(103, 0);
            this.prefRecordingAdvanced_TRUE.Margin = new System.Windows.Forms.Padding(0);
            this.prefRecordingAdvanced_TRUE.Name = "prefRecordingAdvanced_TRUE";
            this.prefRecordingAdvanced_TRUE.Size = new System.Drawing.Size(103, 41);
            this.prefRecordingAdvanced_TRUE.TabIndex = 27;
            this.prefRecordingAdvanced_TRUE.TabStop = true;
            this.prefRecordingAdvanced_TRUE.Text = "ON";
            this.prefRecordingAdvanced_TRUE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.prefRecordingAdvanced_TRUE.UseVisualStyleBackColor = true;
            this.prefRecordingAdvanced_TRUE.CheckedChanged += new System.EventHandler(this.PrefRecordingAdvanced_CheckedChanged);
            // 
            // RecordingAdvancedLbl
            // 
            this.RecordingAdvancedLbl.AutoSize = true;
            this.RecordingAdvancedLbl.Location = new System.Drawing.Point(957, 71);
            this.RecordingAdvancedLbl.Name = "RecordingAdvancedLbl";
            this.RecordingAdvancedLbl.Size = new System.Drawing.Size(104, 25);
            this.RecordingAdvancedLbl.TabIndex = 28;
            this.RecordingAdvancedLbl.Text = "Allow edit";
            this.RecordingAdvancedLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Preferences
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.RecordingAdvancedLbl);
            this.Controls.Add(this.prefRecordingAdvanced);
            this.Controls.Add(this.prefRecordingLocationErrorLbl);
            this.Controls.Add(this.prefRecordingLocationBtn);
            this.Controls.Add(this.prefRecordingLocation);
            this.Controls.Add(this.prefRecordingLocationLbl);
            this.Controls.Add(this.groupRecordingAdvanced);
            this.Controls.Add(this.prefRecordingDeviceLbl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.prefRecordingDevice);
            this.Name = "Preferences";
            this.Size = new System.Drawing.Size(1307, 555);
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.Enter += new System.EventHandler(this.Preferences_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Preferences_KeyDown);
            this.groupRecordingAdvanced.ResumeLayout(false);
            this.groupRecordingAdvanced.PerformLayout();
            this.prefRecordingAdvanced.ResumeLayout(false);
            this.prefRecordingAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox prefRecordingDevice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label prefRecordingDeviceLbl;
        private System.Windows.Forms.TextBox prefTempLocation;
        private System.Windows.Forms.GroupBox groupRecordingAdvanced;
        private System.Windows.Forms.Label prefRecordingRateLbl;
        private System.Windows.Forms.Label prefRecordingChannelsLbl;
        private System.Windows.Forms.Label prefRecordingDepthLbl;
        private System.Windows.Forms.Label prefTempLocationLbl;
        private System.Windows.Forms.Label prefRecordingLocationLbl;
        private System.Windows.Forms.FolderBrowserDialog prefTempLocationDlg;
        private System.Windows.Forms.Button prefTempLocationBtn;
        private System.Windows.Forms.FolderBrowserDialog prefRecordingLocationDlg;
        private System.Windows.Forms.Button prefRecordingLocationBtn;
        private System.Windows.Forms.TextBox prefRecordingLocation;
        private System.Windows.Forms.Label prefTempLocationErrorLbl;
        private System.Windows.Forms.Label prefRecordingLocationErrorLbl;
        private System.Windows.Forms.TableLayoutPanel prefRecordingAdvanced;
        private System.Windows.Forms.RadioButton prefRecordingAdvanced_FALSE;
        private System.Windows.Forms.RadioButton prefRecordingAdvanced_TRUE;
        private System.Windows.Forms.Label RecordingAdvancedLbl;
        private System.Windows.Forms.ComboBox prefRecordingChannels;
        private System.Windows.Forms.ComboBox prefRecordingDepth;
        private System.Windows.Forms.ComboBox prefRecordingRate;
    }
}
