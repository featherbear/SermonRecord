/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Diagnostics;
using NAudio.Wave;

namespace Sermon_Record.UTIL
{
    internal static class AudioDevice
    {
        public static void Close()
        {
            if (IsOpen)
            {
                Recorder.Stop();

                waveIn.DataAvailable -= updatePeak;
                waveIn.StopRecording();
                waveIn.Dispose();

                IsOpen = false;
                Debug.Print("Audio device closed");
            }
        }

        public static bool Open()
        {
            if (IsOpen) Close();
            if (AppPreferences.RecordingDevice == "") return false;

            waveIn = new WaveIn
            {
                WaveFormat = AppPreferences.RecordingDepth == 16
                    ? new WaveFormat(AppPreferences.RecordingRate, AppPreferences.RecordingChannels)
                    : WaveFormat.CreateIeeeFloatWaveFormat(AppPreferences.RecordingRate,
                        AppPreferences.RecordingChannels)
            };

            waveIn.DataAvailable += updatePeak;
            waveIn.StartRecording();
            IsOpen = true;
            Debug.Print("Audio device opened");

            return true;
        }

        #region Declarations

        public static WaveIn waveIn;

        private static readonly EventHandler<WaveInEventArgs> updatePeak = (s, e) =>
        {
            float max = 0;
            switch (AppPreferences.RecordingDepth)
            {
                case 16:
                    for (var index = 0; index < e.BytesRecorded; index += 2)
                    {
                        var sample = (short) ((e.Buffer[index + 1] << 8) | e.Buffer[index + 0]) / 32768f;
                        if (sample < 0) sample = -sample;
                        if (sample > max) max = sample;
                    }
                    break;

                case 32:

                    var buffer = new WaveBuffer(e.Buffer);
                    // interpret as 32 bit floating point audio
                    for (var index = 0; index < e.BytesRecorded / 4; index++)
                    {
                        var sample = buffer.FloatBuffer[index];
                        if (sample < 0) sample = -sample;
                        if (sample > max) max = sample;
                    }

                    break;
            }
            PeakValue = max;
        };

        public static bool IsOpen { get; private set; }
        public static float PeakValue { get; private set; }
        public static double PeakValueDb => Math.Log10(PeakValue) * 20;

        #endregion Declarations
    }
}