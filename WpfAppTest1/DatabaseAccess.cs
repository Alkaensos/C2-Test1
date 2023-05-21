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
        public static string getQuery(string sql, params object[] args)
        {
            SqlConnection lueftungssteuerungDb =
                new SqlConnection(connectionString: System.Configuration.ConfigurationSettings.AppSettings["Lueftungssteuerung"]);
            SqlCommand sqlCommand = new SqlCommand();

            string result;
            try
            {
                sqlCommand.CommandText = sql;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = lueftungssteuerungDb;
                sqlCommand.CommandTimeout = 12 * 3600;

                lueftungssteuerungDb.Open();

                result = (string)sqlCommand.ExecuteScalar();
                lueftungssteuerungDb.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                lueftungssteuerungDb.Close();
            }
            return result;
        }
        public static int setQuery(string sql, params object[] args)
        {
            SqlConnection lueftungssteuerungDb =
                new SqlConnection(connectionString: System.Configuration.ConfigurationSettings.AppSettings["Lueftungssteuerung"]);
            SqlCommand sqlCommand = new SqlCommand();

            int rowCount;
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
                throw;
            }
            finally
            {
                lueftungssteuerungDb.Close();
            }
            return rowCount;
        }
    }
}
