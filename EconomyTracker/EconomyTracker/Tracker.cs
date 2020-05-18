using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace EconomyTracker
{
    class Tracker
    {
        public decimal fond { get;}
        public decimal enkeltAksjer { get;}
        public decimal spekulasjon { get;}
        public decimal crypto { get;}
        public Tracker(decimal fond, decimal enkeltAksjer, decimal spekulasjon, decimal crypto)
        {
            this.fond = fond;
            this.enkeltAksjer = enkeltAksjer;
            this.spekulasjon = spekulasjon;
            this.crypto = crypto;
        }

        public void skrivInfo()
        {
            MessageBox.Show($"Du har følgende verdier i Aksjefond: {fond}, Enkeltaksjer: {enkeltAksjer}, Spekulasjon: {spekulasjon} og i Crypto: {crypto}");
        }
    }
}
