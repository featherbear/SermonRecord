using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Taskbar;

namespace Sermon_Record.UI
{
    public partial class Main : UserControl
    {
        private readonly string TitlePartRecording = " [RECORDING]";

        public Main()
        {
            InitializeComponent();
        }

        private void recordStartStop_Click(object sender, EventArgs e)
        {
            if (Recorder.IsRecording)
            {
                Recorder.Stop();
                elapsedTimeTimer.Stop();
                btnPreferences.Enabled = true;
                TaskbarManager.Instance.SetProgressValue(0, 1);
                ((AppWindow)ParentForm).Text = ((AppWindow)ParentForm).Text.Replace(TitlePartRecording, "");

                btnRecord.Text = "START";
            }
            else if (ModifierKeys == Keys.Shift)
            {
            }
            else if (Recorder.Record())
            {
                elapsedTimeTimer.Start();
                btnPreferences.Enabled = false;

                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                TaskbarManager.Instance.SetProgressValue(1, 1);

                ((AppWindow)ParentForm).Text += TitlePartRecording;

                btnRecord.Text = "STOP";
            }
        }

        private void btnPreferences_Click(object sender, EventArgs e)
        {
            ((AppWindow)ParentForm).SwitchView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void elapsedTimeTimer_Tick(object sender, EventArgs e)
        {
            if (Recorder.IsRecording)
                elapsedTimeLbl.Text = Recorder.GetElapsedTimeFormatted();
        }

        private void soundMeterTTimer_Tick(object sender, EventArgs e)
        {
            if (AudioDevice.IsOpen)
                soundMeterT.Text = Math.Min(soundMeterG.Maximum, AudioDevice.PeakValueDb + 5) - soundMeterG.Maximum +
                                   " dB";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void soundMeterGTimer_Tick(object sender, EventArgs e)

        {
            if (AudioDevice.IsOpen)                soundMeterG.Value = AudioDevice.PeakValueDb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Recorder.a.ComputeData();
            
        }

        private void Print_Click(object sender, EventArgs e)
        {
            Debug.Print("LENGTH: " + Recorder.a.barData.Length.ToString());
            foreach (var VARIABLE in Recorder.a.barData)
            {

                Debug.Print(VARIABLE.ToString());
            }
            
        }
    }
}