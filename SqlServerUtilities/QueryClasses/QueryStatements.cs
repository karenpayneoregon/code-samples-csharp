namespace SqlServerUtilities.QueryClasses
{
    /// <summary>
    /// SQL Statements for use in Informational class
    /// </summary>
    /// <remarks>
    /// If order of column names change in the SQL below make
    /// sure to update ordinal positions in methods in the class
    /// Informational
    /// </remarks>
    public class QueryStatements
    {
        /// <summary>
        /// Suitable for obtaining primary, foreign and unique keys for a specific table
        /// </summary>
        /// <returns>SELECT statement requiring parameter values for table name and Constraint type</returns>
        public static string GetKeys() =>
            @"
SELECT        c.CONSTRAINT_SCHEMA AS ConstraintSchema, c.TABLE_NAME AS TableName, p.CONSTRAINT_NAME AS ConstraintName, c.COLUMN_NAME AS ColumnName, cls.DATA_TYPE AS DataType, p.CONSTRAINT_TYPE
FROM            INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS p INNER JOIN
                         INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS c ON c.TABLE_NAME = p.TABLE_NAME AND c.CONSTRAINT_NAME = p.CONSTRAINT_NAME INNER JOIN
                         INFORMATION_SCHEMA.COLUMNS AS cls ON c.TABLE_NAME = cls.TABLE_NAME AND c.COLUMN_NAME = cls.COLUMN_NAME
WHERE        (p.CONSTRAINT_TYPE = @ConstraintType  AND c.TABLE_NAME = @TableName)
ORDER BY TableName
";
        /// <summary>
        /// Get all tables with foreign keys
        /// </summary>
        /// <returns>SQL Statement to obtain all Foreign keys for all tables in a database</returns>
        public static string ForeignKeysAllTables() =>
            @"
SELECT 
TableName = t.Name,constr.name AS ConstraintName, cols.name AS ColumnName, t2.name AS ReferencedTable, c2.name AS ReferencedColumn
FROM sys.tables t
     INNER JOIN sys.foreign_keys constr ON constr.parent_object_id = t.object_id
     INNER JOIN sys.tables t2 ON t2.object_id = constr.referenced_object_id
     INNER JOIN sys.foreign_key_columns fkc ON fkc.constraint_object_id = constr.object_id
     INNER JOIN sys.columns cols ON cols.object_id = fkc.parent_object_id AND cols.column_id = fkc.parent_column_id
     INNER JOIN sys.columns c2 ON c2.object_id = fkc.referenced_object_id AND c2.column_id = fkc.referenced_column_id
ORDER BY t.Name, cols.name;

";

        /// <summary>
        /// Get foreign keys for a single table
        /// </summary>
        /// <returns>SELECT statement to get Foreign keys for a table using a parameter</returns>
        public static string ForeignKeysForSingleTable() =>
            @"
SELECT st1.name AS TableName, constr.name AS ConstraintName, cols1.name AS ColumnName, st2.name AS ReferencedTable,  cols2.name AS ReferencedColumn
FROM sys.tables AS st1
     INNER JOIN sys.foreign_keys AS constr ON constr.parent_object_id = st1.object_id
     INNER JOIN sys.tables AS st2 ON st2.object_id = constr.referenced_object_id
     INNER JOIN sys.foreign_key_columns AS fkc ON fkc.constraint_object_id = constr.object_id
     INNER JOIN sys.columns AS cols1 ON cols1.object_id = fkc.parent_object_id
                                        AND cols1.column_id = fkc.parent_column_id
     INNER JOIN sys.columns AS cols2 ON cols2.object_id = fkc.referenced_object_id
                                        AND cols2.column_id = fkc.referenced_column_id 
WHERE st1.name = @TableName
ORDER BY TableName, ColumnName;

";
        /// <summary>
        /// Get all table names in a database
        /// </summary>
        /// <param name="databaseName"></param>
        /// <returns>SQL SELECT for obtaining table names for a database</returns>
        public static string GetTableNames(string databaseName) =>
            $"SELECT TABLE_NAME FROM [{databaseName}].INFORMATION_SCHEMA.TABLES " + 
            "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME <> 'sysdiagrams' ORDER BY TABLE_NAME";

        public static string GetColumnProperties =>
            @"
SELECT TABLE_CATALOG, 
       TABLE_SCHEMA, 
       COLUMN_NAME, 
       ORDINAL_POSITION, 
       IS_NULLABLE, 
       DATA_TYPE, 
       CHARACTER_MAXIMUM_LENGTH, 
       CHARACTER_OCTET_LENGTH, 
       NUMERIC_PRECISION, 
       NUMERIC_PRECISION_RADIX, 
       NUMERIC_SCALE, 
       DATETIME_PRECISION
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = @TableName
";

        /// <summary>
        /// Get descriptions for each column in a table, if none use column name
        /// </summary>
        /// <remarks>SQL SELECT requires a table name is the command using this statement</remarks>
        public static string ColumnDescriptionsForTable =>
            @"
SELECT C.COLUMN_NAME AS ColumnName, 
       C.ORDINAL_POSITION AS ColumnId, 
       P.value AS Description
FROM INFORMATION_SCHEMA.TABLES AS T
     INNER JOIN INFORMATION_SCHEMA.COLUMNS AS C ON C.TABLE_NAME = T.TABLE_NAME
     INNER JOIN sys.columns AS SC1 ON SC1.object_id = OBJECT_ID(T.TABLE_SCHEMA + '.' + T.TABLE_NAME)
                                      AND SC1.name = C.COLUMN_NAME
     LEFT OUTER JOIN sys.extended_properties AS P ON P.major_id = SC1.object_id
                                                     AND P.minor_id = SC1.column_id
                                                     AND P.name = 'MS_Description'
WHERE T.TABLE_NAME =  @TableName
      --AND P.value IS NOT NULL
ORDER BY ColumnId;
";

        public static string ColumnDescriptionsForTableExpanded =>
            @"
                SELECT	syso.name [Table],
		                sysc.name [Field], 
		                sysc.colorder [FieldOrder], 
		                syst.name [DataType], 
		                sysc.[length] [Length], 
		                CASE WHEN sysc.prec IS NULL THEN 'NULL' ELSE CAST(sysc.prec AS VARCHAR) END [Precision],
                CASE WHEN sysc.scale IS null THEN '-' ELSE sysc.scale END [Scale], 
                CASE WHEN sysc.isnullable = 1 THEN 'True' ELSE 'False' END [AllowNulls], 
                CASE WHEN sysc.[status] = 128 THEN 'True' ELSE 'False' END [Identity], 
                CASE WHEN sysc.colstat = 1 THEN 'True' ELSE 'False' END [PrimaryKey],
                CASE WHEN fkc.parent_object_id is NULL THEN 'False' ELSE 'True' END [ForeignKey], 
                CASE WHEN fkc.parent_object_id is null THEN '(none)' ELSE obj.name  END [RelatedTable],
                CASE WHEN ep.value is NULL THEN '(none)' ELSE CAST(ep.value as NVARCHAR(500)) END [Description]
                FROM [sys].[sysobjects] AS syso
                JOIN [sys].[syscolumns] AS sysc on syso.id = sysc.id
                LEFT JOIN [sys].[systypes] AS syst ON sysc.xtype = syst.xtype and syst.name != 'sysname'
                LEFT JOIN [sys].[foreign_key_columns] AS fkc on syso.id = fkc.parent_object_id and 
                    sysc.colid = fkc.parent_column_id    
                LEFT JOIN [sys].[objects] AS obj ON fkc.referenced_object_id = obj.[object_id]
                LEFT JOIN [sys].[extended_properties] AS ep ON syso.id = ep.major_id and sysc.colid = 
                    ep.minor_id and ep.name = 'MS_Description'
                WHERE syso.type = 'U' AND  syso.name != 'sysdiagrams'
                ORDER BY [Table], FieldOrder, Field;";
    }

}
