﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Transaction
    {
        public int Id { get; set; }
        public List<Product> SoldQty { get; set; }
        public double TotalPrice { get; set; }
       public List<Product> Products { get; set; }
        public bool IsDone { get; set; }

    }
}
