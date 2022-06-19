using System;
using System.IO;
using System.Windows.Forms;

namespace PeakTimer
{
    public partial class MainForm : Form
    {
        private int minutes, seconds;
        private string finalText;
        private long timeTriggerSecond;
        private readonly string timeLeftTextFile;

        private void WriteNewConfig()
        {
            File.WriteAllLines("config.txt", new string[] { "0", "3", "", "false" });
        }

        public MainForm()
        {
            InitializeComponent();

            if (!File.Exists("config.txt"))
                WriteNewConfig();

            string[] values = File.ReadAllLines("config.txt");
            if (values.Length < 4)
            {
                WriteNewConfig();
                values = File.ReadAllLines("config.txt");
            }

            nudMinutes.Value = Convert.ToInt32(values[0]);
            nudSeconds.Value = Convert.ToInt32(values[1]);
            tbFinalText.Text = values[2];
            cbTriggerTimer.Checked = Convert.ToBoolean(values[3]);
            finalText = "";
            TimeTrigger.Value = DateTime.Now;
            // timeLeftTextFile = string.Format("timeleft-{0}.txt", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"));
            timeLeftTextFile = "timeleft.txt";
            lbTimeLeftFileName.Text = timeLeftTextFile;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (minutes == 0 && seconds == 0)
                return;

            if (cbTriggerTimer.Checked)
            {
                timeTriggerSecond = (TimeTrigger.Value.Ticks  - DateTime.Now.Ticks) / TimeSpan.TicksPerMillisecond / 1000;
                if (timeTriggerSecond < 0)
                {
                    lbTimerTrigger.Text = "The current time has gone past the specified time";
                    return;
                }
                timerTrigger.Start();
            }
            else
            {
                timer.Start();
            }

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void BtnSet_Click(object sender, EventArgs e)
        {
            minutes = (int)nudMinutes.Value;
            seconds = (int)nudSeconds.Value;
            finalText = tbFinalText.Text;
            if (cbTriggerTimer.Checked)
            {
                lbTimerTrigger.Text = "The timer will start at " + TimeTrigger.Value.ToString();
            }
            else
            {
                lbTimerTrigger.Text = "";
            }

            timerText.Text = (minutes == 0 && seconds == 0) ? finalText : minutes.ToString("D2") + ":" + seconds.ToString("D2");
            File.WriteAllText(timeLeftTextFile, timerText.Text);
        }

        private void Event(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                seconds = 59;
                minutes -= 1;
            }
            else
                seconds -= 1;

            if (minutes == 0 && seconds == 0)
            {
                Stop();
                timerText.Text = finalText;
            }
            else
            {
                timerText.Text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }

            File.WriteAllText(timeLeftTextFile, timerText.Text);
        }

        private void ToggleTimeTrigger(object sender, EventArgs e)
        {
            TimeTrigger.Enabled = lbZoneOffset.Enabled = cbTriggerTimer.Checked;
        }
        private void TimerTrigger_Event(object sender, EventArgs e)
        {
            if (timeTriggerSecond > 0)
            {
                lbTimerTrigger.Text = "The timer will start in " + timeTriggerSecond + ((timeTriggerSecond == 1) ? " second" : " seconds");
                timeTriggerSecond--;
            }
            else
            {
                lbTimerTrigger.Text = "";
                timer.Start();
                timerTrigger.Stop();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            btnSet.PerformClick();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllLines("config.txt", new string[] { minutes.ToString(), seconds.ToString(), finalText, cbTriggerTimer.Checked.ToString() });
            // if (File.Exists(timeLeftTextFile)) File.Delete(timeLeftTextFile);
        }

        private void Stop()
        {
            if (timerTrigger.Enabled)
            {
                timerTrigger.Stop();
            }
            if (timer.Enabled)
            {
                timer.Stop();
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }
    }
}
