using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vortex
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static Form2 instanse;
        public static Form2 GetForm
        {
            get
            {
                if (instanse == null || instanse.IsDisposed)
                    instanse = new Form2();
                return instanse;
            }
        }

        public void DrawChart(object sender = null, EventArgs e = null)
        {
            //chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            //chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            //chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            //chart.ChartAreas[0].AxisX.Interval = 10;
            chart.Series.Clear();
            if (temperature1CheckBox.Checked)
            {
                chart.Series.Add("temperature1");
                chart.Series["temperature1"].Color = temperature1CheckBox.BackColor;
                foreach (var item in CSVFile.Records)
                {
                    DateTime time = DateTime.Parse(item.Time);
                    if (time.CompareTo(minTimePicker.Value)>=0&&time.CompareTo(maxTimePicker.Value)<=0)
                    {
                        chart.Series["temperature1"].Points.AddXY(time, item.Temperature1);
                    }
                }
            }
            if (temperature2CheckBox.Checked)
            {
                chart.Series.Add("temperature2");
                chart.Series["temperature2"].Color = temperature2CheckBox.BackColor;
                foreach (var item in CSVFile.Records)
                {
                    DateTime time = DateTime.Parse(item.Time);
                    if (time.CompareTo(minTimePicker.Value) >= 0 && time.CompareTo(maxTimePicker.Value) <= 0)
                    {
                        chart.Series["temperature2"].Points.AddXY(time, item.Temperature2);
                    }
                }
            }
            if (temperature3CheckBox.Checked)
            {
                chart.Series.Add("temperature3");
                chart.Series["temperature3"].Color = temperature3CheckBox.BackColor;
                foreach (var item in CSVFile.Records)
                {
                    DateTime time = DateTime.Parse(item.Time);
                    if (time.CompareTo(minTimePicker.Value) >= 0 && time.CompareTo(maxTimePicker.Value) <= 0)
                    {
                        chart.Series["temperature3"].Points.AddXY(time, item.Temperature3);
                    }
                }
            }
            if (temperature4CheckBox.Checked)
            {
                chart.Series.Add("temperature4");
                chart.Series["temperature4"].Color = temperature4CheckBox.BackColor;
                foreach (var item in CSVFile.Records)
                {
                    DateTime time = DateTime.Parse(item.Time);
                    if (time.CompareTo(minTimePicker.Value) >= 0 && time.CompareTo(maxTimePicker.Value) <= 0)
                    {
                        chart.Series["temperature4"].Points.AddXY(time, item.Temperature4);
                    }
                }
            }
            foreach (var series in chart.Series)
            {
                series.XValueType = ChartValueType.Time;
                series.ChartType = SeriesChartType.Line;
                series.BorderWidth = 5;
                //series.IsXValueIndexed = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CSVFile.LoadRecords();
            if (!minMaxCheckBox.Checked&&CSVFile.Records.Count !=0)
            {
                minTimePicker.Value = DateTime.Parse(CSVFile.Records.First().Time);
                maxTimePicker.Value = DateTime.Parse(CSVFile.Records.Last().Time);
            }
            DrawChart();
        }

        private void MinMaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            minTimePicker.Enabled = minMaxCheckBox.Checked;
            maxTimePicker.Enabled = minMaxCheckBox.Checked;
        }
    }
}
