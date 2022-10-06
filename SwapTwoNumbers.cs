using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            int a = 5, b = 10;
            Console.WriteLine("Befor swap a = " + a + " b = " + b);
            a = a * b;
            b = a / b;
            b = a / b;

            Console.WriteLine("Before swap a = " + a + " b = " + b);
        }
    }
}
