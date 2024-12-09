using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BIgBasketContext context = new BIgBasketContext();
            Console.WriteLine("No of products " + context.products.Count());
            foreach (Product p in context.products)
            {
                Console.WriteLine(p.ProductId + " " + p.ProductName + "  " + p.ProductQuantity + "  " + p.ProductPrice);
                // Console.WriteLine($"{p.ProductId,5} {p.ProductName,30} {p.ProductQuantity,4} {p.ProductPrice}");
            }

            //Add
            /*Product x=new Product();
            Console.WriteLine("Enter PId to add :");
            x.ProductId=int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            x.ProductName=Console.ReadLine();

            Console.WriteLine("Enter Qunatity :");
            x.ProductQuantity = Console.ReadLine();

            Console.WriteLine("Enter Price :");
            x.ProductPrice = int.Parse(Console.ReadLine());

            context.products.Add(x);
            context.SaveChanges();
            Console.WriteLine("New item Added successfully ");*/

            //Find
            /*Console.WriteLine("Enter ProductId to find :");
            int PId=int.Parse(Console.ReadLine());
            Product x = context.products.Find(PId);

            if (x != null)
            {
                Console.WriteLine(x.ProductId+" "+x.ProductName+" "+x.ProductQuantity+" "+x.ProductPrice);
            }
            else
            {
                Console.WriteLine($"No item with Id {PId} is available");*/

            //Edit
            /*Console.WriteLine("Enter ProductId to Find :");
            int PId=int.Parse(Console.ReadLine());
            Product x = context.products.Find(PId);
            if(x!=null)
            {
                Console.WriteLine(x.ProductId + " " + x.ProductName + " " + x.ProductQuantity + " " + x.ProductPrice);
                Console.WriteLine("Enter new price to edit :");
                x.ProductPrice = int.Parse(Console.ReadLine());
                context.SaveChanges();
                Console.WriteLine("The price changed succesfully");
            }
            else
            {
                Console.WriteLine($"No item available with this Id {PId} is available");
            }*/

            //Delete
            Console.WriteLine("Enter ProductId to Find :");
            int PId = int.Parse(Console.ReadLine());
            Product x = context.products.Find(PId);
            if (x != null)
            {
                Console.WriteLine(x.ProductId + " " + x.ProductName + " " + x.ProductQuantity + " " + x.ProductPrice);
                context.products.Remove(x);
                context.SaveChanges();
                Console.WriteLine("Item deleted successfully");
            }
            else
            {
                Console.WriteLine($"No item available with this Id {PId} is available");
            }
        }
    }
}
