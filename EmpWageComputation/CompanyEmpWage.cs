using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public class CompanyEmpWage
    {
        public string company;
        public int emp_Wage_Per_Hr;
        public int working_Days_Per_Month;
        public int max_Hrs_Per_Month;
        public int total_Emp_Wage;

        public CompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Wage_Per_Hr = emp_Wage_Per_Hr;
            this.working_Days_Per_Month = working_Days_Per_Month;
            this.max_Hrs_Per_Month = max_Hrs_Per_Month;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.total_Emp_Wage = totalEmpWage;
        }
        public override string ToString()
        {
            return "Total Employee Wage for company: " + company + " is: " + total_Emp_Wage + "\n";
        }
    }
}
