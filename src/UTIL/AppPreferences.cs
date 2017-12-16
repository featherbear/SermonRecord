/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using Microsoft.Win32;
using System;
using System.IO;

namespace Sermon_Record.UTIL
{
    internal static class AppPreferences

    {
        private static readonly RegistryKey _reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\featherbear\\Sermon Record");

        public static int RecordingChannels = Convert.ToInt32(_reg.GetValue("RecordingChannels", 1));

        public static int RecordingDepth = Convert.ToInt32(_reg.GetValue("RecordingDepth", 32));

        public static string RecordingDevice = Convert.ToString(_reg.GetValue("RecordingDevice", ""));

        public static string RecordingLocation = Convert.ToString(_reg.GetValue("RecordingLocation",
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

        public static int RecordingRate = Convert.ToInt32(_reg.GetValue("RecordingRate", 48000));

        public static string TempLocation = Convert.ToString(_reg.GetValue("TempLocation", Path.GetTempPath()));

        /*
         * Don't need a loading function if the Registry is only read once (when application starts)
        public static void load()
        {
        }
        */

        public static bool Save()
        {
            try
            {
                _reg.SetValue("TempLocation", TempLocation);
                _reg.SetValue("RecordingRate", RecordingRate);
                _reg.SetValue("RecordingDepth", RecordingDepth);
                _reg.SetValue("RecordingChannels", RecordingChannels);
                _reg.SetValue("RecordingDevice", RecordingDevice);
                _reg.SetValue("RecordingLocation", RecordingLocation);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
