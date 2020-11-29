using System.Linq;
using System.Text;

namespace SqlHelperLibrary
{
    /// <summary>
    /// Generate SELECT WHERE IN
    /// </summary>
    /// <remarks>
    /// Assumes SQL-Server, if not the switch in CreateWhereStatement() needs adjustment for dates
    /// </remarks>
    public class SqlGenerator
    {
        public SqlGenerator()
        {
            Separator = ',';
        }
        /// <summary>
        /// used to split values for creating IN clause
        /// </summary>
        public char Separator { get; set; }
        /// <summary>
        /// Data type for IN clause, used to determine format e.g. string has apostrophes while int does not
        /// </summary>
        public DataTypes DataType { get; set; }
        private string _inClause;
        /// <summary>
        /// Final SQL statement
        /// </summary>
        public string Statement => _inClause;
        private string _where;
        public string Where => _where;
        private bool _isValid;
        public bool IsValid => _isValid;
        /// <summary>
        /// Column name to create WHERE IN for
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// SELECT without WHERE
        /// </summary>
        public string SelectStatement { get; set; }
        /// <summary>
        /// Delimited string
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// Generate SQL SELECT/WHERE IN
        /// </summary>
        public void CreateWhereStatement()
        {

            if (!string.IsNullOrWhiteSpace(Text) && !string.IsNullOrWhiteSpace(SelectStatement))
            {

                if (!string.IsNullOrWhiteSpace(ColumnName) && !(Separator == '\0'))
                {

                    string[] splitTokensArray = Text.Split(Separator);

                    var sb = new StringBuilder();
                    var whereConcatenate = "";
                    foreach (var item in splitTokensArray)
                    {
                        switch (DataType)
                        {
                            case DataTypes.String:
                                sb.Append($"'{item.Replace("'", "''")}',");
                                whereConcatenate = $" WHERE {ColumnName} ";
                                break;
                            case DataTypes.Integer:
                            case DataTypes.Double:
                            case DataTypes.Decimal:
                                sb.Append($"{item},");
                                whereConcatenate = $" WHERE {ColumnName} ";
                                break;
                            case DataTypes.Datetime2:
                            case DataTypes.Date:
                                sb.Append($"'{item}',");
                                whereConcatenate = $" WHERE CAST({ColumnName} AS date) ";
                                break;
                            case DataTypes.DateTimeOffSet:
                                sb.Append($"'{item}',");
                                whereConcatenate = $" WHERE CAST({ColumnName} AS DATETIMEOFFSET(4))) ";
                                break;
                        }
                    }

                    var joinedTokens = sb.ToString();

                    if (joinedTokens.Last() == ',')
                    {
                        joinedTokens = joinedTokens.Substring(0, joinedTokens.Length - 1);
                    }

                    var whereTokens = "(" + joinedTokens + ")";
                    _where = whereTokens;

                    _inClause = $"{SelectStatement} {whereConcatenate} IN " + whereTokens;
                    _isValid = true;

                }
                else
                {
                    _isValid = false;
                }
            }
            else
            {
                _isValid = false;
            }
        }

    }
}