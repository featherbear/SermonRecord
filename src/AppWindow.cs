using System;
using System.Linq;
using System.Windows.Forms;
using CSCore;
using CSCore.MediaFoundation;

namespace Sermon_Record
{
    public partial class AppWindow : Form
    {
        public AppWindow()
        {
            InitializeComponent();
        }

        public void SwitchView()
        {
            viewSelector.SelectedIndex = viewSelector.SelectedIndex == 1 ? 0 : 1;
            viewSelector.SelectedTab.Focus();
        }

        private void AppWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Recorder.IsRecording)
                switch (MessageBox.Show("Save recording before exiting?", "Recording in progress!",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3))
                {
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;

                    case DialogResult.No:
                        Recorder.Cancel();
                        break;

                    case DialogResult.Yes:
                        Recorder.Stop();
                        //PostRecord
                        break;
                }
            AudioDevice.Close();
        }

        private void AppWindow_Load(object sender, EventArgs e)
        {
            if (AppPreferences.RecordingDevice == "") SwitchView();

            if (!MediaFoundationEncoder.GetEncoderMediaTypes(AudioSubTypes.MpegLayer3).Any())
            {
                MessageBox.Show("The current platform does not support mp3 encoding.\nApplication will close.");
                Application.Exit();
            }
            TopMost = AppPreferences.AlwaysOnTop;
        }
    }
}