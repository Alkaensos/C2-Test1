using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTest1
{
    public class DatabaseAccess
    {
        public static int executeQuery(string sql, params object[] args)
        {
            int rowCount = 0;
            SqlConnection lueftungssteuerungDb =
                new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["Lueftungssteuerung"]);
            SqlCommand sqlCommand = new SqlCommand();

            try
            {
                sqlCommand.CommandText = sql;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = lueftungssteuerungDb;
                sqlCommand.CommandTimeout = 12 * 3600;

                lueftungssteuerungDb.Open();

                rowCount = sqlCommand.ExecuteNonQuery();
                lueftungssteuerungDb.Close();
            }
            catch (Exception ex)
            {
                lueftungssteuerungDb.Close();
                throw ex;
            }
            return rowCount;
        }
    }
}
