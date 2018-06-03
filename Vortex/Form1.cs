using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using System.Net;
using System.IO;
using System.Threading;

namespace Vortex
{
    //TODO Generowanie wykresów w nowym oknie
    public partial class MainForm : Form
    {
        CancellationTokenSource cancellationToken = new CancellationTokenSource();
        delegate void SetTextCallback(string dane);

        public MainForm()
        {
            InitializeComponent();
            Settings.OnChartAllow += ChartButtonEnableChanging;
            Alarm.InitializePlayerAndOthers(this);
            Task GetWebData = new Task(() =>
                    GetData(cancellationToken.Token)

            );
            GetWebData.Start();
        }

        private void ChartButtonEnableChanging()
        {
            chartButton.Enabled = Settings.ChartAllow;
        }

        private void GetData(CancellationToken cancellationToken)
        {
            string data = String.Empty;
            int errorsCount = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(new Uri(Settings.UrlAdress));
                    request.Timeout = 2000;
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            errorsCount = 0;
                            connectionStatusLabel.Text = "Połączono";
                            connectionStatusLabel.BackColor = default(Color);
                            using (StreamReader reader = new StreamReader(responseStream, Encoding.UTF8))
                                data = reader.ReadToEnd();
                        }
                    }

                }
                catch (WebException ex)
                {
                    errorsCount++;
                    if (errorsCount > 10)
                    {
                        connectionStatusLabel.Text = "Brak połączenia!";
                        connectionStatusLabel.BackColor = Color.Red;
                    }
                }
                HandleData(data);
           
            }

        }

        private void HandleData(string data)
        {
            if (this.firstTemp.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(HandleData);
                this.Invoke(d, new object[] { data });
            }
            else
            {
                //Data looks like: $value1^value2^value3^value4#
                char[] charsToTrim = { '#', '$' };
                if (data.Contains(charsToTrim[0]))
                {
                    data = data.Trim();
                    data = data.Trim(charsToTrim);
                    Alarm.TakeTemp(data);
                    Alarm.Display();
                    Alarm.CheckAll();
                }
            }
        }

        public void AlarmAllOnOFFButton_Click(object sender, EventArgs e)
        {
            firstLabel.Focus();
            if (alarmAllOnOFFButton.Text == "Włącz wszystkie")
            {
                alarmAllOnOFFButton.Text = "Wyłącz wszystkie";
                if (firstAlarmOn.Enabled)
                {
                    firstAlarmOn.Checked = true;
                }
                if (secondAlarmOn.Enabled)
                {
                    secondAlarmOn.Checked = true;
                }
                if (thirdAlarmOn.Enabled)
                {
                    thirdAlarmOn.Checked = true;
                }
                if (fourthAlarmOn.Enabled)
                {
                    fourthAlarmOn.Checked = true;
                }
                vesselCheckBox.Checked = true;
            }
            else
            {
                alarmAllOnOFFButton.Text = "Włącz wszystkie";
                if (firstAlarmOn.Enabled)
                {
                    firstAlarmOn.Checked = false;
                }
                if (secondAlarmOn.Enabled)
                {
                    secondAlarmOn.Checked = false;
                }
                if (thirdAlarmOn.Enabled)
                {
                    thirdAlarmOn.Checked = false;
                }
                if (fourthAlarmOn.Enabled)
                {
                    fourthAlarmOn.Checked = false;
                }
                vesselCheckBox.Checked = false;
            }

        }

        private void FirstAlarmBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FirstAlarmBox_Check();
            }
        }

        private void FirstAlarmBox_Check(object sender = null, EventArgs e = null)
        {
            firstTempAlarmBox.Visible = false;
            firstTempAlarmBox.Enabled = false;
            firstTempAlarm.Visible = true;
            if (firstTempAlarmBox.Text.Length != 0)
            {
                if (Double.TryParse(firstTempAlarmBox.Text, out double temperature))
                {
                    firstTempAlarm.Text = string.Format("{0:0.00}°C", temperature);
                    Alarm.FirstSetTemp = temperature;
                    firstAlarmOn.Enabled = true;
                }
                else
                {
                    firstTempAlarmBox.Clear();
                }
            }
            else
            {
                firstTempAlarm.Text = "n/n";
                firstAlarmOn.Checked = false;
                firstAlarmOn.Enabled = false;
            }
        }

        private void SecondAlarmBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SecondAlarmBox_Check();
            }
        }

        private void SecondAlarmBox_Check(object sender = null, EventArgs e = null)
        {
            secondTempAlarmBox.Visible = false;
            secondTempAlarmBox.Enabled = false;
            secondTempAlarm.Visible = true;
            if (secondTempAlarmBox.Text.Length != 0)
            {
                if (Double.TryParse(secondTempAlarmBox.Text, out double temperature))
                {
                    secondTempAlarm.Text = string.Format("{0:0.00}°C", temperature);
                    Alarm.SecondSetTemp = temperature;
                    secondAlarmOn.Enabled = true;
                }
                else
                {
                    secondTempAlarmBox.Clear();
                }
            }
            else
            {
                secondTempAlarm.Text = "n/n";
                secondAlarmOn.Checked = false;
                secondAlarmOn.Enabled = false;
            }
        }

        private void ThirdAlarmBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ThirdAlarmBox_Check();
            }
        }

        private void ThirdAlarmBox_Check(object sender = null, EventArgs e = null)
        {
            thirdTempAlarmBox.Visible = false;
            thirdTempAlarmBox.Enabled = false;
            thirdTempAlarm.Visible = true;
            if (thirdTempAlarmBox.Text.Length != 0)
            {
                if (Double.TryParse(thirdTempAlarmBox.Text, out double temperature))
                {
                    thirdTempAlarm.Text = string.Format("{0:0.00}°C", temperature);
                    Alarm.ThirdSetTemp = temperature;
                    thirdAlarmOn.Enabled = true;
                }
                else
                {
                    thirdTempAlarmBox.Clear();
                }
            }
            else
            {
                thirdTempAlarm.Text = "n/n";
                thirdAlarmOn.Checked = false;
                thirdAlarmOn.Enabled = false;
            }
        }

        private void FourthAlarmBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                FourthAlarmBox_Check();
            }
        }

        private void FourthAlarmBox_Check(object sender = null, EventArgs e = null)
        {
            fourthTempAlarmBox.Visible = false;
            fourthTempAlarmBox.Enabled = false;
            fourthTempAlarm.Visible = true;
            if (fourthTempAlarmBox.Text.Length != 0)
            {
                if (Double.TryParse(fourthTempAlarmBox.Text, out double temperature))
                {
                    fourthTempAlarm.Text = string.Format("{0:0.00}°C",temperature);
                    Alarm.FourthSetTemp = temperature;
                    fourthAlarmOn.Enabled = true;
                }
                else
                {
                    fourthTempAlarmBox.Clear();
                }
            }
            else
            {
                fourthTempAlarm.Text = "n/n";
                fourthAlarmOn.Checked = false;
                fourthAlarmOn.Enabled = false;
            }
        }

        private void FirstAlarm_DoubleClick(object sender, EventArgs e)
        {
            firstTempAlarm.Visible = false;
            firstTempAlarmBox.Enabled = true;
            firstTempAlarmBox.Visible = true;
            firstTempAlarmBox.Focus();
        }

        private void SecondAlarm_DoubleClick(object sender, EventArgs e)
        {
            secondTempAlarm.Visible = false;
            secondTempAlarmBox.Enabled = true;
            secondTempAlarmBox.Visible = true;
            secondTempAlarmBox.Focus();
        }

        private void ThirdAlarm_DoubleClick(object sender, EventArgs e)
        {
            thirdTempAlarm.Visible = false;
            thirdTempAlarmBox.Enabled = true;
            thirdTempAlarmBox.Visible = true;
            thirdTempAlarmBox.Focus();
        }

        private void FourthAlarm_DoubleClick(object sender, EventArgs e)
        {
            fourthTempAlarm.Visible = false;
            fourthTempAlarmBox.Enabled = true;
            fourthTempAlarmBox.Visible = true;
            fourthTempAlarmBox.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationToken.Cancel();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            firstLabel.Focus();
            Form settingForm = new Form3();
            settingForm.ShowDialog();
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            firstLabel.Focus();
            Form2.GetForm.Show();
        }

        private void MainForm_Enter(object sender, EventArgs e)
        {
            chartButton.Enabled = Settings.ChartAllow;
        }

    }
}
