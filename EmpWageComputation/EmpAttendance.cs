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

        public static void GetEmpAttendance()
        {
            Random random = new Random();
            int randomInput = random.Next(1, 2);
            if (randomInput==EMP_PRESENT)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

    }
}
