using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWageToList(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month);
        void ComputeEmpWage();
        int GetTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int emp_Wage_Per_Hr;
        public int working_Days_Per_Month;
        public int max_Hrs_Per_Month;
        public int total_Emp_Wage;
        public int dailyEmpWage;

        public CompanyEmpWage(string company, int emp_Wage_Per_Hr, int working_Days_Per_Month, int max_Hrs_Per_Month)
        {
            this.company = company;
            this.emp_Wage_Per_Hr = emp_Wage_Per_Hr;
            this.working_Days_Per_Month = working_Days_Per_Month;
            this.max_Hrs_Per_Month = max_Hrs_Per_Month;
            this.total_Emp_Wage =0;
        }

        //public CompanyEmpWage(string company, int daily_Emp_Wage, int total_Emp_Wage)
        //{
        //    this.company = company;
        //    this.dailyEmpWage = daily_Emp_Wage;
        //    this.total_Emp_Wage = total_Emp_Wage;
        //}

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
