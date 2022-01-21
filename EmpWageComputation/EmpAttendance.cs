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
                switch (randomInput)
                {
                    case EMP_FULLTIME:
                        empHrs = 8;
                        break;
                    case EMP_PARTTIME:
                        empHrs = 4;
                        break;
                    default: 
                        empHrs = 0;
                        break;
                }
                
                daily_Emp_Wage = empHrs * EMP_WAGE_PER_HR;
                Console.WriteLine("Daily Employee Wage is: " + daily_Emp_Wage);
        }

    }
}
