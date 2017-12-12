using System;
using System.Diagnostics;
using System.Linq;
using CSCore;
using CSCore.Codecs;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;

namespace Sermon_Record
{
    internal static class AudioDevice
    {
        public static WaveIn waveIn;
        public static SoundInSource soundInSource;
        public static CSCore.Streams.Effects.DmoCompressorEffect compressorStream;
        private static AudioMeterInformation audioMeter;
        public static bool IsOpen { get; private set; }
        public static float PeakValueLin => audioMeter.PeakValue;
        public static double PeakValueLog => Math.Abs(10 * Math.Log(audioMeter.PeakValue * 100, 2));

        public static int PeakValueDb => Convert.ToInt32(Math.Max(Math.Max(0, PeakValueLog),
            Math.Min(100, PeakValueLog)));

        public static bool Open()
        {
            if (IsOpen) Close();

            if (AppPreferences.RecordingDevice == "") return false;

            waveIn = new WaveIn(new WaveFormat(AppPreferences.RecordingRate, AppPreferences.RecordingDepth,
                AppPreferences.RecordingChannels))
            {
                Device = WaveInDevice.EnumerateDevices()
                    .First(a => AppPreferences.RecordingDevice.StartsWith(a.Name))
            };
            // use wasapi?

            waveIn.Initialize();
            soundInSource = new SoundInSource(waveIn);
            waveIn.Start();
            
            compressorStream = new CSCore.Streams.Effects.DmoCompressorEffect(soundInSource.ToSampleSource().ToWaveSource())
            {
                Attack = (float)0.05
            };
            audioMeter = AudioMeterInformation.FromDevice(MMDeviceEnumerator
                .EnumerateDevices(DataFlow.Capture, DeviceState.Active)
                .First(a => a.FriendlyName == AppPreferences.RecordingDevice));
            IsOpen = true;
            Debug.Print("Audio device opened");
            return true;
        }

        public static void Close()
        {
            if (IsOpen)
            {
                Recorder.Stop();
                audioMeter.Dispose();
                compressorStream.Dispose();
                soundInSource.Dispose();
                
                waveIn.Stop();
                // AUDIO MOD HERE //
                waveIn.Dispose();
                IsOpen = false;
                Debug.Print("Audio device closed");
            }
        }
    }
}