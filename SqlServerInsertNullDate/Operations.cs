using System;
using System.Data;
using System.Data.SqlClient;
using ExceptionHandling;
using SqlServerInsertNullDate.Entities;

namespace SqlServerInsertNullDate
{
    public class Operations
    {
        /*
         *  - If not using SQL-Express change the data source
         *  - Change Catalog to match the name of your database
         */
        private static string _connectionString = 
            "Data Source=.\\sqlexpress;Initial Catalog=ForumExample;Integrated Security=True";

        /// <summary>
        /// Insert new employee for demonstrating how to set a value based on if a value
        /// was passed in.
        /// Notes
        /// - For a date other options are to set the default value in the table  definition if nulls are not allowed
        /// - For exceptions in this code sample exceptions are written to a log file using code in <see cref="Exceptions.Write"/>
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static bool InsertEmployeeRow(Employee employee)
        {

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {
                using (var cmd = new SqlCommand { Connection = cn })
                {

                    /*
                     * Perform INSERT followed by getting the primary key for the
                     * newly added employee.
                     *
                     * Note SELECT CAST(scope_identity() AS int); is SQL-Server specific
                     */
                    cmd.CommandText = "INSERT INTO dbo.employee (FirstName, LastName, HiredDate) " + 
                                      "VALUES (@FirstName, @LastName, @HiredDate);" + 
                                      "SELECT CAST(scope_identity() AS int);";

                    cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = employee.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;


                    if (employee.HiredDate.HasValue)
                    {
                        cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = employee.HiredDate.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@HiredDate", SqlDbType.DateTime).Value = DBNull.Value;
                    }

                    try
                    {
                        cn.Open();

                        employee.Id = Convert.ToInt32(cmd.ExecuteScalar());

                        return true;

                    }
                    catch (Exception ex)
                    {
                        Exceptions.Write(ex);
                        return false;
                    }

                }
            }
        }
    }
}
