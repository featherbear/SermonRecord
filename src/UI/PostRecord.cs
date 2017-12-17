/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using NAudio.Lame;
using NAudio.Wave;
using Sermon_Record.UTIL;

namespace Sermon_Record.UI
{
    public partial class PostRecord : Form
    {
        private bool _usingCustomPath;

        public PostRecord()
        {
            InitializeComponent();
            waveform.LoadFile(Recorder.FilePath);
            UpdatePath();

            ShowDialog();
        }

        public void UpdatePath()
        {
            if (!_usingCustomPath)
            {
                var service = _service.Text.Trim();
                service = service.Length > 0 ? " - " + service : "";
                var series = _series.Text.Trim();
                series = series.Length > 0 ? " - " + series : "";

                var title = _title.Text.Trim();
                title = title.Length > 0 ? " - " + title : "";

                var speaker = _speaker.Text.Trim();
                speaker = speaker.Length > 0 ? " - " + speaker : "";

                saveLocation.Text = Path.Combine(AppPreferences.RecordingLocation,
                    $"{Recorder.StartTime.Year:#0000}{Recorder.StartTime.Month:#00}{Recorder.StartTime.Day:#00}{service}{series}{title}{speaker}.mp3");
            }
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(1, 1);
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            if (MessageBox.Show("Are you sure you wish to discard the recording?", "WARNING", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
            TaskbarManager.Instance.SetProgressValue(0, 1);
        }

        private void SaveLocationBtn_Click(object sender, EventArgs e)
        {
            saveLocationDlg.FileName = Path.GetFileNameWithoutExtension(saveLocation.Text);
            if (saveLocationDlg.ShowDialog() == DialogResult.OK)
            {
                _usingCustomPath = true;
                saveLocation.Text = saveLocationDlg.FileName;
            }
        }

        private void TextUpdated(object sender, EventArgs e)
        {
            UpdatePath();
        }

        private void PostRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) BtnDiscard_Click(sender, e);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!_usingCustomPath && File.Exists(saveLocation.Text) &&
                MessageBox.Show("A file with the same name exists, overwrite?", "File exists", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            btnSave.Enabled = false;
            var tag = new ID3TagData
            {
                Title = _title.Text.Trim(),
                Artist = _speaker.Text.Trim(),
                Album = _series.Text.Trim(),
                Year = $"{Recorder.StartTime.Year:#0000}{Recorder.StartTime.Month:#00}{Recorder.StartTime.Day:#00}",
                Comment = _passage.Text,
                AlbumArtist = _service.Text.Trim(),
                Genre = "swec.org.au"
            };

            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            TaskbarManager.Instance.SetProgressValue(0, 1);

            using (var inputWave = new WaveFileReader(Recorder.FilePath))
            using (var compressor = new SimpleCompressorStream(inputWave)
            {
                Attack = (float) 1.5,
                Enabled = true,
                Threshold = 10,
                Ratio = 4,
                MakeUpGain = -3
            })
            using (var writer = new LameMP3FileWriter(saveLocation.Text + ".compressed.mp3", inputWave.WaveFormat,
                LAMEPreset.MEDIUM,
                tag))
            {
                writer.MinProgressTime = 0;
                writer.OnProgress += (w, i, o, f) =>
                {
                    if (f) Close();
                    else UpdateProgressBar(i, inputWave.Length);
                };

                var bytesPerMillisecond = inputWave.WaveFormat.AverageBytesPerSecond / 1000;

                var startPos = (int) waveform.TimeStart.TotalMilliseconds * bytesPerMillisecond;

                var endBytes = (int) waveform.TimeEnd.TotalMilliseconds * bytesPerMillisecond;
                endBytes = endBytes - endBytes % inputWave.WaveFormat.BlockAlign;
                var endPos = (int) inputWave.Length - endBytes;

                inputWave.Position = startPos - startPos % inputWave.WaveFormat.BlockAlign;
                var buffer = new byte[1024];
                while (inputWave.Position < endPos)
                {
                    var bytesRequired = (int) (endPos - inputWave.Position);
                    if (bytesRequired > 0)
                    {
                        var bytesToRead = Math.Min(bytesRequired, buffer.Length);
                        var bytesRead = compressor.Read(buffer, 0, bytesToRead);
                        if (bytesRead > 0)
                            writer.Write(buffer, 0, bytesRead);
                    }
                }
            }
            using (var inputWave = new WaveFileReader(Recorder.FilePath))
            using (var writer = new LameMP3FileWriter(saveLocation.Text, inputWave.WaveFormat, LAMEPreset.MEDIUM,
                tag))
            {
                inputWave.CopyTo(writer);
            }
        }

        private void UpdateProgressBar(long inputBytes, long length)
        {
            TaskbarManager.Instance.SetProgressValue(Convert.ToInt32(inputBytes / length * 100), 100);
        }

        private void PostRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(0, 1);
        }
    }
}