using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerInsertList
{
    public class Operations
    {
        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;
        private static string _connectionString = "Data Source=.\\sqlexpress;Initial " +
                                                  "Catalog=CustomerDatabase;Integrated Security=True";

        public static string CompanyNamesDelimited()
        {
            string results = "";

            using (var cn = new SqlConnection {ConnectionString = _connectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {
                    cmd.CommandText =
                        "SELECT STRING_AGG(ISNULL(CompanyName, ''), ';') AS csv " +
                        "FROM CustomerDatabase.dbo.Customer " +
                        "WHERE dbo.Customer.CompanyName LIKE @LikeCondition;";

                    cmd.Parameters.AddWithValue("@LikeCondition", "c%");

                    try
                    {
                        cn.Open();

                        results = Convert.ToString(cmd.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        OnExceptionEvent?.Invoke(ex);
                    }

                }
            }

            return results;
        }
    }
}
