﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_Category_for_products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public ushort Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
