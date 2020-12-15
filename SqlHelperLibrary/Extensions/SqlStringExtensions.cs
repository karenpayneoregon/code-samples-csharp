using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlHelperLibrary.Extensions
{
    public static class SqlStringExtensions
    {
        /// <summary>
        /// Determine is SQL is valid
        /// </summary>
        /// <param name="sqlStatement"></param>
        /// <returns>if statement is valid syntax</returns>
        public static bool IsValidSql(this string sqlStatement) => !sqlStatement.ValidateSql().Any();

        public static IEnumerable<string> ValidateSql(this string sql)
        {

            if (string.IsNullOrWhiteSpace(sql))
            {
                return new[] { "SQL query should be non-empty." };
            }

            var parser = new TSql120Parser(false);

            IList<ParseError> errors;

            using (var reader = new StringReader(sql))
            {
                parser.Parse(reader, out errors);
            }

            return errors.Select(parseError => parseError.Message);
        }
    }
}
