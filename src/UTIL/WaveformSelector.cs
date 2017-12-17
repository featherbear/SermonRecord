/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.WaveFormRenderer;

namespace Sermon_Record.UTIL
{
    public partial class WaveformSelector : UserControl
    {
        private readonly AveragePeakProvider averagePeakProvider;
        private readonly SoundCloudBlockWaveFormSettings soundCloudOrangeTransparentBlocks;
        private readonly Color topSpacerColor;
        private WaveFileReader reader;
        private WaveFormRenderer renderer;

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

        public TimeSpan TimeStart => TimeSpan.FromMilliseconds((float) handleLeft.Left / imgWaveform.Width *
                                                               reader.TotalTime.TotalMilliseconds);

        public TimeSpan TimeEnd => TimeSpan.FromMilliseconds(
            (float) (imgWaveform.Width - handleRight.Left + handleRight.Width) / imgWaveform.Width
            * reader.TotalTime.TotalMilliseconds);

        public Image Image { get; private set; }
        public Image ImageG { get; private set; }

        public void LoadFile(string filePath)
        {
            renderer = new WaveFormRenderer();
            Image = renderer.Render(filePath, averagePeakProvider, soundCloudOrangeTransparentBlocks);
            ImageG = ToolStripRenderer.CreateDisabledImage(Image);
            reader = new WaveFileReader(filePath);
            handleLeft.Left = 0;
            handleRight.Left = imgWaveform.Width - handleRight.Width;
            originalDuration.Text = endTime.Text = FormatTime(reader.TotalTime.TotalMilliseconds);
            UpdateImage();
        }

        public void UpdateImage()
        {
            imgWaveform.Image = CreateDisplayImage();
            // Also update the duration time
            newDuration.Text = FormatTime((float) (handleRight.Left + handleRight.Width - handleLeft.Left) /
                                          imgWaveform.Width * reader.TotalTime.TotalMilliseconds);
        }

        private Image CreateDisplayImage()
        {
            var result = new Bitmap(ImageG);
            var selectedRec = new Rectangle(handleLeft.Left, 0, handleRight.Left - handleLeft.Left + handleRight.Width,
                ImageG.Height);

            using (var g = Graphics.FromImage(result))
            {
                g.SetClip(selectedRec);
                g.Clear(Color.Transparent);
                g.DrawImage(Image, selectedRec, selectedRec, GraphicsUnit.Pixel);
            }
            return result;
        }

        private void HandleLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (handleLeft.Left + handleLeft.Width + e.X > handleRight.Left)
                    handleLeft.Left = handleRight.Left - handleLeft.Width;
                else if (handleLeft.Left + e.X < 0) handleLeft.Left = 0;
                else
                    handleLeft.Left += e.X;
                startTime.Text =
                    FormatTime((float) handleLeft.Left / imgWaveform.Width * reader.TotalTime.TotalMilliseconds);
                UpdateImage();
            }
        }

        private void HandleRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (handleRight.Left + e.X < handleLeft.Left + handleLeft.Width)
                    handleRight.Left = handleLeft.Left + handleLeft.Width;
                else if (handleRight.Left + handleRight.Width + e.X > imgWaveform.Width)
                    handleRight.Left = imgWaveform.Width - handleRight.Width;
                else
                    handleRight.Left += e.X;
                endTime.Text = FormatTime((float) (handleRight.Left + handleRight.Width) / imgWaveform.Width *
                                          reader.TotalTime.TotalMilliseconds);
                UpdateImage();
            }
        }

        private string FormatTime(TimeSpan ts)
        {
            return $"{ts.Hours:#00}:{ts.Minutes:#00}:{ts.Seconds:#00}.{ts.Milliseconds:#000}";
        }

        private string FormatTime(double ms)
        {
            return FormatTime(TimeSpan.FromMilliseconds(ms));
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