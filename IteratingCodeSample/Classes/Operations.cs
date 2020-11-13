using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace IteratingCodeSample.Classes
{
    public class Operations
    {
        public delegate void DisplayInformation(Countries sender);
        public static event DisplayInformation DisplayInformationHandler;

        private static string _connectionString = "Data Source=.\\sqlexpress;Initial " +
                                          "Catalog=northwind2020;Integrated Security=True";

        /// <summary>
        /// Get countries, the user interface remains responsive
        /// </summary>
        /// <returns></returns>
        public static async Task GetCountries()
        {

            using (var cn = new SqlConnection {ConnectionString = _connectionString})
            {
                using (var cmd = new SqlCommand {Connection = cn})
                {
                    await cn.OpenAsync();
                    cmd.CommandText = "SELECT CountryIdentifier, Name FROM dbo.Countries;";
                    var reader = await cmd.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        /*
                         * Since there are only a few records let's act like more is going on,
                         * otherwise the operation here will happen in less than a second.
                         */
                        await Task.Delay(200);

                        var country = new Countries()
                        {
                            CountryIdentifier = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };
                        
                        DisplayInformationHandler?.Invoke(country);
                    }
                }
            }
        }

    }
}
