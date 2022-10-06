using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public static void CheckHarmonicNumber()
        {
            Console.WriteLine("Enter The Value=");
            int Value = (Convert.ToInt32(Console.ReadLine()));

            double sum = 0;
            Console.WriteLine("1");

            for (double i = 1; i <= Value; i++)
            {
                Console.WriteLine(" +1/" + i);
                sum += 1 / (float)i;

            }
            Console.WriteLine("+sum");

        }
    }
}
