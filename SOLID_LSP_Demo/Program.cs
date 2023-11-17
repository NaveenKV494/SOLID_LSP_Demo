using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_LSP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Naveen";
            accountingVP.LastName = "Kumar";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();

            emp.FirstName = "Karthik";
            emp.LastName = "Vijay";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is Rs.{emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}
