﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace Vortex
{

    class Alarm
    {
        static double firstSetTemp;
        static double secondSetTemp;
        static double thirdSetTemp;
        static double fourthSetTemp;
        static bool alarmFirst;
        static bool alarmSecond;
        static bool alarmThird;
        static bool alarmFourth;
        static SoundPlayer player;
        static MainForm mainForm;
        private static System.Timers.Timer timer;
        static double parseTemp1;
        static double parseTemp2;
        static double parseTemp3;
        static double parseTemp4;
        static DateTime lastMeasureTime;

        public static double FirstSetTemp { get => firstSetTemp; set => firstSetTemp = value; }
        public static double SecondSetTemp { get => secondSetTemp; set => secondSetTemp = value; }
        public static double ThirdSetTemp { get => thirdSetTemp; set => thirdSetTemp = value; }
        public static double FourthSetTemp { get => fourthSetTemp; set => fourthSetTemp = value; }

        public static void TakeTemp(string data)
        {
            //Data looks like: value1^value2^value3^value4
            char sep1 = '^';
            string[] dataTemp = data.Split(sep1);
            Double.TryParse(dataTemp[0].Trim(), out parseTemp1);
            Double.TryParse(dataTemp[1].Trim(), out parseTemp2);
            Double.TryParse(dataTemp[2].Trim(), out parseTemp3);
            Double.TryParse(dataTemp[3].Trim(), out parseTemp4);
            if (Settings.ChartAllow&& DateTime.Now.Minute!=lastMeasureTime.Minute)
            {
                lastMeasureTime = DateTime.Now;
                CSVFile.Record record = new CSVFile.Record(DateTime.Now.ToString(), parseTemp1, parseTemp2, parseTemp3, parseTemp4);
                CSVFile.SaveRecord(record);
            }
        }
        public static void Display()
        {
            mainForm.firstTemp.Text = (parseTemp1.ToString("n2") + "°C");
            mainForm.secondTemp.Text = (parseTemp2.ToString("n2") + "°C");
            mainForm.thirdTemp.Text = (parseTemp3.ToString("n2") + "°C");
            mainForm.fourthTemp.Text = (parseTemp4.ToString("n2") + "°C");
        }

        private static void Timer1OVF(object sender, ElapsedEventArgs e)
        {
            player.Play();
            timer.Interval = 3500;
        }

        public static void InitializePlayerAndOthers(MainForm form)
        {
            mainForm = form;
            timer = new System.Timers.Timer(10);
            timer.Elapsed += Timer1OVF;
            timer.AutoReset = true;
            player = new SoundPlayer(Vortex.Properties.Resources.Alarm);
            player.LoadAsync();
        }

        public static void TimerStop()
        {
            timer.Stop();
            timer.Interval = 10;
        }
        public static void CheckAll()
        {
            CheckFourthTemp();
            CheckSecondTemp();
            CheckThirdTemp();
            CheckFirstTemp();
        }
        public static void CheckFirstTemp()
        {

            if (mainForm.firstAlarmOn.Checked)
            {
                if (Convert.ToDouble(parseTemp1) > firstSetTemp)
                {
                    mainForm.firstTemp.BackColor = Color.Red;
                    timer.Start();
                    alarmFirst = true;
                }
                else
                {
                    mainForm.firstTemp.BackColor = Color.Green;
                    if (!(alarmFourth || alarmThird || alarmSecond))
                    {
                        TimerStop();
                    }
                    alarmFirst = false;
                }
            }
            else
            {
                mainForm.firstTemp.BackColor = default(Color);
                if (alarmFirst && (!(alarmFourth || alarmThird || alarmSecond)))
                {
                    TimerStop();
                }
                alarmFirst = false;
            }
        }
        public static void CheckSecondTemp()
        {
            if (mainForm.secondAlarmOn.Checked)
            {
                if (Convert.ToDouble(parseTemp2) > secondSetTemp)
                {
                    mainForm.secondTemp.BackColor = Color.Red;
                    timer.Start();
                    alarmSecond = true;
                }
                else
                {
                    mainForm.secondTemp.BackColor = Color.Green;
                    if (!(alarmFourth || alarmThird || alarmFirst))
                    {
                        TimerStop();
                    }
                    alarmSecond = false;

                }
            }
            else
            {
                mainForm.secondTemp.BackColor = default(Color);
                if (alarmSecond && (!(alarmFourth || alarmThird || alarmFirst)))
                {
                    TimerStop();
                }
                alarmSecond = false;
            }
        }

        public static void CheckThirdTemp()
        {
            if (mainForm.thirdAlarmOn.Checked)
            {
                if (Convert.ToDouble(parseTemp3) > thirdSetTemp)
                {
                    mainForm.thirdTemp.BackColor = Color.Red;
                    timer.Start();
                    alarmThird = true;
                }
                else
                {
                    mainForm.thirdTemp.BackColor = Color.Green;
                    if (!(alarmFirst || alarmSecond || alarmFourth))
                    {
                        TimerStop();
                    }
                    alarmThird = false;
                }
            }
            else
            {
                mainForm.thirdTemp.BackColor = default(Color);
                if (alarmThird && (!(alarmFirst || alarmSecond || alarmFourth)))
                {
                    TimerStop();
                }
                alarmThird = false;
            }

        }
        public static void CheckFourthTemp()
        {
            if (mainForm.fourthAlarmOn.Checked)
            {
                if (Convert.ToDouble(parseTemp4) > fourthSetTemp)
                {
                    mainForm.fourthTemp.BackColor = Color.Red;
                    timer.Start();
                    alarmFourth = true;
                }
                else
                {
                    mainForm.fourthTemp.BackColor = Color.Green;
                    if (!(alarmThird || alarmSecond || alarmFirst))
                    {
                        TimerStop();
                    }
                    alarmFourth = false;
                }
            }
            else
            {
                mainForm.fourthTemp.BackColor = default(Color);
                if (alarmFourth && (!(alarmThird || alarmSecond || alarmFirst)))
                {
                    TimerStop();
                }
                alarmFourth = false;
            }
        }

    }
}
