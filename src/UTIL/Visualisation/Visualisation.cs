﻿/* 
 * https://stackoverflow.com/a/38944283
 */


using CSCore;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;
using CSCoreVisualiser;
using CSCore.DSP;
using CSCore.Streams;
using System;
using System.Diagnostics;

namespace CSCoreVisualiser
{
    public class SoundCapture
    {

        public int numBars = 30;

        public int minFreq = 5;
        public int maxFreq = 4500;
        public int barSpacing = 0;
        public bool logScale = true;
        public bool isAverage = false;

        public float highScaleAverage = 2.0f;
        public float highScaleNotAverage = 3.0f;



        LineSpectrum lineSpectrum;

        WasapiCapture capture;
        WaveWriter writer;
        FftSize fftSize;
        float[] fftBuffer;

        SingleBlockNotificationStream notificationSource;

        BasicSpectrumProvider spectrumProvider;

        IWaveSource finalSource;

        public SoundCapture()
        {

            // This uses the wasapi api to get any sound data played by the computer
            capture = new WasapiCapture();

            capture.Initialize();

            // Get our capture as a source
            IWaveSource source = new SoundInSource(capture);


            // From https://github.com/filoe/cscore/blob/master/Samples/WinformsVisualization/Form1.cs

            // This is the typical size, you can change this for higher detail as needed
            fftSize = FftSize.Fft4096;

            // Actual fft data
            fftBuffer = new float[(int) fftSize];

            // These are the actual classes that give you spectrum data
            // The specific vars of lineSpectrum here aren't that important because they can be changed by the user
            spectrumProvider = new BasicSpectrumProvider(capture.WaveFormat.Channels,
                capture.WaveFormat.SampleRate, fftSize);

            lineSpectrum = new LineSpectrum(fftSize)
            {
                SpectrumProvider = spectrumProvider,
                UseAverage = true,
                BarCount = numBars,
                BarSpacing = 2,
                IsXLogScale = false,
                ScalingStrategy = ScalingStrategy.Linear
            };

            // Tells us when data is available to send to our spectrum
            var notificationSource = new SingleBlockNotificationStream(source.ToSampleSource());

            notificationSource.SingleBlockRead += NotificationSource_SingleBlockRead;

            // We use this to request data so it actualy flows through (figuring this out took forever...)
            finalSource = notificationSource.ToWaveSource();

            capture.DataAvailable += Capture_DataAvailable;
            capture.Start();
        }

        private void Capture_DataAvailable(object sender, DataAvailableEventArgs e)
        {
            finalSource.Read(e.Data, e.Offset, e.ByteCount);
        }

        private void NotificationSource_SingleBlockRead(object sender, SingleBlockReadEventArgs e)
        {
            spectrumProvider.Add(e.Left, e.Right);
        }

        ~SoundCapture()
        {
            capture.Stop();
            capture.Dispose();
        }

        public float[] barData = new float[20];

        public float[] GetFFtData()
        {
            lock (barData)
            {
                lineSpectrum.BarCount = numBars;
                if (numBars != barData.Length)
                {
                    barData = new float[numBars];
                }
            }

            if (spectrumProvider.IsNewDataAvailable)
            {
                lineSpectrum.MinimumFrequency = minFreq;
                lineSpectrum.MaximumFrequency = maxFreq;
                lineSpectrum.IsXLogScale = logScale;
                lineSpectrum.BarSpacing = barSpacing;
                lineSpectrum.SpectrumProvider.GetFftData(fftBuffer, this);
                return lineSpectrum.GetSpectrumPoints(100.0f, fftBuffer);
            }
           
                return null;
            
        }

        public void ComputeData()
        {


            float[] resData = GetFFtData();

            int numBars = barData.Length;

            if (resData == null)
            {
                return;
            }

            lock (barData)
            {
                for (int i = 0; i < numBars && i < resData.Length; i++)
                {
                    barData[i] = resData[i] / 100.0f;
                    barData[i] = barData[i] + (lineSpectrum.UseAverage ? highScaleAverage : highScaleNotAverage) * (float)Math.Sqrt(i / (numBars + 0.0f)) *
                                 barData[i];
                }
                Debug.Print("LAST VALUE:" + barData[0].ToString());


            }

        }
    }
}