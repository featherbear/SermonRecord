/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using NAudio.MediaFoundation;
using NAudio.Wave;
using Sermon_Record.UTIL;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Sermon_Record.UI;

namespace Sermon_Record
{
    public partial class AppWindow : Form
    {
        public AppWindow()
        {
            InitializeComponent();
        }

        public void SwitchView()
        {
            viewSelector.SelectedIndex = viewSelector.SelectedIndex == 1 ? 0 : 1;
            viewSelector.SelectedTab.Focus();
        }

        private void AppWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Recorder.IsRecording)
                switch (MessageBox.Show("Recording not saved. Discard?", "Recording in progress!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;

                    case DialogResult.OK:
                        Recorder.Cancel();
                        break;
                }
            AudioDevice.Close();
        }

        private void AppWindow_Load(object sender, EventArgs e)
        {
            if (AppPreferences.RecordingDevice == "") SwitchView();

            if (!MediaFoundationEncoder.GetOutputMediaTypes(AudioSubtypes.MFAudioFormat_MP3).Any())
            {
                MessageBox.Show("The current platform does not support mp3 encoding.\nApplication will close.");
                Application.Exit();
            }
        }
    }
}
