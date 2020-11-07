using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCoreImages.Contexts;
using EntityFrameworkCoreImages.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreImages.Classes
{
    public class CategoryOperations
    {
        public static async Task<List<Categories>> GetCategoriesAsync()
        {

            return await Task.Run(async () =>
                {

                    using (var context = new NorthWindContext())
                    {
                        return await context.Categories.ToListAsync();
                    }

                }
            );
        }

        public static Image GetPictureBytes(int categoryIdentifier)
        {
            using (var context = new NorthWindContext())
            {
                return ImageHelpers.ByteArrayToImage(context.Categories.FirstOrDefault(cat => cat.CategoryId == categoryIdentifier).Picture);
            }
        }
    }
}
