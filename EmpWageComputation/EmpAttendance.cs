using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        public const int EMP_FULLTIME=1, EMP_PARTTIME=2;
        public static void GetMonthlyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            int empHrs = 0, total_Emp_Hrs = 0, totalWorkingDays = 1, total_Emp_Wage = 0, daily_Emp_Wage = 0;

            Random random = new Random();
            while (totalWorkingDays <= working_Days_Per_Month && total_Emp_Hrs <= max_Hrs_Per_Month)
            {
                int randomInput = random.Next(0, 3);
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
                daily_Emp_Wage = empHrs * emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", totalWorkingDays, daily_Emp_Wage, empHrs);
                total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                totalWorkingDays++;
            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1}", (totalWorkingDays-1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage is: " +total_Emp_Wage + "\n");
        }

    }
}
