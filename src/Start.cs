using System;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace Sermon_Record
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // Dispose any old versions //

            /*
             * if (DateTime.Now - (DateTime)null > new DateTime().AddMonths(1))
                File.Delete(null);

                AppPreferences.TempLocation
        */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppWindow());
        }
    }
}