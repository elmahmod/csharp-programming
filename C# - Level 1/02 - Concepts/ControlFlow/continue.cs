using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class @continue
    {

        public static void Run()
        {
            // Skip Number 5
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            // Print Only Odd Numbers
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            // Continue in While Loop
            int number = 0;

            while (number < 10)
            {
                number++;

                if (number == 5)
                {
                    continue;
                }

                Console.WriteLine(number);
            }
        }

    }
}
