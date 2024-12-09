using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOne1
{
    internal class EmployeeContext:DbContext
    {
        public EmployeeContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
        public DbSet<Employee> employees { get; set; }
    }
}
