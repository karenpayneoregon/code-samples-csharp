using System;
using System.Data.SqlClient;

namespace SqlHelperLibrary.Extensions
{
    public static class ReaderExtensions
    {

        public static DateTime? GetNullableDateTime(this SqlDataReader reader, string name)
        {
            var columnOrdinal = reader.GetOrdinal(name);
            return reader.IsDBNull(columnOrdinal) ?
                null :
                reader.GetDateTime(columnOrdinal) as DateTime?;
        }
    }
}
