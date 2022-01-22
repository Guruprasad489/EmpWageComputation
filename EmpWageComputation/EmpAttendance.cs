using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpAttendance
    {
        const int EMP_FULLTIME = 1, EMP_PARTTIME = 2, EMP_WAGE_PER_HR = 20, WORKING_DAYS_PER_MONTH = 20;
        static int daily_Emp_Wage = 0, empHrs = 0, monthly_Emp_Wage = 0, monthly_EMp_Hrs = 0;
        public static void GetMonthlyEmpWage()
        {
            Random random = new Random();
            for (int day = 1; day <= WORKING_DAYS_PER_MONTH; day++)
            {
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
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", day, daily_Emp_Wage, empHrs);
                monthly_Emp_Wage += daily_Emp_Wage;
                monthly_EMp_Hrs += empHrs;
            }
            Console.WriteLine("Monthly Employee Wage is:{0} for monthly working hours of {1}",monthly_Emp_Wage,monthly_EMp_Hrs);
        }

    }
}
