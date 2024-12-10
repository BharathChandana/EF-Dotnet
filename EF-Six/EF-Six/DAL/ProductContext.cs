using EF_Six.ModelClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Six.DAL
{
    internal class ProductContext:DbContext
    {
        public ProductContext() :base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<ProductType> productTypes { get; set; }
        public DbSet<Product> products { get; set; }
    }
}
