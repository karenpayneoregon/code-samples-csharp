namespace SqlServerUtilities.Classes
{
    public class Constraints
    {
        public string TableName { get; set; }
        public string ConstraintSchema { get; set; }
        public string ConstraintName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string ReferencedTable { get; set; }
        public string ReferencedColumn { get; set; }
        public override string ToString() => TableName;
    }
}
