using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class ForLoop
    {
        public static void WithForLoop()
        {

            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int totalWage = 0;
            int empHrs = 0;
            int empWage = 0;
            const int EMP_RATE_PER_HR = 20;
            const int MAX_WORKING_DAYS = 20;
            int day = 1;


            Random random = new Random();
            for (day = 1; day <= MAX_WORKING_DAYS; day++)
            {


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
                empWage = EMP_RATE_PER_HR * empHrs;
                totalWage += empWage;
                Console.WriteLine("EMployee wage for DAy {0} is {1}", day, empWage);


            }
            Console.WriteLine("total wage is " + totalWage);
        }
    }
}
