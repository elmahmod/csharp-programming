using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class @break
    {

        public static void Run()
        {
            // Break in For Loop
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            // Break in While Loop
            int number = 1;

            while (true)
            {
                if (number > 5)
                {
                    break;
                }

                Console.WriteLine(number);
                number++;
            }

            // Break in Nested Loops
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 3)
                    {
                        break;
                    }

                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }

    }
}
