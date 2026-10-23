using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class forLoop
    {

        public static void Run()
        {
            // Count from 1 to 5
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            // Count Backwards
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Even Numbers
            for (int i = 0; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }

            // Multiplication Table
            int number = 5;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            // Nested For Loop
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"i = {i}, j = {j}");
                }
            }
        }

    }
}
