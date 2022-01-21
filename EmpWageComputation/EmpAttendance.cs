using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_PRESENT = 1;
        static int daily_Emp_Wage = 0, empWage_Per_Hr = 20, empHrs = 0;
        public static void GetEmpWage()
        {
                Random random = new Random();
                int randomInput = random.Next(0,2);
                if (randomInput == EMP_PRESENT)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 0;
                }
                daily_Emp_Wage = empHrs * empWage_Per_Hr;
                Console.WriteLine("Daily Employee Wage is: " + daily_Emp_Wage);
        }

    }
}
