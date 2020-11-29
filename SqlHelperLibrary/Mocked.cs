using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlHelperLibrary
{
    public class Mocked
    {
        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;
        public static DataTable Example1(List<string> pContactTitleList)
        {
            var dt = new DataTable();

            // field which the WHERE IN will use
            var parameterPrefix = "CT.ContactTitle";

            // Base SELECT Statement
            var selectStatement =
                "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , C.ContactTypeIdentifier , " +
                "FORMAT(C.ModifiedDate, 'MM-dd-yyyy', 'en-US') AS ModifiedDate, CT.ContactTitle " +
                "FROM dbo.Customers AS C INNER JOIN dbo.ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " +
                $"WHERE {parameterPrefix} IN ({{0}}) ORDER BY C.CompanyName";

            // Builds the SELECT statement minus values
            var commandText = SqlWhereInParameterBuilder.BuildWhereInClause(selectStatement, parameterPrefix, pContactTitleList);

            using (var cn = new SqlConnection {ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWindAzure1;Integrated Security=True" })
            {

                using (var cmd = new SqlCommand {Connection = cn})
                {

                    cmd.CommandText = commandText;

                    //
                    // Add values for command parameters
                    //
                    cmd.AddParamsToCommand(parameterPrefix, pContactTitleList);

                    

                    try
                    {
                        cn.Open();

                        dt.Load(cmd.ExecuteReader());
                        Console.WriteLine();

                    }
                    catch (Exception ex)
                    {
                        OnExceptionEvent?.Invoke(ex);
                    }
                }

            }

            return dt;
        }
    }
}
