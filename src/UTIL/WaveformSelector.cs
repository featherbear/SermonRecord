/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using NAudio.Wave;
using NAudio.WaveFormRenderer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sermon_Record.UTIL
{
    public partial class WaveformSelector : UserControl
    {
        private readonly AveragePeakProvider averagePeakProvider;
        private readonly SoundCloudBlockWaveFormSettings soundCloudOrangeTransparentBlocks;
        private readonly Color topSpacerColor;
        private WaveFormRenderer renderer;
        private WaveFileReader reader;
        public float timeStart => (float)handleLeft.Left / imgWaveform.Width;
        public float timeEnd => (float)(handleRight.Left + handleRight.Width) / imgWaveform.Width;
        public Image image { get; private set; }
        public Image imageG { get; private set; }

        public WaveformSelector()
        {
            InitializeComponent();
            averagePeakProvider = new AveragePeakProvider(4);
            topSpacerColor = Color.FromArgb(64, 83, 22, 3);
            soundCloudOrangeTransparentBlocks = new SoundCloudBlockWaveFormSettings(Color.FromArgb(196, 197, 53, 0),
                topSpacerColor, Color.FromArgb(196, 79, 26, 0),
                Color.FromArgb(64, 79, 79, 79))
            {
                PixelsPerPeak = 2,
                Width = imgWaveform.Width,
                BottomHeight = Convert.ToInt32(0.2 * imgWaveform.Height),
                SpacerPixels = 1,
                TopHeight = Convert.ToInt32(0.7 * imgWaveform.Height),
                TopSpacerGradientStartColor = topSpacerColor,
                BackgroundColor = Color.Transparent
            };
        }



        public void Load(string filePath)
        {
            renderer = new WaveFormRenderer();
            image = renderer.Render(filePath, averagePeakProvider, soundCloudOrangeTransparentBlocks);
            imageG = ToolStripRenderer.CreateDisabledImage(image);
            reader = new WaveFileReader(filePath);
            handleLeft.Left = 0;
            handleRight.Left = imgWaveform.Width - handleRight.Width;
            originalDuration.Text = endTime.Text = formatTime(Convert.ToInt32(reader.TotalTime.TotalSeconds));
            UpdateImage();
        }

        public void UpdateImage()
        {
            imgWaveform.Image = createDisplayImage();
            // Also update the duration time
            newDuration.Text = formatTime(Convert.ToInt32((float)(handleRight.Left + handleRight.Width - handleLeft.Left) / imgWaveform.Width * reader.TotalTime.TotalSeconds));
        }

        private Image createDisplayImage()
        {
            var result = new Bitmap(imageG);
            var selectedRec = new Rectangle(handleLeft.Left, 0, handleRight.Left - handleLeft.Left + handleRight.Width,
                imageG.Height);

            using (var g = Graphics.FromImage(result))
            {
                g.SetClip(selectedRec);
                g.Clear(Color.Transparent);
                g.DrawImage(image, selectedRec, selectedRec, GraphicsUnit.Pixel);
            }
            return result;
        }

        private void handleLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && handleLeft.Left + handleLeft.Width + e.X <= handleRight.Left &&
                handleLeft.Left + e.X >= 0)
            {
                handleLeft.Left += e.X;
                startTime.Text = formatTime(Convert.ToInt32((float)handleLeft.Left / imgWaveform.Width * reader.TotalTime.TotalSeconds));
                UpdateImage();
            }
        }

        private void handleRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && handleRight.Left + e.X >= handleLeft.Left + handleLeft.Width &&
                handleRight.Left + handleRight.Width + e.X <= imgWaveform.Width)
            {
                handleRight.Left += e.X;
                endTime.Text = formatTime(Convert.ToInt32((float)(handleRight.Left + handleRight.Width) / imgWaveform.Width * reader.TotalTime.TotalSeconds));
                UpdateImage();
            }
        }

        private string formatTime(int s)
        {
            var hours = s / 3600;
            var minutes = s / 60;
            var seconds = s % 60;
            return $"{hours:#00}:{minutes:#00}:{seconds:#00}";
        }

        /*
         * DateTimePicker format:  HH'h' mm'm' ss's'
        private void startTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void endTime_ValueChanged(object sender, EventArgs e)
        {
        }

        private void startTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = startTime.Value.Subtract(startTime.Value.Date) >= endTime.Value.Subtract(endTime.Value.Date);
        }
        private void endTime_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var timespan = endTime.Value.Subtract(endTime.Value.Date);

            e.Cancel = timespan <= startTime.Value.Subtract(startTime.Value.Date) || timespan > reader.TotalTime;
        }
        */
    }
}
