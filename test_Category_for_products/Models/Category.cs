using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_Category_for_products.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Product { get; set; }
    }
}
