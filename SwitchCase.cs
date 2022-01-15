using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class SwitchCase
    {
        public void CalwithSwutch()
        {
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int totalWage = 0;
            int empHrs = 0;
            const int EMP_RATE_PER_HR = 20;

            Random random = new Random();
            int randomInput = random.Next(0, 3);

            switch (randomInput)
            {
                case FULL_TIME:
                    empHrs = 8;
                    Console.WriteLine("Employee is present fulltime");
                    break;
                case PART_TIME:
                    empHrs = 4;
                    Console.WriteLine("Employee is present parttime");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            totalWage = EMP_RATE_PER_HR * empHrs;
            Console.WriteLine("total wage is: " + totalWage);

        }
    }
}
