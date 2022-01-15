using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class If_Else
    {
       
        public static void WithIfElse()
        {
            int fullTime = 1;
            int partTime = 2;
            Random random = new Random();
            int totalWage = 0;
            int empHrs = 0;
            int empRatePerHr = 20;

            int randomInput = random.Next(0, 3);


            if (randomInput == fullTime)
            {
                Console.WriteLine("Employee is present fulltime");
                empHrs = 8;
            }
            else if (randomInput == partTime)
            {
                Console.WriteLine("Employee is present partime");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }

            totalWage = empRatePerHr * empHrs;
            Console.WriteLine("Total wage is " + totalWage);

        }
    }
        
}
