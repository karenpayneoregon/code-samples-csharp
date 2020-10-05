using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerUtilities.Classes
{
    public class ColumnDefinition
    {
        public string Catalog { get; set; }
        public string Schema { get; set; }
        public string ColumnName { get; set; }
        public string OrdinalPosition { get; set; }
        public bool IsNullable { get; set; }
        public string DataType { get; set; }
        public int? CharacterMaximumLength { get; set; }
        public int? CharacterOctetLength { get; set; }
        public int? NumericPrecision { get; set; }
        public int? NumericPrecisionRadix { get; set; }
        public int? NumericScale { get; set; }
        public int? DatetimePrecision { get; set; }
        public override string ToString() => ColumnName;

    }
}
