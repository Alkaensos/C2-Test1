using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class Zustandssimulation
    {
        private int aktuelleDrehzahl;

        public int AktuelleDrehzahl
        {
            get { return aktuelleDrehzahl; }
            set { aktuelleDrehzahl = value; }
        }

        private int AktuelleLeistungsaufnahme;

        public int aktuelleLeistungsaufnahme
        {
            get { return aktuelleLeistungsaufnahme; }
            set { aktuelleLeistungsaufnahme =  value; }
        }

        private int AktuellerStrom;

        public int aktuellerStrom
        {
            get { return aktuellerStrom; }
            set { aktuellerStrom = value; }
        }

        private int AktuelleSpannung;

        public int aktuelleSpannung
        {
            get { return aktuelleSpannung; }
            set { aktuelleSpannung  = value; }
        }

        private int SollDrehzahl;

        public int sollDrehzahl
        {
            get { return sollDrehzahl; }
            set {  sollDrehzahl = value;}
        }
        private int SollLeistungsaufnahme;

        public int sollLeistungsaufnahme
        {
            get { return sollLeistungsaufnahme; }
            set { sollLeistungsaufnahme = value; }
        }

        private int SollStrom;

        public int sollStrom
        {
            get { return sollStrom; }
            set { sollStrom = value; }
        }

        private int SollSpannung;

        public int sollSpannung
        {
            get { return sollSpannung; }
            set { sollSpannung = value;}
        }

        private int SollDauer;

        public int sollDauer
        {
            get { return sollDauer; }
            set { sollDauer = value;}
        }
    }
}
