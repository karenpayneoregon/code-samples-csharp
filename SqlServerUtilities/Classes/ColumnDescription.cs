namespace SqlServerUtilities.Classes
{
    public class ColumnDescription
    {
        /// <summary>
        /// Column name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Position of column in columns
        /// </summary>
        public string OrdinalPosition { get; set; }
        /// <summary>
        /// Description obtained from column properties or if
        /// null uses Name of column
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// For populating a ListView
        /// </summary>
        public string[] ItemArray => new[]
        {
            Name,
            OrdinalPosition,
            Description
        };
    }
}
