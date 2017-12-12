namespace Sermon_Record
{
    partial class AppWindow
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
            this.viewSelector = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.main1 = new Sermon_Record.UI.Main();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.preferences1 = new Sermon_Record.UI.Preferences();
            this.viewSelector.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSelector
            // 
            this.viewSelector.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.viewSelector.Controls.Add(this.tabMain);
            this.viewSelector.Controls.Add(this.tabPreferences);
            this.viewSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewSelector.ItemSize = new System.Drawing.Size(0, 1);
            this.viewSelector.Location = new System.Drawing.Point(0, 0);
            this.viewSelector.Margin = new System.Windows.Forms.Padding(0);
            this.viewSelector.Name = "viewSelector";
            this.viewSelector.SelectedIndex = 0;
            this.viewSelector.Size = new System.Drawing.Size(1474, 555);
            this.viewSelector.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.viewSelector.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.main1);
            this.tabMain.Location = new System.Drawing.Point(4, 5);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(1466, 546);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "tabMain";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // main1
            // 
            this.main1.AutoSize = true;
            this.main1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main1.Location = new System.Drawing.Point(0, 0);
            this.main1.Name = "main1";
            this.main1.Size = new System.Drawing.Size(1466, 546);
            this.main1.TabIndex = 0;
            // 
            // tabPreferences
            // 
            this.tabPreferences.Controls.Add(this.preferences1);
            this.tabPreferences.Location = new System.Drawing.Point(4, 5);
            this.tabPreferences.Margin = new System.Windows.Forms.Padding(0);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Size = new System.Drawing.Size(1466, 475);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = "tabPreferences";
            this.tabPreferences.UseVisualStyleBackColor = true;
            // 
            // preferences1
            // 
            this.preferences1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferences1.Location = new System.Drawing.Point(0, 0);
            this.preferences1.Name = "preferences1";
            this.preferences1.Size = new System.Drawing.Size(1466, 520);
            this.preferences1.TabIndex = 0;
            // 
            // AppWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1474, 555);
            this.ControlBox = false;
            this.Controls.Add(this.viewSelector);
            this.Name = "AppWindow";
            this.Text = "Sermon Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppWindow_FormClosing);
            this.Load += new System.EventHandler(this.AppWindow_Load);
            this.viewSelector.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabPreferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl viewSelector;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPreferences;
        private UI.Main main1;
        private UI.Preferences preferences1;
 
    }
}