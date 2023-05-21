using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class Betriebsdaten
    {
        private int dauer;
        public int Dauer
        {
            get { return dauer; }
            set { dauer = value; }
        }
        
        private int drehzahl;

        public int Drehzahl
        {
            get { return drehzahl; }
            set { drehzahl = value; }
        }

        private int leistungsaufnahme;

        public int Leistungsaufnahme
        {
            get { return leistungsaufnahme; }
            set { leistungsaufnahme = value; }
        }

        private int strom;

        public int Strom
        {
            get { return strom; }
            set { strom = value; }
        }

        private int spannung;

        public int Spannung
        {
            get { return spannung; }
            set { spannung = value; }
        }

        public void getStufe0()
        {
            Dauer = 5;
            Drehzahl = 0;
            Leistungsaufnahme = 0;
            Strom = 0;
            Spannung = 0;
        }

        public void getStufe1()
        {
            Dauer = 5;
            Drehzahl = 30;
            Leistungsaufnahme = 15;
            Strom = Leistungsaufnahme / Spannung;
            Spannung = 230;
        }

        public void getStufe2()
        {
            Dauer = 5;
            Drehzahl = 60;
            Leistungsaufnahme = 45;
            Strom = Leistungsaufnahme / Spannung;
            Spannung = 230;
        }

        public void getStufe3()
        {
            Dauer = 5;
            Drehzahl = 90;
            Leistungsaufnahme = 60;
            Strom = Leistungsaufnahme / Spannung;
            Spannung = 230;
        }
    }
}
