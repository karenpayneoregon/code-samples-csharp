using System;
using System.Data;
using System.Data.Odbc;

namespace SingletonExample1.Classes
{
    public sealed class DataConnections
    {
        private static readonly Lazy<DataConnections> 
            Lazy = new Lazy<DataConnections>(() => new DataConnections());

        public static DataConnections Instance => Lazy.Value;

        public OdbcConnection Connection()
        {
            OdbcConnection connection = null;

            try
            {
                connection = connection = new OdbcConnection(RuntimeSettings.Instance.ConnectionString);
            }
            catch (Exception)
            {
                // ignored
            }

            if (connection == null || connection.State == ConnectionState.Broken || connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection?.Dispose();
                }
                catch (Exception)
                {
                    // ignored
                }

                connection = new OdbcConnection();
            }

            if (connection.State != ConnectionState.Closed) return connection;

            connection.ConnectionString = RuntimeSettings.Instance.ConnectionString;

            connection.Open();

            return connection;
        }

    }
}