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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
            this.viewSelector = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.main = new Sermon_Record.UI.Main();
            this.tabPreferences = new System.Windows.Forms.TabPage();
            this.preferences = new Sermon_Record.UI.Preferences();
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
            this.viewSelector.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.viewSelector.Location = new System.Drawing.Point(0, -36);
            this.viewSelector.Margin = new System.Windows.Forms.Padding(0);
            this.viewSelector.Name = "viewSelector";
            this.viewSelector.Padding = new System.Drawing.Point(0, 0);
            this.viewSelector.SelectedIndex = 0;
            this.viewSelector.Size = new System.Drawing.Size(1322, 578);
            this.viewSelector.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.viewSelector.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.main);
            this.tabMain.Location = new System.Drawing.Point(4, 37);
            this.tabMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(1314, 537);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "tabMain";
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.White;
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Margin = new System.Windows.Forms.Padding(0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(1314, 537);
            this.main.TabIndex = 0;
            // 
            // tabPreferences
            // 
            this.tabPreferences.BackColor = System.Drawing.Color.White;
            this.tabPreferences.Controls.Add(this.preferences);
            this.tabPreferences.Location = new System.Drawing.Point(4, 37);
            this.tabPreferences.Margin = new System.Windows.Forms.Padding(0);
            this.tabPreferences.Name = "tabPreferences";
            this.tabPreferences.Size = new System.Drawing.Size(1314, 537);
            this.tabPreferences.TabIndex = 1;
            this.tabPreferences.Text = "tabPreferences";
            // 
            // preferences
            // 
            this.preferences.BackColor = System.Drawing.Color.White;
            this.preferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferences.Location = new System.Drawing.Point(0, 0);
            this.preferences.Name = "preferences";
            this.preferences.Size = new System.Drawing.Size(1314, 537);
            this.preferences.TabIndex = 0;
            // 
            // AppWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1322, 538);
            this.ControlBox = false;
            this.Controls.Add(this.viewSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppWindow";
            this.Text = "Sermon Record";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppWindow_FormClosing);
            this.Load += new System.EventHandler(this.AppWindow_Load);
            this.viewSelector.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabPreferences.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabPreferences;
        private UI.Main main;
        private UI.Preferences preferences;
        private System.Windows.Forms.TabControl viewSelector;
    }
}