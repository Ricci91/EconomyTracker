using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        CsvHandler csvhandler;
        const string fileName = "tracker.csv";
        string file = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);

        public Form1()
        {
            InitializeComponent();
            readCSV();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Append();
            updatePercentage();
        }

        private void Append() /*Legger til data til csv fil uten å legge til header*/
        {
            string date = DateTime.Now.ToString();
            decimal fond = Convert.ToDecimal(fondTextbox.Text);
            decimal enkeltAksjer = Convert.ToDecimal(enkelTextbox.Text);
            decimal spekulasjon = Convert.ToDecimal(spekulasjonTextbox.Text);
            decimal crypto = Convert.ToDecimal(cryptoTextbox.Text);
            decimal buffer = Convert.ToDecimal(bufferTextbox.Text);

            tracker = new Tracker(date, fond, enkeltAksjer, spekulasjon, crypto, buffer);
            var records = new List<Tracker>
            {
                tracker
            };


            csvhandler = new CsvHandler();
            csvhandler.CsvWriter(file, records);

            infoLabel.Text = tracker.skrivInfo();
            infoLabel.Visible = true;
            totalResultLabel.Visible = true;

            readCSV();
        }

        private void updatePercentage()/*Oppdaterer total label og prosentlabler*/
        {
            decimal fond = Convert.ToDecimal(fondTextbox.Text);
            decimal enkeltAksjer = Convert.ToDecimal(enkelTextbox.Text);
            decimal spekulasjon = Convert.ToDecimal(spekulasjonTextbox.Text);
            decimal crypto = Convert.ToDecimal(cryptoTextbox.Text);
            decimal buffer = Convert.ToDecimal(bufferTextbox.Text);
            decimal total = fond + enkeltAksjer + spekulasjon + crypto;

            fondProsent.Text = String.Format("{0:0.00}", (fond / total) * 100) + "%";
            fondProsent.Visible = true;
            enkelProsent.Text = String.Format("{0:0.00}", (enkeltAksjer / total) * 100) + "%";
            enkelProsent.Visible = true;
            spekulasjonProsent.Text = String.Format("{0:0.00}", (spekulasjon / total) * 100) + "%";
            spekulasjonProsent.Visible = true;
            cryptoProsent.Text = String.Format("{0:0.00}", (crypto / total) * 100) + "%";
            cryptoProsent.Visible = true;
            bufferProsent.Text = String.Format("{0:0.00}", (crypto / total) * 100) + "%";
            bufferProsent.Visible = true;
            totalResultLabel.Text = total.ToString() + ",-";
            totalResultLabel.Visible = true;
        }

        private void spekulasjonTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void readCSV()
        {
            csvhandler = new CsvHandler();
            List<Tracker> trackers = csvhandler.CsvReaders(file);

            for (int i = 0; i < trackers.Count; i++)
            {
                Tracker tracker = trackers[i];
                Console.WriteLine($"Registered on date: {tracker.Date}");
                Console.WriteLine($"Fond: {tracker.Fond}");
                Console.WriteLine($"Enkeltaksjer: {tracker.EnkeltAksjer}");
                Console.WriteLine($"Spekulasjon: {tracker.Spekulasjon}");
                Console.WriteLine($"Crypto: {tracker.Crypto}");
                Console.WriteLine($"Buffer: {tracker.Buffer}");
            }
        }
    }
}
