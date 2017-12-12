using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using CSCore.Codecs.WAV;
using CSCore.SoundIn;
using CSCoreVisualiser;

namespace Sermon_Record
{
    internal static class Recorder
    {
        private static WaveWriter writer;
        public static string filePath;
        private static byte[] writeEventBuffer;
        public static SoundCapture a = new SoundCapture();


        private static readonly EventHandler<DataAvailableEventArgs> writeEvent = (s, e) =>
        {
            var read = AudioDevice.compressorStream.Read(writeEventBuffer, 0, writeEventBuffer.Length);
            //var read = AudioDevice.soundInSource.Read(writeEventBuffer, 0, writeEventBuffer.Length);
            writer.Write(writeEventBuffer, 0, read);
            };

        private static readonly ElapsedEventHandler elapsedEvent = (s, e) => { elapsedTime += 1; };

        private static readonly Timer elapsedTimer = new Timer(1000);

        private static int elapsedTime = 1;
        public static DateTime StartTime;

        public static bool IsRecording { get; private set; }

        public static string GetElapsedTimeFormatted()
        {
            var hours = elapsedTime / 60 / 60;
            var minutes = elapsedTime / 60;
            var seconds = elapsedTime % 60;
            return string.Format("{0:#00}:{1:#00}:{2:#00}", hours, minutes, seconds);
        }

        public static int GetElapsedTime()
        {
            return elapsedTime;
        }

        public static bool Stop()
        {
            if (IsRecording)
            {
                elapsedTimer.Elapsed -= elapsedEvent;

                elapsedTimer.Stop();
                elapsedTime = 1;
                AudioDevice.soundInSource.DataAvailable -= writeEvent;



                Debug.Print("DISPOSE WRITER");
                writer.Dispose();

                //writeEventBuffer = new byte[AudioDevice.soundInSource.WaveFormat.BytesPerSecond];
                writeEventBuffer = new byte[AudioDevice.compressorStream.InputFormat.BytesPerSecond];

                IsRecording = false;
                Debug.Print("Recording stopped");
                return true;
            }
            return false;
        }

        public static void Cancel()
        {
            if (IsRecording && Stop())
                File.Delete(filePath);
        }

        public static void Waveform()
        {


        }
        public static bool Record()
        {
            Waveform();
            if (!AudioDevice.IsOpen) return false;
            
                StartTime = DateTime.UtcNow;
                filePath = Path.Combine(AppPreferences.TempLocation, "sermonRecord_" +
                                                                     (StartTime - new DateTime(1970, 1,
                                                                          1, 0, 0, 0, DateTimeKind.Utc))
                                                                     .TotalSeconds.ToString().Split('.')[0] +
                                                                     ".wav");

            writer = new WaveWriter(filePath, AudioDevice.compressorStream.InputFormat);
            writeEventBuffer = new byte[AudioDevice.compressorStream.InputFormat.BytesPerSecond];
            
            AudioDevice.soundInSource.DataAvailable += writeEvent;
                elapsedTimer.Elapsed += elapsedEvent;
                elapsedTimer.Start();
                IsRecording = true;
                Debug.Print("Recording started");
                return true;
            }
    }
}