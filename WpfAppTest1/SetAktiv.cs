using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace WpfAppTest1
{
    public class SetAktiv
    {
        public int SetAktivJN(int stufe)
        {
            try
            {
                string sql = "UPDATE Stufen SET AktivJN = 1 WHERE Stufe = " + stufe;
                DatabaseAccess.setQuery(sql);
                sql = "UPDATE Stufen SET AktivJN = 1 WHERE Stufe <> " + stufe;
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
