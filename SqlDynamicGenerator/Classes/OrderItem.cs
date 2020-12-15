using System;
using System.Collections.Generic;
using SqlHelperLibrary.Models;

namespace SqlDynamicGenerator.Classes
{
    public class OrderItem
    {
        public DateTime? OrderDateTime { get; set; }
        public List<Orders> OrderList { get; set; }
    }
}