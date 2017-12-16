/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using Sermon_Record.UTIL;

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
                {prefRecordingAdvanced_TRUE, prefRecordingAdvanced_FALSE})
            {
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 197, 255);
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.CheckedBackColor =
                    Color.FromArgb(80, 157, 243);
                btn.BackColor = Color.FromArgb(186, 185, 186);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ((AppWindow) ParentForm).SwitchView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!prefTempLocationError && !prefRecordingLocationError)
            {
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

        private void changeMade(object sender, EventArgs e)
        {
            changeMade();
        }

        private void changeMade()
        {
            btnSave.Enabled = true;
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

        private void Preferences_Enter(object sender, EventArgs e)
        {
            /*
             *  Update values of preference controls
             */
            prefRecordingDevice.Items.Clear();
            var devices = new List<string>();

            new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList().ForEach(
                d => { devices.Add(d.FriendlyName); });

            for (var i = 0; i < WaveIn.DeviceCount; i++)
                prefRecordingDevice.Items.Add(
                    devices.First(dev => dev.StartsWith(WaveIn.GetCapabilities(i).ProductName)));

            prefRecordingLocation.Text = AppPreferences.RecordingLocation;
            prefTempLocation.Text = AppPreferences.TempLocation;
            prefRecordingDevice.Text = AppPreferences.RecordingDevice;
            prefRecordingRate.Text = AppPreferences.RecordingRate.ToString();
            prefRecordingDepth.Text = AppPreferences.RecordingDepth.ToString();
            prefRecordingChannels.Text = AppPreferences.RecordingChannels.ToString();
            btnSave.Enabled = false;
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            prefRecordingAdvanced_FALSE.Checked = true;
        }

        private void prefRecordingAdvanced_CheckedChanged(object sender, EventArgs e)
        {
            groupRecordingAdvanced.Enabled = prefRecordingAdvanced_TRUE.Checked;
        }

        private void Preferences_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnBack_Click(sender, e);
        }

        private void prefRecordingLocation_TextChanged(object sender, EventArgs e)
        {
            prefRecordingLocationError = prefRecordingLocationErrorLbl.Visible =
                !LocationValidationHelper(prefRecordingLocation.Text);
            changeMade();
        }

        private void prefRecordingLocationBtn_Click(object sender, EventArgs e)
        {
            var newPath = DialogHelper(prefRecordingLocationDlg);
            if (newPath != null) prefRecordingLocation.Text = newPath;
        }

        private void prefTempLocation_TextChanged(object sender, EventArgs e)
        {
            prefTempLocationError = prefTempLocationErrorLbl.Visible = !LocationValidationHelper(prefTempLocation.Text);
            changeMade();
        }

        private void prefTempLocationBtn_Click(object sender, EventArgs e)
        {
            var newPath = DialogHelper(prefTempLocationDlg);
            if (newPath != null) prefTempLocation.Text = newPath;
        }
    }
}