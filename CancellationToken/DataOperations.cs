using System;
using System.Data;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace CancellationToken
{
    public class DataOperations
    {
        private const string ConnectionString = "TODO";

        public static async Task<DataTable> Read1(int key)
        {
            var dt = new DataTable();

            using (var cn = new OleDbConnection(ConnectionString))
            {
                using (var cmd = new OleDbCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT * From MyTable WHERE MyID < @id";
                    cmd.Parameters.AddWithValue("@Id", key);

                    await cn.OpenAsync();

                    dt.Load(await cmd.ExecuteReaderAsync());

                    return dt;
                }
            }
        }
        public static async Task<DataTable> Read2(int key) 
        {
            var dt = new DataTable();

            using (var cn = new OleDbConnection(ConnectionString))
            {
                using (var cmd = new OleDbCommand { Connection = cn })
                {
                    cmd.CommandText = "SELECT * From MyTable WHERE MyID < ?";
                    cmd.Parameters.AddWithValue("?", key);

                    await cn.OpenAsync();

                    dt.Load(await cmd.ExecuteReaderAsync());

                    return dt;
                }
            }
        }

        public int Demo(string userName, string userPassword)
        {
            var resultCount = -1;

            using (var cn = new OleDbConnection(ConnectionString))
            {
                using (var cmd = new OleDbCommand {Connection = cn})
                {

                    cmd.CommandText = "select * from CDM1.Users where [User Name]= ? and [password] = ?";
                    cmd.Parameters.AddWithValue("?", userName);
                    cmd.Parameters.AddWithValue("?", userPassword);

                    try
                    {
                        cn.Open();

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            resultCount += 1;
                        }
                    }
                    catch (Exception e)
                    {
                        // handle exception, for now
                        Console.WriteLine(e.Message);
                    }
                }

            }

            return resultCount;
        }
    }
}
