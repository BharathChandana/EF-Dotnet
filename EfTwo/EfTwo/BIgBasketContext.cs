using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTwo
{
    internal class BIgBasketContext:DbContext
    {
        public BIgBasketContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().ToTable("ProductT");
        }
        public DbSet<Product>products { get; set; }
    }
}
