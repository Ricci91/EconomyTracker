using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomyTracker
{
    public partial class Form1 : Form
    {
        Tracker tracker;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal fond = Convert.ToDecimal(fondTextbox.Text);
            decimal enkeltAksjer = Convert.ToDecimal(enkelTextbox.Text);
            decimal spekulasjon = Convert.ToDecimal(spekulasjonTextbox.Text);
            decimal crypto = Convert.ToDecimal(cryptoTextbox.Text);

            tracker = new Tracker(fond, enkeltAksjer, spekulasjon, crypto);
            var records = new List<Tracker>
            {
                tracker
            };

            using (var writer = new StreamWriter("C:\\Users\\froyl\\Documents\\Prosjekter\\C#\\EconomyTracker\\tracker.csv")) 
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
            tracker.skrivInfo();
        }
    }
}
