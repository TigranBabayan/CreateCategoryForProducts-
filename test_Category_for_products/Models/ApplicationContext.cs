using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test_Category_for_products.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories  { get; set; }
        public DbSet<Product> Products  { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
