using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class QuotientAndRemainder
    {
        public static void CheckQuotientAndRemainder()
        {
            int divident = 60, divisor = 9;

            int quotient = divident / divisor;
            int remainder = divident % divisor;

            Console.WriteLine("Quatient :" + quotient);
            Console.WriteLine("Remainder :" + remainder);
        }
    }
}