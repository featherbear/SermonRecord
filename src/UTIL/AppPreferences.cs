using System;
using System.IO;
using Microsoft.Win32;

namespace Sermon_Record
{
    internal static class AppPreferences

    {
        private static readonly RegistryKey Registry =
            Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\featherbear\\Sermon Record");

        public static bool AlwaysOnTop = Convert.ToBoolean(Registry.GetValue("AlwaysOnTop", false));
        public static string TempLocation = Convert.ToString(Registry.GetValue("TempLocation", Path.GetTempPath()));
        public static int RecordingRate = Convert.ToInt32(Registry.GetValue("RecordingRate", 44800));
        public static int RecordingDepth = Convert.ToInt32(Registry.GetValue("RecordingDepth", 32));
        public static int RecordingChannels = Convert.ToInt32(Registry.GetValue("RecordingChannels", 1));
        public static string RecordingDevice = Convert.ToString(Registry.GetValue("RecordingDevice", ""));

        public static string RecordingLocation = Convert.ToString(Registry.GetValue("RecordingLocation",
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)));

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
                Registry.SetValue("AlwaysOnTop", AlwaysOnTop);
                Registry.SetValue("TempLocation", TempLocation);
                Registry.SetValue("RecordingRate", RecordingRate);
                Registry.SetValue("RecordingDepth", RecordingDepth);
                Registry.SetValue("RecordingChannels", RecordingChannels);
                Registry.SetValue("RecordingDevice", RecordingDevice);
                Registry.SetValue("RecordingLocation", RecordingLocation);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}