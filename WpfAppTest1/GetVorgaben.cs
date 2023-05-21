using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class GetVorgaben
    {
        public string Spannung(string spannung)
        {
            try
            {
                string sql = "SELECT TOP 1 Spannung FROM Stufen WHERE AktivJN = 1";
                spannung = DatabaseAccess.getQuery(sql);
                spannung += " Volt";
            }
            catch (Exception ex)
            {
                throw;
            }
            return spannung;
        }

        public string Drehzahl(string drehzahl)
        {
            try
            {
                string sql = "SELECT TOP 1 Drehzahl FROM Stufen WHERE AktivJN = 1";
                drehzahl = DatabaseAccess.getQuery(sql);
                drehzahl += " U/Min";
            }
            catch (Exception ex)
            {
                throw;
            }
            return drehzahl;
        }

        public string Leistung(string leistung)
        {
            try
            {
                string sql = "SELECT TOP 1 Leistung FROM Stufen WHERE AktivJN = 1";
                leistung = DatabaseAccess.getQuery(sql);
                leistung += " Watt";
            }
            catch (Exception ex)
            {
                throw;
            }
            return leistung;
        }

        public string Stufe(string Stufe)
        {
            try
            {
                string sql = "SELECT TOP 1 Bezeichnung FROM Stufen WHERE AktivJN = 1";
                Stufe = DatabaseAccess.getQuery(sql);
            }
            catch (Exception ex)
            {
                throw;
            }
            return Stufe;
        }
    }
}
