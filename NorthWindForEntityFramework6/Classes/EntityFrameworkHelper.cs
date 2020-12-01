using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindForEntityFramework6.Classes
{
    public static class EntityFrameworkHelper
    {
        public static ReadOnlyMetadataCollection<NavigationProperty> GetNavigationProperties<TEntity, TContext>() where TContext : DbContext
        {
            ObjectContext objectContext;

            using (TContext context = Activator.CreateInstance<TContext>())
            {
                objectContext = ((IObjectContextAdapter)context).ObjectContext;
            }

            var container = objectContext.MetadataWorkspace.GetEntityContainer(objectContext.DefaultContainerName, DataSpace.CSpace);
            var navigationProperties = ((EntityType)container.BaseEntitySets.First(bes => bes.ElementType.Name == typeof(TEntity).Name).ElementType).NavigationProperties;

            return navigationProperties;
        }

        public static async Task<List<string>> GeModelNames<TContext>() where TContext : DbContext
        {

            return await Task.Run(async () =>
            {
                await Task.Delay(0);
                ObjectContext objectContext;
                using (TContext context = Activator.CreateInstance<TContext>())
                {
                    objectContext = ((IObjectContextAdapter)context).ObjectContext;
                }

                var container = objectContext.MetadataWorkspace.GetEntityContainer(objectContext.DefaultContainerName, DataSpace.CSpace);

                return container.EntitySets.Select(item => item.Name).OrderBy(x => x).ToList();

            });

        }
    }
}
