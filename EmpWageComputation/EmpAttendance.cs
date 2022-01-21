using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_FULLTIME = 1, EMP_PARTTIME = 2, EMP_WAGE_PER_HR = 20;
        static int daily_Emp_Wage = 0, empHrs = 0;
        public static void GetDailyEmpWage()
        {
                Random random = new Random();
                int randomInput = random.Next(0,3);
                if (randomInput == EMP_FULLTIME)
                {
                    empHrs = 8;
                }
                else if (randomInput == EMP_PARTTIME)
                {
                    empHrs = 4;
                }
                else
                {
                    empHrs = 0; 
                }
                daily_Emp_Wage = empHrs * EMP_WAGE_PER_HR;
                Console.WriteLine("Daily Employee Wage is: " + daily_Emp_Wage);
        }

    }
}
