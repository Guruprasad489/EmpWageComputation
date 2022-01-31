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

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("Google", 10, 4, 20);
            empWageBuilder.AddCompanyEmpWage("Microsoft", 20, 5, 20);
            empWageBuilder.AddCompanyEmpWage("Deloitte", 30, 3, 30);
            empWageBuilder.ComputeEmpWage();

            Console.ReadLine();
        }
    }
}
