using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductContext context = new ProductContext();
            Console.WriteLine("No of products "+ context.products.Count());
            //ADD
            /*Product x = new Product();
            Console.WriteLine("Enter ProductId :");
            x.Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            x.Name=Console.ReadLine();
            Console.WriteLine("Enter Quantity :");
            x.Quantity=Console.ReadLine();
            Console.WriteLine("Enter Price");
            x.Price=Convert.ToDecimal(Console.ReadLine());

            context.products.Add(x);
            context.SaveChanges();
            Console.WriteLine("Item added succesfully ");*/

            
            foreach (Product x in context.products)
            {
                Console.WriteLine(x.Id+"  "+x.Name+"  "+x.Quantity+"  "+x.Price);
            }

            //Find
            /*Console.WriteLine("Enter PId to Find :");
            int PId=int.Parse(Console.ReadLine());
            Product p=context.products.Find(PId);
            if (p != null)
            {
                Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Quantity + "  " + p.Price);
            }
            else
            {
                Console.WriteLine($"No item with this Id {PId} is available");
            }*/

            //Edit
            /*Console.WriteLine("Enter PId to Find :");
            int PId = int.Parse(Console.ReadLine());
            Product p = context.products.Find(PId);
            if (p != null)
            {
                Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Quantity + "  " + p.Price);
                Console.WriteLine("Enter new Price ");
                p.Price = int.Parse(Console.ReadLine());
                context.SaveChanges();
                Console.WriteLine("Price is Changed successfully ");
            }
            else
            {
                Console.WriteLine($"No item with this Id {PId} is available");
            }*/

            //Delete
            Console.WriteLine("Enter PId to Find :");
            int PId = int.Parse(Console.ReadLine());
            Product p = context.products.Find(PId);
            if (p != null)
            {
                Console.WriteLine(p.Id + "  " + p.Name + "  " + p.Quantity + "  " + p.Price);
                context.products.Remove(p);    
                context.SaveChanges();
                Console.WriteLine("Product is Deleted successfully ");
            }
            else
            {
                Console.WriteLine($"No item with this Id {PId} is available");
            }
        }
    }
}
