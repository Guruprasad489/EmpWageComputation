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

            EmpAttendance.GetMonthlyEmpWage("Google", 20, 2, 10);
            EmpAttendance.GetMonthlyEmpWage("Microsoft", 10, 4, 20);
            EmpAttendance.GetMonthlyEmpWage("Deloitte", 15, 3, 15);
            Console.ReadLine();
        }
    }
}
