using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MarketService
{
    internal sealed class SQLManager
    {
        private static System.Data.SqlClient.SqlConnection conn;
        private SQLManager() { }
        public static void connectionToDB()
        {
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=c:\\Users\\Katka\\Documents\\Visual Studio 2013\\Projects\\MarketService\\MarketService\\App_Data\\MarketDatabase.mdf;Integrated Security=True;User Instance=True";
            conn.Open();
        }
        internal static void ExecuteSPParameters(string sp_name, List<SqlParameter> parameters)
        {
            try
            {
                if (parameters == null)
                    parameters = new List<SqlParameter>();

                connectionToDB();

                using (SqlCommand cmd = new SqlCommand(sp_name, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                conn.Close();
            }
        }

        internal static DataTable ExecuteSPValue(string sp_name, List<SqlParameter> parameters)
        {
            try
            {
                if (parameters == null)
                    parameters = new List<SqlParameter>();

                connectionToDB();
                DataSet ds = new DataSet();
                SqlDataAdapter da;
                SqlCommand cmd;
                using (cmd = new SqlCommand(sp_name, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.Add(param);
                    }
                }

                using (da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds);
                }

                return ds.Tables[0];

            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
        }

    }
}