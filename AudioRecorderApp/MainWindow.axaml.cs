using Avalonia.Controls;
using Sermon_Record.UTIL;
using System;
using System.Diagnostics;

namespace AudioRecorderApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            var x = ComObjectGet();

            Debug.Print(x);
            //Recorder.Record();
        }

        public static dynamic ComObjectGet() {
            //const string progID = "CertificateAuthority.Admin";
            //Type foo = Type.GetTypeFromProgID(progID);

            var bar = Guid.Parse("37eabaf0-7fb6-11d0-8817-00a0c903b83c");
            Type foo = Type.GetTypeFromCLSID (bar);

            dynamic COMobject = Activator.CreateInstance(foo);
            return COMobject;
        }
    }
}