using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_FULLTIME=1, EMP_PARTTIME=2, EMP_WAGE_PER_HR=20, WORKING_DAYS_PER_MONTH=20, MAX_HRS_PER_MONTH=100;
        static int daily_Emp_Wage=0, empHrs=0, total_Emp_Wage=0, total_Emp_Hrs=0, day=1;
        public static void GetMonthlyEmpWage()
        {
            Random random = new Random();
            while (day <= WORKING_DAYS_PER_MONTH && total_Emp_Hrs <= MAX_HRS_PER_MONTH)
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
                daily_Emp_Wage = empHrs * EMP_WAGE_PER_HR;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", day, daily_Emp_Wage, empHrs);
                total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                day++;
            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1}", (day-1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage is: " +total_Emp_Wage);
        }

    }
}
