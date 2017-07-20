using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vortex
{
    class CSVFile
    {
        static  List<Record> records;
        internal static List<Record> Records { get => records; set => records = value; }

        public class Record
        {
            public Record() { }
            public Record(string time, double temperature1, double temperature2, double temperature3, double temperature4)
            {
                Time = time;
                Temperature1 = temperature1;
                Temperature2 = temperature2;
                Temperature3 = temperature3;
                Temperature4 = temperature4;
            }

            public string Time { get ; set ; }
            public double Temperature1 { get; set; }
            public double Temperature2 { get; set; }
            public double Temperature3 { get; set; }
            public double Temperature4 { get; set; }
        }
        public static void SaveRecord<T>(T record)
        {
            using (StreamWriter writer = new StreamWriter(Settings.FilePath,true))
            {
                CsvWriter csvwriter = new CsvWriter(writer);
                csvwriter.Configuration.Delimiter = ";";
                csvwriter.Configuration.QuoteNoFields = true;
                csvwriter.WriteRecord(record);
            }
        }
        public static void CreateCSVFile()
        {
            using (StreamWriter writer = new StreamWriter(Settings.FilePath, true))
            {
                CsvWriter csvwriter = new CsvWriter(writer);
                csvwriter.Configuration.Delimiter = ";";
                csvwriter.Configuration.QuoteNoFields = true;
                    csvwriter.WriteHeader(typeof(Record));
            }
        }

        public static void LoadRecords()
        {
            using (StreamReader reader = new StreamReader(Settings.FilePath))
            {
                CsvReader csvReader = new CsvReader(reader);
                csvReader.Configuration.Delimiter = ";";
                csvReader.Configuration.QuoteNoFields = true;
                records = csvReader.GetRecords<Record>().ToList();
            }
        }
    }
}
