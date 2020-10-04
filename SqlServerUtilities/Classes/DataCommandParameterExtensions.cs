using System;
using System.Data;
using System.Linq;
using System.Text;

namespace SqlServerUtilities.Classes
{
    /// <summary>
    /// Data providers for <see cref="DataCommandParameterExtensions.ActualCommandText"/>
    /// </summary>
    public enum CommandProvider
    {
        /// <summary>
        /// SQL-Server data provider
        /// </summary>
        SqlServer,
        /// <summary>
        /// MS-Access data provider
        /// </summary>
        Access,
        /// <summary>
        /// Oracle data provider
        /// </summary>
        Oracle
    }
    /// <summary>
    /// This extension is good for viewing a SQL statement (SELECT, DELETE, UPDATE, INSERT) that
    /// use managed data provider parameters to actual see values that will be passed to the
    /// database. Has been tested with SQL-Server using @ as a parameter marker, Oracle with : as
    /// the parameter marker and MS-Access using @ as a parameter marker.
    /// 
    /// In regards to MS-Access, parameters are ordinal position so if parameters are named they
    /// must be in the same order as in the SQL statement. 
    /// 
    /// With Oracle, the command property BindByName must be set to true else the Oracle managed
    /// data provider will treat parameters as ordinal positioned.
    /// </summary>
    public static class DataCommandParameterExtensions
    {
        /// <summary> 
        /// Used to show an SQL statement with actual values for debugging or logging to a file. 
        /// </summary> 
        /// <param name="sender">Command object</param>
        /// <param name="pProvider">Data provider <see cref="CommandProvider"/></param>
        /// <param name="pQualifier">Defaults to SQL-Server</param>
        /// <returns>Command object command text with parameter values</returns> 
        public static string ActualCommandText(this IDbCommand sender, CommandProvider pProvider = CommandProvider.Oracle, string pQualifier = "@")
        {
            var sb = new StringBuilder(sender.CommandText);

            if (pProvider != CommandProvider.Oracle)
            {
                // test for at least one parameter without a name, if found stop here.
                IDataParameter emptyParameterNames =
                    (
                        from T in sender.Parameters.Cast<IDataParameter>()
                        where string.IsNullOrWhiteSpace(T.ParameterName)
                        select T
                    ).FirstOrDefault();

                if (emptyParameterNames != null)
                {
                    return sender.CommandText;
                }
            }
            else if (pProvider == CommandProvider.Oracle)
            {
                pQualifier = ":";
            }


            foreach (IDataParameter p in sender.Parameters)
            {

                if ((p.DbType == DbType.AnsiString) || (p.DbType == DbType.AnsiStringFixedLength) || (p.DbType == DbType.Date) || (p.DbType == DbType.DateTime) || (p.DbType == DbType.DateTime2) || (p.DbType == DbType.Guid) || (p.DbType == DbType.String) || (p.DbType == DbType.StringFixedLength) || (p.DbType == DbType.Time) || (p.DbType == DbType.Xml))
                {
                    if (p.ParameterName.Substring(0, 1) == pQualifier)
                    {
                        if (p.Value == null)
                        {
                            throw new Exception($"no value given for parameter '{p.ParameterName}'");
                        }

                        sb = sb.Replace(p.ParameterName, $"'{p.Value.ToString().Replace("'", "''")}'");

                    }
                    else
                    {
                        sb = sb.Replace(string.Concat(pQualifier, p.ParameterName), $"'{p.Value.ToString().Replace("'", "''")}'");
                    }
                }
                else
                {
                    /*
                     * Dummy up a INSERT Oracle statement where the RETURNING has no
                     * value for that parameter so return the parameter name instead
                     * rather than a value.
                     */
                    if (pProvider == CommandProvider.Oracle)
                    {
                        if (p.Value == null)
                        {
                            sb = sb.Replace(p.ParameterName, p.ParameterName);
                        }
                        else
                        {
                            sb = sb.Replace(p.ParameterName, p.Value.ToString());
                        }
                    }
                    else
                    {
                        sb = sb.Replace(p.ParameterName, p.Value.ToString());
                    }

                }
            }

            return sb.ToString();

        }
    }
}