using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace MockupAsyncDataOperations.Classes
{
    public class DataOperations
    {
        private static string ConnectionString = "TODO";

        public delegate void OnError(Exception sender);
        public static event OnError OnErrorHandler;
        /// <summary>
        /// Simple mockup for performing a operation for SQL-Server
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> ProcessData(System.Threading.CancellationToken token)
        {
            return await Task.Run(async () =>
            {
                using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
                {
                    await cn.OpenAsync(token);

                    var trans = cn.BeginTransaction("operation1");

                    using (var cmd = new SqlCommand() {Connection = cn, Transaction = trans })
                    {

                        cmd.CommandText = "Place SQL hhere";

                        try
                        {
                            await cmd.ExecuteNonQueryAsync(token);
                            return true;

                        }
                        catch (Exception e)
                        {
                            try
                            {
                                trans.Rollback();
                                OnErrorHandler?.Invoke(e);
                                throw;
                            }
                            catch (Exception transEx)
                            {
                                OnErrorHandler?.Invoke(transEx);
                                return false;
                            }
                        }

                    }
                }
            }, token);

        }
        /// <summary>
        /// This is a blank slate for starting an asynchronous operation
        /// </summary>
        /// <returns></returns>
        public static async Task<bool> EmptyTask()
        {
            return await Task.Run(async () =>
            {
                await Task.Delay(1);
                return true;
            });

        }
    }
}
