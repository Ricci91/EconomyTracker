using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            Append();
            updatePercentage();
        }

        private void Append() /*Legger til data til csv fil uten å legge til header*/
        {
            decimal fond = Convert.ToDecimal(fondTextbox.Text);
            decimal enkeltAksjer = Convert.ToDecimal(enkelTextbox.Text);
            decimal spekulasjon = Convert.ToDecimal(spekulasjonTextbox.Text);
            decimal crypto = Convert.ToDecimal(cryptoTextbox.Text);
            string file = "C:\\Users\\froyl\\Documents\\Prosjekter\\C#\\EconomyTracker\\tracker.csv";

            tracker = new Tracker(fond, enkeltAksjer, spekulasjon, crypto);
            var records = new List<Tracker>
            {
                tracker
            };

            using (var writer = new StreamWriter(file, true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                csv.WriteRecords(records);
            }
            tracker.skrivInfo();
            totalResultLabel.Visible = true;
        }

        private void updatePercentage()/*Oppdaterer total label og prosentlabler*/
        {
            decimal fond = Convert.ToDecimal(fondTextbox.Text);
            decimal enkeltAksjer = Convert.ToDecimal(enkelTextbox.Text);
            decimal spekulasjon = Convert.ToDecimal(spekulasjonTextbox.Text);
            decimal crypto = Convert.ToDecimal(cryptoTextbox.Text);
            decimal total = fond + enkeltAksjer + spekulasjon + crypto;

            fondProsent.Text = ((fond / total) * 100).ToString() + "%";
            fondProsent.Visible = true;
            enkelProsent.Text = ((enkeltAksjer / total) * 100).ToString() + "%";
            enkelProsent.Visible = true;
            spekulasjonProsent.Text = ((spekulasjon / total) * 100).ToString() + "%";
            spekulasjonProsent.Visible = true;
            cryptoProsent.Text = ((crypto / total) * 100).ToString() + "%";
            cryptoProsent.Visible = true;

            totalResultLabel.Text = total.ToString() + ",-";
            totalResultLabel.Visible = true;
        }
    }
}
