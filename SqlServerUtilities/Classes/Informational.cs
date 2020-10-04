using System.Collections.Generic;
using System.Data.SqlClient;
using SqlServerUtilities.Enums;
using SqlServerUtilities.QueryClasses;
using static System.Configuration.ConfigurationManager;

namespace SqlServerUtilities.Classes
{
    /// <summary>
    /// Provides methods to obtain keys from current database
    /// </summary>
    /// <remarks>
    /// Ordinal position of properties is dependent on SQL
    /// in QueryStatements class
    /// </remarks>
    public class Informational
    {
        /// <summary>
        /// For a real app the connection string could come
        /// from app.config, adjust as needed
        /// </summary>
        private static readonly string DatabaseName = AppSettings["Catalog"];

        private static string _connectionString =
            $"Data Source={AppSettings["DatabaseServer"]};" +
            $"Initial Catalog={DatabaseName};" +
            "Integrated Security=True";

        public static List<ColumnDescription> GetColumnDescriptions(string tableName)
        {
            var results = new List<ColumnDescription>();


            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {

                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = QueryStatements.ColumnDescriptionsForTable;

                    cmd.Parameters.AddWithValue("@TableName", tableName);

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        results.Add(new ColumnDescription()
                        {
                            Name = reader.GetString(0),
                            OrdinalPosition = reader.GetInt32(1).ToString(),
                            Description = reader.IsDBNull(2) ? reader.GetString(0) : reader.GetString(2)
                        });
                    }
                }
            }

            return results;
        }

        public static List<Constraints> GetAllTablesForeignConstraints() 
        {
            var results = new List<Constraints>();

            using (var cn = new SqlConnection {ConnectionString = _connectionString})
            {

                using (var cmd = new SqlCommand {Connection = cn})
                {

                    cmd.CommandText = QueryStatements.ForeignKeysAllTables();

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        results.Add(new Constraints()
                        {
                            TableName = reader.GetString(0),
                            ConstraintName = reader.GetString(1),
                            ColumnName = reader.GetString(2),
                            ReferencedTable = reader.GetString(3),
                            ReferencedColumn = reader.GetString(4)
                        });
                    }
                }
            }

            return results;

        }

        public static List<Constraints> GetConstraints(ConstraintType constraintType, string tableName)
        {
            var results = new List<Constraints>();

            var constraintParamValue = "";

            if (constraintType == ConstraintType.Primary)
                constraintParamValue = "PRIMARY KEY";
            else if (constraintType == ConstraintType.Foreign)
                constraintParamValue = "FOREIGN KEY";
            else if (constraintType == ConstraintType.Unique) constraintParamValue = "UNIQUE";

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {

                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = QueryStatements.GetKeys();

                    cmd.Parameters.AddWithValue("@ConstraintType", constraintParamValue);
                    cmd.Parameters.AddWithValue("@TableName", tableName);

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        results.Add(new Constraints()
                        {
                            ConstraintSchema = reader.GetString(0),
                            ConstraintName = reader.GetString(2),
                            ColumnName = reader.GetString(3),
                            DataType = reader.GetString(4)
                        });
                    }
                }
            }

            return results;

        }

        public static List<Constraints> GetTableForeignConstraints(string tableName)
        {
            var results = new List<Constraints>();

            using (var cn = new SqlConnection { ConnectionString = _connectionString })
            {

                using (var cmd = new SqlCommand { Connection = cn })
                {

                    cmd.CommandText = QueryStatements.ForeignKeysForSingleTable();
                    cmd.Parameters.AddWithValue("@TableName", tableName);

                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        results.Add(new Constraints()
                        {
                            TableName = reader.GetString(0),
                            ConstraintName = reader.GetString(1),
                            ColumnName = reader.GetString(2),
                            ReferencedTable = reader.GetString(3),
                            ReferencedColumn = reader.GetString(4)
                        });
                    }
                }
            }

            return results;

        }

        public static List<string> GetTableNameList()
        {
            var results = new List<string>();

            using (var cn = new SqlConnection {ConnectionString = _connectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {
                    cmd.CommandText = QueryStatements.GetTableNames(DatabaseName);
                    cn.Open();

                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        results.Add(reader.GetString(0));
                    }
                }
            }

            return results;
        }
    }
}
