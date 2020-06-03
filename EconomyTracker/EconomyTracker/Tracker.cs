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

        public string Date { get; }
        public decimal Fond { get;}
        public decimal EnkeltAksjer { get;}
        public decimal Spekulasjon { get;}
        public decimal Crypto { get;}
        public decimal Buffer { get;}
        public Tracker(string date, decimal fond, decimal enkeltAksjer, decimal spekulasjon, decimal crypto, decimal buffer)
        {
            this.Date = date;
            this.Fond = fond;
            this.EnkeltAksjer = enkeltAksjer;
            this.Spekulasjon = spekulasjon;
            this.Crypto = crypto;
            this.Buffer = buffer;
        }

        public string skrivInfo() /*Viser en messagebox med teksten under*/
        {
            return $"{Date}\r\n\r\nDU HAR FØLGENDE VERDIER I: \r\n\r\n> Aksjefond: {Fond},- <\r\n\r\n > Enkeltaksjer: {EnkeltAksjer},- <\r\n\r\n > Spekulasjon: {Spekulasjon},- <\r\n\r\n > Crypto: {Crypto},- <\r\n\r\n > Buffer: {Buffer},- <\r\n\r\n\r\n\r\n >>CSV fil oppdatert<<";
        }
    }
}
