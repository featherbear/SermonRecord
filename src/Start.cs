/*
 * Sermon Record
 * Copyright 2017 Andrew Wong <featherbear@navhaxs.au.eu.org>
 *
 * The following code is licensed under the MIT License
 */

using System;
using System.Windows.Forms;

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
