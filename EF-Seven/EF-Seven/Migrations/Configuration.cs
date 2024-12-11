namespace EF_Seven.Migrations
{
    using EF_Seven.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Seven.DAL.OnlineMartContext>
    {
        List<Category> categorieslist = new List<Category>()
        {
            new Category{ CategoryId =101,CategoryName="Fresh Fruits"},
            new Category{CategoryId=102,CategoryName="Fresh Vegetables"},
            new Category{CategoryId=103,CategoryName="Flower Bouquets"}
        };
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EF_Seven.DAL.OnlineMartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            if(context.categories.Count()==0)
            {
                foreach(var c in  categorieslist)
                {
                    context.categories.Add(c);
                }
                context.SaveChanges();
            }
        }
    }
}
