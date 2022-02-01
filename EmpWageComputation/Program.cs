using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Empolyee Wage Computation Program\n");

            EmpWageBuilderList empWageBuilder = new EmpWageBuilderList();
            empWageBuilder.AddCompanyEmpWageToList("Google", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWageToList("Microsoft", 20, 5, 20);
            empWageBuilder.AddCompanyEmpWageToList("Deloitte", 30, 3, 30);
            empWageBuilder.ComputeEmpWage();

            Console.ReadLine();
        }
    }
}
