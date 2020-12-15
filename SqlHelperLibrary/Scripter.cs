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

        

        public static void Parser1(string sql)
        {
            var sb = new StringBuilder();
            var tSql120Parser = new TSql120Parser(true);
            IList<ParseError> list;
            var fragment = tSql120Parser.Parse(new StringReader(sql), out list);
            var flag = list.Any();
            if (flag)
            {

                foreach (var current in list)
                {
                    sb.AppendLine($"error {current.Number}: ({current.Line},{current.Column}): {current.Message}");
                }

                Console.WriteLine(sb.ToString());
            }
            else
            {
                try
                {
                    //this.EmitFragment(0, fragment);
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();

                }
            }
        }

        /// <summary>
        /// Get each parameter for WHERE clause
        /// </summary>
        /// <param name="sql">SQL with parameters</param>
        /// <returns></returns>
        public static List<string> GetVariables(string sql)
        {
            List<TSqlParserToken> queryTokens = TokenizeSql(sql, out var errors);

            if (errors != null)
            {
                // TODO
            }

            var parameters = new List<string>();

            parameters.AddRange(queryTokens
                .Where(token => token.TokenType == TSqlTokenType.Variable)
                .Select(token => token.Text)
                .ToList());

            return parameters;
        }

        private static List<TSqlParserToken> TokenizeSql(string sql, out List<string> parserErrors)
        {
            using (TextReader textReader = new StringReader(sql))
            {
                var parser = new TSql120Parser(true);
                

                IList<ParseError> errors;
                var queryTokens = parser.GetTokenStream(textReader, out errors);
                if (errors.Any())
                {
                    parserErrors = errors.Select(e => $"Error: {e.Number}; Line: {e.Line}; Column: {e.Column}; Offset: {e.Offset};  Message: {e.Message};").ToList();
                }
                else
                {
                    parserErrors = null;
                }
                return queryTokens.ToList();
            }
        }
        public static void GetBatchesExample()
        {
            var sql = @"SELECT        Cust.CustomerIdentifier, Cust.CompanyName, Cust.ContactId, CT.ContactTitle, C.FirstName, C.LastName, Cust.Street, Cust.City, Cust.Region, Cust.PostalCode, Cust.Phone, Cust.ContactTypeIdentifier, Cust.ModifiedDate, 
                         Cust.CountryIdentifier, CO.Name
FROM            Customers AS Cust INNER JOIN
                         Contacts AS C ON Cust.ContactId = C.ContactId INNER JOIN
                         ContactType AS CT ON Cust.ContactTypeIdentifier = CT.ContactTypeIdentifier AND C.ContactTypeIdentifier = CT.ContactTypeIdentifier INNER JOIN
                         Countries AS CO ON Cust.CountryIdentifier = CO.CountryIdentifier
WHERE        Cust.CountryIdentifier = @CountryIdentifier AND Cust.ContactId = @ContactIdentifier";
            
            Console.WriteLine();
            IList<ParseError> errors;
            using (var reader = new StringReader(sql))
            {
                var parser = new TSql120Parser(true);
                
                var fragment = parser.Parse(reader, out errors);

                if (errors.Count > 0)
                {
                    Console.WriteLine("Errors!");
                }


                foreach (var t in fragment.ScriptTokenStream)
                {
                    if (t.TokenType != TSqlTokenType.WhiteSpace)
                        Console.WriteLine(t.TokenType.ToString() + " = " + t.Text);
                }

            }

            Console.WriteLine(errors.Count);
            Console.WriteLine();
        }

       
    }
}
