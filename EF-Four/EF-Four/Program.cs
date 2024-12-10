using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductContext context = new ProductContext();
            foreach(var p in context.Products.Include("Category").Include("Brand").Include("ProductType"))
            {
                Console.WriteLine(p.ProductId+"  "+p.Name+"  "+p.Quantity+" "+p.Price+
                  " "+p.Category.CategoryName+"  "+p.Brand.BrandName+" "+p.ProductType.ProductTypeName);
            }
        }
    }
}
