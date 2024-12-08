
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOne1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext dal=new EmployeeContext();
            Console.WriteLine("No of employees :" + dal.employees.Count());
            foreach (Employee emp in dal.employees)
            {
                Console.WriteLine(emp.EmployeeId + " " + emp.EmployeeName + "  " + 
                    emp.EmployeeGender + "  " + emp.EmployeeSalary + "  " + emp.EmployeeRole );
                
            }
            //ADD
            /*Employee x = new Employee();
            Console.WriteLine("Enter employee id :");
            x.EmployeeId=int.Parse( Console.ReadLine() );

            Console.WriteLine("Enter employee name :");
            x.EmployeeName=Console.ReadLine();

            Console.WriteLine("Enter employee salary :");
            x.EmployeeSalary=int.Parse( Console.ReadLine() );

            Console.WriteLine("Enter employee gender :");
            x.EmployeeGender=Console.ReadLine();

            Console.WriteLine("Enter employee role :");
            x.EmployeeRole=Console.ReadLine();

           
            dal.employees.Add(x);
            dal.SaveChanges();
            Console.WriteLine("New item Added successfully");*/

            //Find
            /*Console.WriteLine("Enter EmployeeId to Find :");
            int EId=int.Parse( Console.ReadLine() );
            Employee x = dal.employees.Find(EId);
            if(x!=null)
            {
                Console.WriteLine(x.EmployeeId + " " + x.EmployeeName+"  "+x.EmployeeGender+"  "+
                    x.EmployeeSalary+"  "+x.EmployeeRole);
            }
            else
            {
                Console.WriteLine($"No Employee available with this ID {PId}");
            }*/

            //Edit
            /*Console.WriteLine("Enter Employee ID to Find :");
            int EId=int.Parse( Console.ReadLine() );
            Employee x = dal.employees.Find(EId);
            if( x != null )
            {
                Console.WriteLine(x.EmployeeId + " " + x.EmployeeName + "  " + x.EmployeeGender + "  " +
                    x.EmployeeSalary + "  " + x.EmployeeRole);
                Console.WriteLine("Enter a new salary :");
                x.EmployeeSalary =int.Parse( Console.ReadLine());
                Console.WriteLine("New data is updated ");
                dal.SaveChanges();
            }
            else
            {
                Console.WriteLine($"No Employee available with this Id {EId}");
            }*/

            //Delete
            Console.WriteLine("Enter a EId to delete :");
            int EId=int.Parse( Console.ReadLine() );
            Employee x = dal.employees.Find(EId);
            if( x != null )
            {
                Console.WriteLine(x.EmployeeId+" "+x.EmployeeName+" "+x.EmployeeGender+" "+
                    x.EmployeeSalary+" "+x.EmployeeRole);
                dal.employees.Remove(x);
                dal.SaveChanges();
                Console.WriteLine("Item is Deleted successfully");
            }
            else
            {
                Console.WriteLine($"with this id {EId} no available data;");
            }
             
        }
    }
}
