using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindForEntityFramework6.Classes
{
    public class EntityInfo
    {
        public static async Task<List<TableInformation>> DatabaseTableInformation()
        {

            var entityCrawler = new EntityCrawler()
            {
                AssembleName = Assembly.GetExecutingAssembly().GetName().Name,
                ContextName = "NorthContext"
            };

            await Task.Run(() => entityCrawler.GetInformation());

            return entityCrawler.TableInformation;

        }
    }
}
