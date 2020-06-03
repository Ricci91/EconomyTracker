using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;

namespace EconomyTracker
{
    class CsvHandler
    {
        public void CsvWriter(string file, List<Tracker> records)
        {
            using (var writer = new StreamWriter(file, true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.WriteRecords(records);
            }
        }

        /*public void CsvReaders(string file)
        {
            
            using (var stream = new MemoryStream())
            using (var reader = new StreamReader(file))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                IEnumerable<Tracker> records = csv.GetRecords<Tracker>();

                foreach(Tracker record in records)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}, {4}", record.fond, record.enkeltAksjer, record.spekulasjon, record.crypto, record.buffer);
                }
            }
        }*/

        public List<Tracker> CsvReaders(string file)
        {
            List<Tracker> trackers = new List<Tracker>();
            using (StreamReader sr = new StreamReader(file))
            {
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                    trackers.Add(ReadTrackerFromCsvLine(csvLine));
            }
            return trackers;
        }

        public Tracker ReadTrackerFromCsvLine(string csvLine)
        {
            string[] parts = csvLine.Split(',');
            string date = parts[0] ;
            string fond = parts[1];
            string enkeltAksjer = parts[2];
            string spekulasjon = parts[3];
            string crypto = parts[4];
            string buffer = parts[5];

            return new Tracker(date, Convert.ToDecimal(fond), Convert.ToDecimal(enkeltAksjer), Convert.ToDecimal(spekulasjon), Convert.ToDecimal(crypto), Convert.ToDecimal(buffer));
        }
    }

}
