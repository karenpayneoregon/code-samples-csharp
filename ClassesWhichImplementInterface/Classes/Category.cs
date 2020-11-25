using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesWhichImplementInterface.Interfaces;

namespace ClassesWhichImplementInterface.Classes
{
    public class Category : IBase
    {
        public int CategoryId { get; set; }

        public int Id => CategoryId;
    }
}
