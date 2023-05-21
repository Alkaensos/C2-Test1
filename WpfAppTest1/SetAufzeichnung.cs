using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class SetAufzeichnung
    {
        public int Aufzeichnung()
        {
            try
            {
                string sql = "INSERT INTO Aufzeichnung (Drehzahl, Leistung, Spannung, Zeitstempel) " + 
                             "Values (" + 
                             "(SELECT Drehzahl FROM AktuelleWerte), " +
                             "(SELECT Leistung FROM AktuelleWerte), " +
                             "(SELECT Spannung FROM AktuelleWerte), " +
                             "getdate()" +
                             ")";
                DatabaseAccess.setQuery(sql);
            }
            catch (Exception ex)
            {
                throw;
            }
            return 0;
        }
    }
}
