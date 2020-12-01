using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindForEntityFramework6.Classes
{
    public class EntityCrawler
    {
        private IEnumerable<EntityType> _entityTypesData;

        private string[] _tableNames;
        public string[] TableNames => _tableNames;

        public string EntityModelName { get; set; }
        /// <summary>
        /// Container for a single entity, columns and keys
        /// </summary>
        public List<TableInformation> TableInformation { get; set; }
        /// <summary>
        /// Assembly for Entity Framework project
        /// </summary>
        public string AssembleName { get; set; }
        /// <summary>
        /// DbContext
        /// </summary>
        public string ContextName { get; set; }

        /// <summary>
        /// Setup for code first, EDMX will be different
        /// </summary>
        public EntityCrawler()
        {
            EntityModelName = "CodeFirstDatabaseSchema";
        }

        public EntityCrawler(string entityModelName)
        {
            EntityModelName = entityModelName;
        }
        /// <summary>
        /// Populate our list
        /// </summary>
        public void GetInformation()
        {

            try
            {
                var handle = Activator.CreateInstance(AssembleName, string.Concat(AssembleName, ".", ContextName));
                var dbContext = (DbContext)handle.Unwrap();

                var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;

                var storageMetadata = ((EntityConnection)objectContext.Connection).GetMetadataWorkspace().GetItems(DataSpace.SSpace);

                _entityTypesData = (storageMetadata.Where(globalItem => globalItem.BuiltInTypeKind == BuiltInTypeKind.EntityType).Select(globalItem => globalItem as EntityType));

                _tableNames = Tables();

                TableInformation = new List<TableInformation>();

                List<string> columnNames;
                List<string> keyNames;

                foreach (var tableName in TableNames)
                {

                    columnNames = GetColumnNames(tableName);

                    var tempEntityColumns = GetColumnInformation(tableName);

                    keyNames = new List<string>();

                    EntityType entityType = _entityTypesData.ToList().Where((item) => item.Name == tableName).FirstOrDefault();

                    // get any primary keys
                    var props = entityType?.KeyProperties;

                    if (props != null)
                    {

                        foreach (EdmProperty edmProperty in props)
                        {
                            keyNames.Add(edmProperty.ToString());
                        }

                    }

                    TableInformation.Add(new TableInformation()
                    {
                        TableName = tableName,
                        Columns = columnNames,
                        PrimaryKeyList = keyNames,
                        EntityColumnList = tempEntityColumns
                    });

                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }

        }
        /// <summary>
        /// Get all columns for table
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<string> GetColumnNames(string tableName)
        {
            var columnNames = new List<string>();

            List<ReadOnlyMetadataCollection<EdmProperty>> metaData = (
                from entityType in _entityTypesData
                where entityType.FullName == $"{EntityModelName}.{tableName}"
                select entityType.DeclaredProperties).ToList();


            foreach (ReadOnlyMetadataCollection<EdmProperty> prop in metaData)
            {
                prop.ToList().ForEach((edm) => columnNames.Add(edm.Name));
            }

            return columnNames;

        }
        /// <summary>
        /// Get column details
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<EntityColumn> GetColumnInformation(string tableName)
        {
            var list = new List<EntityColumn>();

            //            
            // * Checking FullName differs between code first and edmx
            // * code first: CodeFirstDatabaseSchema
            // * edmx: store
            //             
            List<ReadOnlyMetadataCollection<EdmProperty>> metaData = (_entityTypesData.Where((entityType) => entityType.FullName == $"{EntityModelName}.{tableName}").Select((entityTypesData) => entityTypesData.DeclaredProperties)).ToList();
            EntityType entityType1 = _entityTypesData.ToList().Where((item) => item.Name == tableName).FirstOrDefault();
            ReadOnlyMetadataCollection<EdmProperty> props = entityType1.KeyProperties;

            foreach (ReadOnlyMetadataCollection<EdmProperty> prop in metaData)
            {

                foreach (var itemEdmProperty in prop.ToList())
                {
                    bool primaryKey = false;

                    if (props != null)
                    {
                        primaryKey = props.FirstOrDefault((item) => item.Name == itemEdmProperty.Name) != null;
                    }

                    list.Add(new EntityColumn()
                    {
                        Name = itemEdmProperty.Name,
                        Type = itemEdmProperty.PrimitiveType.ClrEquivalentType,
                        TypeName = itemEdmProperty.TypeName,
                        Key = primaryKey
                    });
                }

            }

            return list;
        }

        public static string[] GetNavigationProperties(Type entityType)
        {
            return entityType.GetProperties()
                .Where(p => (typeof(IEnumerable).IsAssignableFrom(p.PropertyType) && p.PropertyType != typeof(string)) || p.PropertyType.Namespace == entityType.Namespace)
                .Select(p => p.Name)
                .ToArray();
        }

        /// <summary>
        /// Return all tables in context excluding diagrams
        /// </summary>
        /// <returns></returns>
        private string[] Tables() => 
            _entityTypesData.ToList()
                .Where((entityType) => entityType.Name != "sysdiagrams")
                .Select((item) => item.Name).ToList()
                .ToArray();
    }

}
