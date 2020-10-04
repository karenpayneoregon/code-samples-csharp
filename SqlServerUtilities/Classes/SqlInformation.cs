using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SqlServerUtilities.QueryClasses;
using static System.Configuration.ConfigurationManager;

namespace SqlServerUtilities.Classes
{
    public class SqlInformation
    {
        /// <summary>
        /// For a real app the connection string could come
        /// from app.config, adjust as needed
        /// </summary>
        private static readonly string DatabaseName = AppSettings["Catalog"];

        private static readonly string ConnectionString =
            $"Data Source={AppSettings["DatabaseServer"]};" +
            $"Initial Catalog={DatabaseName};" +
            "Integrated Security=True";

        public Dictionary<string, List<ServerTableItem>> TableDependencies()
        {


            var informationTable = new DataTable();
            
            using (var cn = new SqlConnection() { ConnectionString = ConnectionString })
            {
                using (var cmd = new SqlCommand() { Connection = cn })
                {
                    cmd.CommandText = QueryStatements.ColumnDescriptionsForTableExpanded;

                    cn.Open();
                    informationTable.Load(cmd.ExecuteReader());

                }
            }

            var result = from row in informationTable.AsEnumerable()
                         group row by row.Field<string>("Table") into grp
                         select new
                         {
                             TableName = grp.Key,
                             Rows = grp,
                             Count = grp.Count()
                         };

            var tableDictionary = new Dictionary<string, List<ServerTableItem>>();

            foreach (var topItem in result)
            {

                if (!tableDictionary.ContainsKey(topItem.TableName))
                {
                    tableDictionary[topItem.TableName] = new List<ServerTableItem>();
                }

                foreach (var row in topItem.Rows)
                {
                    tableDictionary[topItem.TableName].Add(new ServerTableItem()
                    {
                        Table = topItem.TableName,
                        Field = row.Field<string>("Field"),
                        FieldOrder = row.Field<short>("FieldOrder"),
                        DataType = row.Field<string>("DataType"),
                        Length = row.Field<short>("Length"),
                        Precision = row.Field<string>("Precision"),
                        Scale = row.Field<int>("Scale"),
                        AllowNulls = row.Field<string>("AllowNulls"),
                        Identity = row.Field<string>("Identity"),
                        PrimaryKey = row.Field<string>("PrimaryKey"),
                        ForeignKey = row.Field<string>("ForeignKey"),
                        RelatedTable = row.Field<string>("RelatedTable"),
                        Description = row.Field<string>("Description")
                    });
                }
            }

            return tableDictionary;
        }
    }
}
