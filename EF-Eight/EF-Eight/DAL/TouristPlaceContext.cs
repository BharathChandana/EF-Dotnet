using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using EF_Eight.Models;

namespace EF_Eight.DAL
{
    internal class TouristPlaceContext : DbContext
    {
        public TouristPlaceContext():base()
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<TouristPlace> touristPlaces { get; set; }

    }
}
