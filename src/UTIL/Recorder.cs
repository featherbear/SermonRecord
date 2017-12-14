/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using NAudio.Wave;

namespace Sermon_Record.UTIL
{
    internal static class Recorder
    {
        #region Recorder

        public static DateTime StartTime;

        private static readonly EventHandler<WaveInEventArgs> writeEvent = (s, e) =>
        {
            writer.Write(e.Buffer, 0, e.BytesRecorded);
        };

        private static WaveFileWriter writer;
        public static bool IsRecording { get; private set; }
        public static string filePath => writer.Filename;
        public static long fileSize => writer.Position;
        public static string fileSizeF()
        {
            string[] suf = {"B", "KB", "MB", "GB", "TB", "PB", "EB"}; //Longs run out around EB
            if (fileSize == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(fileSize);
            var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            var num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return Math.Sign(fileSize) * num + suf[place];
        }

        #endregion Recorder

        #region Elapsed Time

        private static readonly Timer elapsedTimer = new Timer(1000);
        private static readonly ElapsedEventHandler elapsedEvent = (s, e) => { elapsedTime += 1; };
        public static int elapsedTime { get; private set; }

        public static string GetElapsedTimeFormatted()
        {
            var hours = elapsedTime / 60 / 60;
            var minutes = elapsedTime / 60;
            var seconds = elapsedTime % 60;
            return $"{hours:#00}:{minutes:#00}:{seconds:#00}";
        }

        #endregion Elapsed Time

        #region Recording Functions

        public static void Cancel()
        {
            if (IsRecording && Stop())
                File.Delete(filePath);
        }

        public static bool Record()
        {
            if (!AudioDevice.IsOpen) return false;
            StartTime = DateTime.UtcNow;

            writer = new WaveFileWriter(Path.Combine(AppPreferences.TempLocation, "sermonRecord_" +
                                                                                  (StartTime - new DateTime(1970, 1,
                                                                                       1, 0, 0, 0, DateTimeKind.Utc))
                                                                                  .TotalSeconds.ToString()
                                                                                  .Split('.')[0] +
                                                                                  ".wav"),
                AudioDevice.waveIn.WaveFormat);
            AudioDevice.waveIn.DataAvailable += writeEvent;

            elapsedTime = 1;
            elapsedTimer.Elapsed += elapsedEvent;
            elapsedTimer.Start();

            IsRecording = true;
            Debug.Print("Recording started");
            return true;
        }

        public static bool Stop()
        {
            if (IsRecording)
            {
                elapsedTimer.Elapsed -= elapsedEvent;
                elapsedTimer.Stop();

                AudioDevice.waveIn.DataAvailable -= writeEvent;
                Debug.Print("DISPOSE WRITER");
                //

                //OR Write IDv3 before data?
                //                writer.Write();
                //
                writer.Dispose();

                IsRecording = false;
                Debug.Print("Recording stopped");
                return true;
            }
            return false;
        }

        #endregion Recording Functions
    }
}