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
        public static string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NorthWindAzure1;Integrated Security=True";

        /// <summary>
        /// Set true to display formatted SQL in output window
        /// </summary>
        public static bool DisplayFormattedSql;


        public delegate void OnException(Exception exception);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnException OnExceptionEvent;

        public delegate void OnShowCommandStatement(string methodName, string statement);
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnShowCommandStatement OnShowCommandStatementEvent;

        public static string _methodName;

        public static DataTable ExampleCustomersDataTable1(List<string> pContactTitleList)
        {
            _methodName = nameof(ExampleCustomersDataTable1);

            SqlWhereInParameterBuilder.OnShowCommandStatementEvent += SqlWhereInParameterBuilder_OnShowCommandStatementEvent;

            var customersDataTable = new DataTable();

            // field which the WHERE IN will use
            const string parameterPrefix = "CT.ContactTitle";

            // Base SELECT Statement
            var selectStatement =
                "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , C.ContactTypeIdentifier , " +
                "FORMAT(C.ModifiedDate, 'MM-dd-yyyy', 'en-US') AS ModifiedDate, CT.ContactTitle " +
                "FROM dbo.Customers AS C INNER JOIN dbo.ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " +
                $"WHERE {parameterPrefix} IN ({{0}}) ORDER BY C.CompanyName";

            // Builds the SELECT statement minus values
            var commandText = SqlWhereInParameterBuilder.BuildWhereInClause(selectStatement, parameterPrefix, pContactTitleList);

            using (var cn = new SqlConnection {ConnectionString = _connectionString })
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
                        customersDataTable.Load(cmd.ExecuteReader());

                        if (DisplayFormattedSql)
                        {
                            Console.WriteLine(Scripter.Format(cmd.CommandText));
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        OnExceptionEvent?.Invoke(ex);
                    }
                    {
                        SqlWhereInParameterBuilder.OnShowCommandStatementEvent -= SqlWhereInParameterBuilder_OnShowCommandStatementEvent;
                    }
                }

            }

            return customersDataTable;
        }
        public static List<Customer> ExampleCustomersList1(List<string> pContactTitleList)
        {

            _methodName = nameof(ExampleCustomersList1);

            SqlWhereInParameterBuilder.OnShowCommandStatementEvent += SqlWhereInParameterBuilder_OnShowCommandStatementEvent;

            var customers = new List<Customer>();

            // field which the WHERE IN will use
            const string parameterPrefix = "CT.ContactTitle";

            // Base SELECT Statement
            var selectStatement =
                "SELECT C.CustomerIdentifier , C.CompanyName , C.ContactName , C.ContactTypeIdentifier , " +
                "FORMAT(C.ModifiedDate, 'MM-dd-yyyy', 'en-US') AS ModifiedDate, CT.ContactTitle " +
                "FROM dbo.Customers AS C INNER JOIN dbo.ContactType AS CT ON C.ContactTypeIdentifier = CT.ContactTypeIdentifier " +
                $"WHERE {parameterPrefix} IN ({{0}}) ORDER BY C.CompanyName";

            var commandText = SqlWhereInParameterBuilder.BuildWhereInClause(selectStatement, parameterPrefix, pContactTitleList);

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {

                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = commandText;
                    cmd.AddParamsToCommand(parameterPrefix, pContactTitleList);
                    
                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            customers.Add(new Customer()
                            {
                                CustomerIdentifier = reader.GetInt32(0),
                                CompanyName = reader.GetString(1),
                                ContactName = reader.GetString(2),
                                ContactTypeIdentifier = reader.GetInt32(3),
                                ModifiedDate = reader.GetString(4),
                                ContactTitle = reader.GetString(5)
                            });
                        }

                        if (DisplayFormattedSql)
                        {
                            Console.WriteLine(Scripter.Format(cmd.CommandText));
                        }

                    }
                    catch (Exception ex)
                    {
                        OnExceptionEvent?.Invoke(ex);
                    }
                    {
                        SqlWhereInParameterBuilder.OnShowCommandStatementEvent -= SqlWhereInParameterBuilder_OnShowCommandStatementEvent;
                    }
                }

            }

            return customers;
        }
        public static List<Product> ExampleProductsList(List<string> pCategoryList)
        {
            _methodName = nameof(ExampleProductsList);

            SqlWhereInParameterBuilder.OnShowCommandStatementEvent += SqlWhereInParameterBuilder_OnShowCommandStatementEvent;
            var products = new List<Product>();

            // field which the WHERE IN will use
            const string parameterPrefix = "C.CategoryName";

            // Base SELECT Statement
            var selectStatement =
                "SELECT  P.CategoryID, C.CategoryName, P.ProductID, P.ProductName, P.QuantityPerUnit " + 
                "FROM Products AS P INNER JOIN Categories AS C ON P.CategoryID = C.CategoryID " +
                $"WHERE {parameterPrefix} IN ({{0}}) ORDER BY P.ProductName";

            var commandText = SqlWhereInParameterBuilder.BuildWhereInClause(selectStatement, parameterPrefix, pCategoryList);

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {

                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = commandText;
                    cmd.AddParamsToCommand(parameterPrefix, pCategoryList);

                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            products.Add(new Product()
                            {
                                CategoryID = reader.GetInt32(0),
                                CategoryName = reader.GetString(1),
                                ProductID = reader.GetInt32(2),
                                ProductName = reader.GetString(3),
                                QuantityPerUnit = reader.GetString(4)
                            });
                        }

                        if (DisplayFormattedSql)
                        {
                            Console.WriteLine(Scripter.Format(cmd.CommandText));
                        }

                    }
                    catch (Exception ex)
                    {
                        OnExceptionEvent?.Invoke(ex);
                    }
                    finally
                    {
                        SqlWhereInParameterBuilder.OnShowCommandStatementEvent -= SqlWhereInParameterBuilder_OnShowCommandStatementEvent;
                    }
                }

            }

            return products;
        }
        private static void SqlWhereInParameterBuilder_OnShowCommandStatementEvent(string statement)
        {
            OnShowCommandStatementEvent?.Invoke(_methodName,statement);
        }
    }
}
