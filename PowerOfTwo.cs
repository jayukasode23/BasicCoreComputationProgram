using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public static void CheckPowerOfTwo()
        {

            Console.WriteLine("Enter The Power Of Value ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num <= 31)
            {
                for (int i = 0; i < num; i++)
                {
                    double result = Math.Pow(2, i);
                    Console.WriteLine("2 is the power i" + i + "is " + result);

                }
            }
        }
    }
}

