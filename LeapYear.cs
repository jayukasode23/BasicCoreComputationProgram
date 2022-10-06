using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public static void CheckLeapYear()
        {
            int year;
            Console.WriteLine("Enter any year");
            year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
            {
                Console.WriteLine("Leap Year " + year);
            }
            else
                Console.WriteLine("Not Leap Year " + year);

        }

    }
}
