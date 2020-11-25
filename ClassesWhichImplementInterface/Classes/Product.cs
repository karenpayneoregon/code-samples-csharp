using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesWhichImplementInterface.Interfaces;

namespace ClassesWhichImplementInterface.Classes
{
    public class Product : IBase
    {
        public int ProductId { get; set; }
        public int Id => ProductId;
    }
}
