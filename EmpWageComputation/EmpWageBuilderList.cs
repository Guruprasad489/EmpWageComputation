using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class EmpWageBuilderList : IComputeEmpWage
    {
        public const int EMP_FULLTIME=1, EMP_PARTTIME=2;

        private List<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyTotalWageMap;
        //private List<CompanyEmpWage> dailyAndTotalWageList;

        public static Random random = new Random();

        public EmpWageBuilderList()
        {
            companyEmpWageList = new List<CompanyEmpWage>();
            companyTotalWageMap = new Dictionary<string, CompanyEmpWage>();
            //dailyAndTotalWageList = new List<CompanyEmpWage>();
        }

        //Manage multiple companies using list
        public void AddCompanyEmpWageToList(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, emp_Wage_Per_Hr, working_Days_Per_Month, max_Hrs_Per_Month);
            companyEmpWageList.Add(companyEmpWage);
            companyTotalWageMap.Add(company, companyEmpWage);
        }


        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage empWage in companyEmpWageList)
            {
                empWage.SetTotalEmpWage(ComputeEmpWage(empWage));
                Console.WriteLine(empWage.ToString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, total_Emp_Hrs = 0, totalWorkingDays = 1, daily_Emp_Wage = 0;
            
            while (totalWorkingDays <= companyEmpWage.working_Days_Per_Month && total_Emp_Hrs <= companyEmpWage.max_Hrs_Per_Month)
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
                daily_Emp_Wage = empHrs * companyEmpWage.emp_Wage_Per_Hr;
                Console.WriteLine("Employee wage for day {0} is: {1} for {2} Hrs", totalWorkingDays, daily_Emp_Wage, empHrs);
                companyEmpWage.total_Emp_Wage += daily_Emp_Wage;
                total_Emp_Hrs += empHrs;
                totalWorkingDays++;

                //CompanyEmpWage dailyAndTotalWage = new CompanyEmpWage(companyEmpWage.company, daily_Emp_Wage, companyEmpWage.total_Emp_Wage);
                //dailyAndTotalWageList.Add(dailyAndTotalWage);

            }
            Console.WriteLine("Total Days: {0}, Total working hours: {1}", (totalWorkingDays-1), total_Emp_Hrs);
            Console.WriteLine("Total Employee Wage for company " + companyEmpWage.company + " is: " + companyEmpWage.total_Emp_Wage + "\n");
            return companyEmpWage.total_Emp_Wage;
        }  

        public int GetTotalWage(String company)
        {
            return this.companyTotalWageMap[company].total_Emp_Wage;
        }

    }
}
