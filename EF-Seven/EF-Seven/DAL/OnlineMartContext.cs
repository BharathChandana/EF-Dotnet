using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EF_Seven.Model;

namespace EF_Seven.DAL
{
    internal class OnlineMartContext:DbContext
    {
        public OnlineMartContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> categories { get; set; }
    }
}
