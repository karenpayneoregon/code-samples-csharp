using System.Collections.Generic;

namespace NorthWindForEntityFramework6.Classes
{
    public class TableInformation
    {
        /// <summary>
        /// Table name from model
        /// </summary>
        public string TableName { get; set; }
        public List<string> Columns { get; set; }
        public List<EntityColumn> EntityColumnList { get; set; }
        public List<string> PrimaryKeyList { get; set; }
        public override string ToString() => TableName;
    }
}