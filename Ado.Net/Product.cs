﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado.Net
{

    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
    }
}
