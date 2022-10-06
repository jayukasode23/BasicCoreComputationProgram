using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipTheCoin
    {
        static int headCount = 0;
        static int tailcount = 0;

        static double headpercentage = 0;
        static double tailpercentage = 0;

        public static void calculatePercentage()
        {

            Console.WriteLine("Please enter the number of Flips");
            int flips = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < flips; i++)
            {

                Random random = new Random();
                int num = random.Next(2);
                Console.WriteLine("the random number from the system ---" + num);
                if (num == 0)
                {
                    Console.WriteLine("Tails");
                    tailcount++;
                }
                else if (num == 1)
                {
                    Console.WriteLine("Head");
                    headCount++;
                }
            }
            headpercentage = (headCount * 100) / flips;
            tailpercentage = (tailcount * 100) / flips;

            Console.WriteLine("HeadPercentage " + headpercentage);
            Console.WriteLine("TailPercentage " + tailpercentage);
        }
    }
}
    
