using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Employee_Wage_Computation
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
