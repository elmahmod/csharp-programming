using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class whileLoop
    {

        public static void Run()
        {
            // Count from 1 to 5
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Count Backwards
            int j = 5;

            while (j >= 1)
            {
                Console.WriteLine(j);
                j--;
            }

            // Sum Numbers
            int number = 1;
            int sum = 0;

            while (number <= 5)
            {
                sum += number;
                number++;
            }

            Console.WriteLine("Sum: " + sum);
        }

    }
}
