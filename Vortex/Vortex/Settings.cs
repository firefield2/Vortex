using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vortex
{
    class Settings
    {
        static string filePath;
        static string path;
        static string urlAdress = "The address of the php script that gives up the current data.";
        static bool chartAllow = false;
        static bool lastChartAllow=false;

        public static string Path
        {
            get => path;
            set
            {
                if (Directory.Exists(value))
                {
                    path = value;
                    ChartAllow = true;
                }
            }
        }

        public delegate void ChartAllowDelegate();
        public static event ChartAllowDelegate OnChartAllow;
        public static string UrlAdress { get => urlAdress; set => urlAdress = value; }
        public static bool ChartAllow
        {
            get => chartAllow; set
            {
                chartAllow = value;
                OnChartAllow?.Invoke();
                if (chartAllow && (chartAllow != lastChartAllow))
                {
                    DateTime currentDate = DateTime.Today;
                    DateTime currentTime = DateTime.Now;
                    FilePath = $"\\vortex_{currentDate.Month}{currentDate.Day}_{currentTime.Hour}{currentTime.Minute}";
                    if(!File.Exists(FilePath))
                    {
                        CSVFile.CreateCSVFile();
                    }
                }
                lastChartAllow = value;
            }
        }

        public static string FilePath
        {
            get => filePath; private set => filePath = path + value + ".csv";

        }
    }
}
