using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;

namespace Sermon_Record.UI
{
    public partial class Preferences : UserControl
    {
        private bool prefRecordingLocationError;
        private bool prefTempLocationError;

        public Preferences()
        {
            InitializeComponent();
            // Set the "radio button" style
            foreach (var btn in new[]
                {prefAlwaysOnTop_TRUE, prefAlwaysOnTop_FALSE, prefRecordingAdvanced_TRUE, prefRecordingAdvanced_FALSE})
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 197, 255);
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.CheckedBackColor =
                    Color.FromArgb(80, 157, 243);
                btn.BackColor = Color.FromArgb(186, 185, 186);
            }
        }

        private void Preferences_Enter(object sender, EventArgs e)
        {
            /*
             *  Update values of preference controls
             */
            prefRecordingDevice.Items.Clear();
            var mmdevenum = MMDeviceEnumerator.EnumerateDevices(DataFlow.Capture, DeviceState.Active);
            foreach (var device in WaveInDevice.EnumerateDevices())
                prefRecordingDevice.Items.Add(mmdevenum.First(a => a.FriendlyName.StartsWith(device.Name))
                    .FriendlyName);
            if (AppPreferences.AlwaysOnTop) prefAlwaysOnTop_TRUE.Checked = true;
            else prefAlwaysOnTop_FALSE.Checked = true;

            prefRecordingLocation.Text = AppPreferences.RecordingLocation;
            prefTempLocation.Text = AppPreferences.TempLocation;
            prefRecordingDevice.Text = AppPreferences.RecordingDevice;
            prefRecordingRate.Text = AppPreferences.RecordingRate.ToString();
            prefRecordingDepth.Text = AppPreferences.RecordingDepth.ToString();
            prefRecordingChannels.Text = AppPreferences.RecordingChannels.ToString();
            btnSave.Enabled = false;
        }

        private void completeName()
        {
            // new CSCore.Streams.Effects.EqualizerFilter() new CSCore.Streams.PeakMeter() // .reset
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // completeName();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!prefTempLocationError && !prefRecordingLocationError)
            {
                AppPreferences.AlwaysOnTop = ((AppWindow)ParentForm).TopMost = (bool)prefAlwaysOnTop.Tag;

                AppPreferences.RecordingLocation = prefRecordingLocation.Text;
                AppPreferences.TempLocation = prefTempLocation.Text;

                AppPreferences.RecordingDevice = prefRecordingDevice.Text;
                AppPreferences.RecordingRate = Convert.ToInt32(prefRecordingRate.Text);
                AppPreferences.RecordingDepth = Convert.ToInt32(prefRecordingDepth.Text);
                AppPreferences.RecordingChannels = Convert.ToInt32(prefRecordingChannels.Text);
                AppPreferences.Save();
                btnSave.Enabled = false;
                AudioDevice.Open();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((AppWindow)ParentForm).SwitchView();
        }

        private void changeMade(object sender, EventArgs e)
        {
            changeMade();
        }

        private void changeMade()
        {
            btnSave.Enabled = true;
        }

        private void prefRecordingLocationBtn_Click(object sender, EventArgs e)
        {
            var newPath = DialogHelper(prefRecordingLocationDlg);
            if (newPath != null) prefRecordingLocation.Text = newPath;
        }

        private string DialogHelper(FolderBrowserDialog dialog)
        {
            switch (dialog.ShowDialog())
            {
                case
                DialogResult.OK:
                    return dialog.SelectedPath;

                default:
                    return null;
            }
        }

        private void prefTempLocationBtn_Click(object sender, EventArgs e)
        {
            var newPath = DialogHelper(prefTempLocationDlg);
            if (newPath != null) prefTempLocation.Text = newPath;
        }

        private bool LocationValidationHelper(string path)
        {
            if (!Directory.Exists(path)) return false;

            var Allow = false;
            var Deny = false;

            var acl = Directory.GetAccessControl(path);
            if (acl == null)
                return false;
            var arc =
                acl.GetAccessRules(true, true, typeof(SecurityIdentifier));
            if (arc == null)
                return false;
            foreach (FileSystemAccessRule rule in arc)
            {
                if ((FileSystemRights.Write & rule.FileSystemRights) != FileSystemRights.Write)
                    continue;
                if (rule.AccessControlType == AccessControlType.Allow)
                    Allow = true;
                else if (rule.AccessControlType == AccessControlType.Deny)
                    Deny = true;
            }
            return Allow && !Deny;
        }

        private void prefTempLocation_TextChanged(object sender, EventArgs e)
        {
            prefTempLocationError = prefTempLocationErrorLbl.Visible = !LocationValidationHelper(prefTempLocation.Text);
        }

        private void prefRecordingLocation_TextChanged(object sender, EventArgs e)
        {
            prefRecordingLocationError = prefRecordingLocationErrorLbl.Visible =
                !LocationValidationHelper(prefRecordingLocation.Text);
        }

        private void prefRecordingAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            groupRecordingAdvanced.Enabled = prefRecordingAdvanced_TRUE.Checked;
        }

        private void prefAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            prefAlwaysOnTop.Tag = prefAlwaysOnTop_TRUE.Checked;
            changeMade();
        }

        private void prefRecordingDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            prefRecordingAdvanced_FALSE.Checked = true;
        }
    }
}