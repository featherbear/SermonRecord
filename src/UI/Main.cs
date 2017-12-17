/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using Sermon_Record.UTIL;

namespace Sermon_Record.UI
{
    public partial class Main : UserControl
    {
        private readonly string TitlePartRecording = " [RECORDING]";

        public Main()
        {
            InitializeComponent();
        }

        private void RecordStartStop_Click(object sender, EventArgs e)
        {
            if (Recorder.IsRecording)
            {
                Recorder.Stop();
                fileSizeTimer.Stop();
                elapsedTimeTimer.Stop();
                btnPreferences.Enabled = true;
                TaskbarManager.Instance.SetProgressValue(0, 1);
                ((AppWindow) ParentForm).Text = ((AppWindow) ParentForm).Text.Replace(TitlePartRecording, "");
                btnRecord.Text = "START";
                new PostRecord();
                fileSize.Visible = false;
                lblFileSize.Visible = false;
            }
            //else if (ModifierKeys == Keys.Shift)
            //{
            //}
            else if (Recorder.Record())
            {
                fileSize.Visible = true;
                lblFileSize.Visible = true;
                fileSizeTimer.Start();
                elapsedTimeTimer.Start();
                fileSizeTimer.Start();
                FileSizeTimer_Tick(null, null);
                btnPreferences.Enabled = false;

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                TaskbarManager.Instance.SetProgressValue(1, 1);

                ((AppWindow) ParentForm).Text += TitlePartRecording;

                btnRecord.Text = @"STOP";
            }
        }

        private void BtnPreferences_Click(object sender, EventArgs e)
        {
            ((AppWindow) ParentForm).SwitchView();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ElapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            if (Recorder.IsRecording) elapsedTimeLbl.Text = Recorder.GetElapsedTimeFormatted();
        }

        private void SoundMeterTTimer_Tick(object sender, EventArgs e)
        {
            if (AudioDevice.IsOpen)
                soundMeterT.Text = (AudioDevice.PeakValue > 0
                                       ? Convert.ToInt32(AudioDevice.PeakValueDb).ToString()
                                       : "-inf") + " dB";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            AudioDevice.Open();
        }

        private void SoundMeterGTimer_Tick(object sender, EventArgs e)

        {
            if (AudioDevice.IsOpen)
            {
                var val = Math.Max(0,
                    Math.Min(soundMeterG.Maximum, soundMeterG.Maximum + (int) AudioDevice.PeakValueDb));
                soundMeterG.SetProgressNoAnimation(val);
                if (val > 60) soundMeterG.SetState(2);
                else if (val > 50) soundMeterG.SetState(3);
                else soundMeterG.SetState(1);
            }
        }

        private void FileSizeTimer_Tick(object sender, EventArgs e)
        {
            if (Recorder.IsRecording) fileSize.Text = Recorder.FileSizeF();
        }
    }
}