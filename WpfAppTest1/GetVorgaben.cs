using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class GetVorgaben
    {
        public string Spannung(string Spannung)
        {
            try
            {
                string sql = "SELECT TOP 1 Spannung FROM Stufen WHERE AktivJN = 1";
                Spannung = DatabaseAccess.executeQuery(sql);
                Spannung += " Volt";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Spannung;
        }
    }
}
