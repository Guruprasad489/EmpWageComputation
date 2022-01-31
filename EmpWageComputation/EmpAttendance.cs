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
        static Random random = new Random();

        private string company;
        private int emp_Wage_Per_Hr;
        private int working_Days_Per_Month;
        private int max_Hrs_Per_Month;
        private int total_Emp_Wage;

        public EmpAttendance(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Wage_Per_Hr = emp_Wage_Per_Hr;
            this.working_Days_Per_Month = working_Days_Per_Month;
            this.max_Hrs_Per_Month=max_Hrs_Per_Month;
        }

        public void GetMonthlyEmpWage()
        {
            int empHrs = 0, total_Emp_Hrs = 0, totalWorkingDays = 1, daily_Emp_Wage = 0;
            
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
            Console.WriteLine("Total Employee Wage for company " + company + " is: " + total_Emp_Wage + "\n");
        }
        public override string ToString()
        {
            return "Total Employee Wage for company: " + company + " is: " + total_Emp_Wage + "\n";
        }

    }
}
