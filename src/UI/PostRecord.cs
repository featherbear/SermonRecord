/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;
using NAudio.Lame;
using NAudio.Wave;
using NAudio.WaveFormRenderer;
using Sermon_Record.UTIL;

namespace Sermon_Record.UI
{
    public partial class PostRecord : Form
    {
        private bool usingCustomPath;

        public PostRecord()
        {
            InitializeComponent();
            waveform.Load(Recorder.filePath);
            UpdatePath();

            ShowDialog();
        }

        public void UpdatePath()
        {
            if (!usingCustomPath)
                saveLocation.Text = Path.Combine(AppPreferences.RecordingLocation,
                    $"{Recorder.StartTime.Year:#0000}{Recorder.StartTime.Month:#00}{Recorder.StartTime.Day:#00} - 'CHURCH PLANT' - {_series.Text} - {_title.Text} - {_speaker.Text}.mp3");
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(1, 1);
            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            if (MessageBox.Show("Are you sure you wish to discard the recording?", "WARNING", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes) Close();
            TaskbarManager.Instance.SetProgressValue(0, 1);
        }

        private void PostRecord_Load(object sender, EventArgs e)
        {
            /*
             Time slider

            Default everything
            Click-drag inside: Moves selection
            Clicking on a point outside the area: No effect
            Dragging handle: Change min/max point
             */
        }

        private void saveLocationBtn_Click(object sender, EventArgs e)
        {
            saveLocationDlg.FileName = Path.GetFileNameWithoutExtension(saveLocation.Text);
            if (saveLocationDlg.ShowDialog() == DialogResult.OK)
            {
                usingCustomPath = true;
                saveLocation.Text = saveLocationDlg.FileName;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            UpdatePath();
        }

        private void PostRecord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) btnDiscard_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!usingCustomPath && File.Exists(saveLocation.Text) &&
                MessageBox.Show("A file with the same name exists, overwrite?", "File exists", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            btnSave.Enabled = false;
            var tag = new ID3TagData
            {
                Title = _title.Text,
                Artist = _speaker.Text,
                Album = _series.Text,
                Year = $"{Recorder.StartTime.Year:#0000}{Recorder.StartTime.Month:#00}{Recorder.StartTime.Day:#00}",
                Comment = _passage.Text,
                AlbumArtist = "CHURCH PLANT",
                Genre = "swec.org.au"
            };

            TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
            TaskbarManager.Instance.SetProgressValue(0, 1);

            using (var inputWave = new WaveFileReader(Recorder.filePath))
            using (var compressor = new SimpleCompressorStream(inputWave) {Attack = (float) 1.5, Enabled = true, Threshold = 10 ,Ratio = 4,MakeUpGain = -3})
            using (var writer = new LameMP3FileWriter(saveLocation.Text+".compressed.mp3", inputWave.WaveFormat, LAMEPreset.STANDARD,
                tag))
            {
                writer.MinProgressTime = 0;
                writer.OnProgress += (w, i, o, f) =>
                {
                    if (f) Close();
                    else updateProgressBar(i, inputWave.Length);
                };


                Debug.Print(waveform.timeStart.TotalMilliseconds.ToString());

                Debug.Print(waveform.timeEnd.TotalMilliseconds.ToString());
                int bytesPerMillisecond = inputWave.WaveFormat.AverageBytesPerSecond / 1000;

                int startPos = (int)waveform.timeStart.TotalMilliseconds * bytesPerMillisecond;

                int endBytes = (int)waveform.timeEnd.TotalMilliseconds * bytesPerMillisecond;
                endBytes = endBytes - endBytes % inputWave.WaveFormat.BlockAlign;
                int endPos = (int)inputWave.Length - endBytes;


                inputWave.Position = startPos - startPos % inputWave.WaveFormat.BlockAlign; 
                byte[] buffer = new byte[1024];
                while (inputWave.Position < endPos)
                {
                    int bytesRequired = (int)(endPos - inputWave.Position);
                    if (bytesRequired > 0)
                    {
                        int bytesToRead = Math.Min(bytesRequired, buffer.Length);
                        int bytesRead = compressor.Read(buffer, 0, bytesToRead);
                        if (bytesRead > 0)
                        {
                            writer.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            using (var inputWave = new WaveFileReader(Recorder.filePath))
            using (var writer = new LameMP3FileWriter(saveLocation.Text + ".clean.mp3", inputWave.WaveFormat,
                LAMEPreset.STANDARD, tag))
            {
                inputWave.CopyTo(writer);
            }
        }

        private void updateProgressBar(long inputBytes, long length)
        {
            TaskbarManager.Instance.SetProgressValue(Convert.ToInt32(inputBytes / length * 100), 100);
        }

        private void PostRecord_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(0, 1);
        }




    }
}