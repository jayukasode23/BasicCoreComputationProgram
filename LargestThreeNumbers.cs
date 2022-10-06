using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestThreeNumbers
    {
        public static void CheckNumbers()
        {
            int num1, num2, num3;

            Console.WriteLine("Find the Largest of Three Numbers:  \n");
            Console.WriteLine("\n");

            Console.WriteLine("Input 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 2ndnumber: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 3rd number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("The 1st Number Greatest among of three. n\n");
                }
                else
                {
                    Console.WriteLine("The 3rd number Greatest among of three. n\n");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("The 2nd number Gretest among of three. n\n");
            else
                Console.WriteLine("The 3rd number Gretest among three. n\n");
        }
    }
}
