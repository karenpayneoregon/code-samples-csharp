using System;

namespace JsonSampleLibrary.Classes
{
    /// <summary>
    /// Container for use with delegate in CustomerOperations
    /// </summary>
    public class DeserializeException
    {
        /// <summary>
        /// namespace.class.method
        /// </summary>
        public string MethodName { get; set; }
        /// <summary>
        /// Exception thrown
        /// </summary>
        public Exception Exception { get; set; }
        /// <summary>
        /// Indicates if there is an exception
        /// </summary>
        public bool HasException => Exception != null;
    }
}
