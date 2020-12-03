using System;
using System.Data;
using System.Linq;

namespace PassingDataTable.Classes
{
    public class Operations
    {
        public static void StartMethod()
        {
            var dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn() {ColumnName = "Id", DataType = typeof(int),
                AutoIncrement = true, AutoIncrementSeed = 1});

            dataTable.Columns.Add(new DataColumn() {ColumnName = "FirstName", DataType = typeof(string)});
            dataTable.Columns.Add(new DataColumn() {ColumnName = "LastName", DataType = typeof(string)});
            dataTable.Columns.Add(new DataColumn() {ColumnName = "Salary", DataType = typeof(decimal)});

            dataTable.Rows.Add(null, "Karen", "Payne", 123.4);
            dataTable.Rows.Add(null, "Bob", "Adams", 456.0);
            dataTable.Rows.Add(null, "mary", "Jones", 7779.0);

            //ModifyTable(dataTable);

            //ModifyRow(dataTable.Rows.Cast<DataRow>().FirstOrDefault());
            AddRecord(dataTable);
            Console.WriteLine();

        }
        /// <summary>
        /// Mockup for changing a field value for last name
        /// </summary>
        /// <param name="dataRow">Populated DataRow</param>
        public static void ModifyRow(DataRow dataRow)
        {
            dataRow.SetField("LastName", dataRow.Field<string>("LastName") + " Changed");
        }
        //
        
        /// <summary>
        /// Modify all first names
        /// </summary>
        /// <param name="dataTable">Populated DataTable</param>
        public static void ModifyTable(DataTable dataTable)
        {
            for (int index = 0; index < dataTable.Rows.Count; index++)
            {
                dataTable.Rows[index]
                    .SetField("FirstName", 
                        dataTable.Rows[index].Field<string>("FirstName")
                            .ToUpper());
            }
        }

        public static void AddRecord(DataTable dataTable)
        {
            var dr = dataTable.NewRow();
            dataTable.Rows.Add(dr);

            dr.SetField("FirstName","Mike");
            dr.SetField("LastName","Lebow");
            dr.SetField("Salary",45677);
            Console.WriteLine();
        }
    }
}
