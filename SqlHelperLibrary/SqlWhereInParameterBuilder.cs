using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SqlHelperLibrary
{
    public static class SqlWhereInParameterBuilder
    {
        public delegate void OnShowCommandStatement(string statement); 
        /// <summary>
        /// Callback for subscribers to know about a problem
        /// </summary>
        public static event OnShowCommandStatement OnShowCommandStatementEvent; 
        /// <summary>
        /// Create a SQL SELECT statement which is then passed off to
        /// AddParamsToCommand to create a parameter for each value.
        /// </summary>
        /// <typeparam name="T">SELECT Statement with WHERE condition</typeparam>
        /// <param name="partialClause">Base SQL SELECT statement</param>
        /// <param name="paramPrefix">WHERE IN field</param>
        /// <param name="parameters">Value list for WHERE IN</param>
        /// <returns>SELECT Statement with WHERE condition ready to populate values</returns>
        public static string BuildWhereInClause<T>(string partialClause, string paramPrefix, IEnumerable<T> parameters)
        {

            paramPrefix = StripFunction(paramPrefix);

            var parameterNames = parameters.Select((paramText, paramNumber) => $"@{paramPrefix.Replace(".", "")}{paramNumber}").ToArray();

            var whereInClause = string.Format(partialClause.Trim(), string.Join(",", parameterNames));

            return whereInClause;

        }
        /// <summary>
        /// Create a parameter for each value in parameters
        /// </summary>
        /// <typeparam name="T">Command with parameters setup</typeparam>
        /// <param name="cmd">Command object</param>
        /// <param name="paramPrefix">Field name for the WHERE IN</param>
        /// <param name="parameters">Values for the WHERE IN</param>
        public static void AddParamsToCommand<T>(this SqlCommand cmd, string paramPrefix, IEnumerable<T> parameters)
        {
            paramPrefix = StripFunction(paramPrefix);

            var parameterValues = parameters.Select((paramText) => paramText).ToArray();
            string[] parameterNames = parameterValues.Select((paramText, paramNumber) => $"@{paramPrefix.Replace(".", "")}{paramNumber}").ToArray();

            for (int index = 0; index < parameterNames.Length; index++)
            {
                cmd.Parameters.AddWithValue(parameterNames[index], parameterValues[index]);
            }

            OnShowCommandStatementEvent?.Invoke( cmd.CommandText );

        }
        /// <summary>
        /// Used to get a field name from a function e.g. YEAR(ActiveDate)
        /// which will return ActiveDate.
        /// </summary>
        /// <param name="pValue"></param>
        /// <returns></returns>
        private static string StripFunction(string pValue)
        {
            if (pValue.Contains("("))
            {
                string regularExpressionPattern = "(?<=\\()[^}]*(?=\\))";
                Regex re = new Regex(regularExpressionPattern);
                return re.Matches(pValue)[0].ToString();
            }
            else
            {
                return pValue;
            }
        }
    }

}
