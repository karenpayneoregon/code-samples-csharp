using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace SqlHelperLibrary
{
    public class Scripter
    {
        public static IList<ParseError> ParseErrors { get; set; }
        /// <summary>
        /// Format SQL off one line to indented into many lines
        /// </summary>
        /// <param name="query">SQL statement to format</param>
        /// <returns>Formatted SQL</returns>
        /// <remarks>
        /// Can be used to document or for debugging.
        /// </remarks>
        public static string Format(string query)
        {
            var parser = new TSql120Parser(false);

            var parsedQuery = parser.Parse(new StringReader(query), out var errors);

            if (errors.Count > 0)
            {
                ParseErrors = errors;

            }
            var generator = new Sql120ScriptGenerator(new SqlScriptGeneratorOptions()
            {
                KeywordCasing = KeywordCasing.Uppercase,
                IncludeSemicolons = true,
                NewLineBeforeFromClause = true,
                NewLineBeforeOrderByClause = true,
                NewLineBeforeWhereClause = true,
                AlignClauseBodies = false
            });

            generator.GenerateScript(parsedQuery, out var formattedQuery);
            return formattedQuery;
        }
    }
}
