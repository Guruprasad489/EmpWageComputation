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

            EmpAttendance google = new EmpAttendance("Google", 10, 4, 20);
            google.GetMonthlyEmpWage();
            Console.WriteLine(google.ToString());

            EmpAttendance microsoft = new EmpAttendance("Microsoft", 20, 5, 20);
            microsoft.GetMonthlyEmpWage();
            Console.WriteLine(microsoft.ToString());

            EmpAttendance deloitte = new EmpAttendance("Deloitte", 30, 3, 30);
            deloitte.GetMonthlyEmpWage();
            Console.WriteLine(deloitte.ToString());

            Console.ReadLine();
        }
    }
}
