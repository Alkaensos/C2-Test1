using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class Betriebszustand
    {
        private int betriebsmodus;
        public int Betriebsmodus
        {
            get { return betriebsmodus; }
            set { betriebsmodus = value; }
        }
        private int aktuelleDrehzahl;

        public int AktuelleDrehzahl
        {
            get { return aktuelleDrehzahl; }
            set { aktuelleDrehzahl = value; }
        }
        private int aktuelleSpannung;

        public int AktuelleSpannung
        {
            get { return aktuelleSpannung; }
            set { aktuelleSpannung = value; }
        }

        private int aktuelleLeistungsaufnahme;

        public int AktuelleLeistungsaufnahme
        {
            get { return aktuelleLeistungsaufnahme; }
            set { aktuelleLeistungsaufnahme =  value; }
        }

        private int aktuellerStrom;

        public int AktuelleStrom
        {
            get { return aktuellerStrom; }
            set { aktuellerStrom  = value; }
        }
    }
}
