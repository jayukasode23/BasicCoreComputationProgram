using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Factors
    {
        public static void CheckPrimeFactors()
        {

            Console.WriteLine("Enter the value of number");
            int number = Convert.ToInt32(Console.ReadLine());

            int factor;
            for (factor = 1; factor <= number; factor++)
            {
                if (number % factor == 0)
                {
                    Console.WriteLine(factor + " , ");
                }
            }
        }
    }
}