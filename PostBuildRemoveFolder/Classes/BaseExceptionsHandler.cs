using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostBuildRemoveFolder.Classes
{
    /// <summary>
    /// Provides centralize exception handling which allows a function or
    /// procedure to report back to a calling method if a runtime exception
    /// occurred.
    /// </summary>
    public class BaseExceptionsHandler
    {
        /// <summary>
        /// Used in method to indicate an exception occurred and can only
        /// be set in the current method because this is a protected field
        /// </summary>
        protected static bool mHasException;
        /// <summary> 
        /// Indicate the last operation thrown an  
        /// exception or not 
        /// </summary> 
        /// <returns></returns> 
        public bool HasException => mHasException;

        /// <summary>
        /// Represents the exception thrown in a derived class
        /// Only settable in the current method
        /// </summary>
        protected static Exception mLastException;
        /// <summary>
        /// Represents an SQL-Server exception 
        /// </summary>
        /// <remarks>Check <see cref="HasSqlServerException"></see> first</remarks>
        public SqlException SqlServerException => (SqlException)mLastException;
        /// <summary>
        /// Indicates if there was a sql related exception and if 
        /// so <see cref="SqlServerException"></see> will contain the exception.
        /// </summary>
        public bool HasSqlServerException => LastException is SqlException;
        /// <summary> 
        /// Provides access to the last exception thrown.
        /// </summary> 
        /// <returns></returns> 
        public Exception LastException => mLastException;
        /// <summary> 
        /// If you don't need the entire exception as in  
        /// LastException this provides just the text of the exception 
        /// </summary> 
        /// <returns></returns> 
        public string LastExceptionMessage => mLastException.Message;

        /// <summary> 
        /// Indicate for return of a function if there was an exception thrown or not. 
        /// </summary> 
        /// <returns></returns> 
        public bool IsSuccessFul => !mHasException;
    }
}
