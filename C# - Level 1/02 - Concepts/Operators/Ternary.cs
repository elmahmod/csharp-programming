using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Ternary
    {
        public static void Run()
        {
            int age = 20;

            string result = (age >= 18) ? "Adult" : "Minor";

            Console.WriteLine("Age Category: " + result);

            // Find the larger number
            int a = 10;
            int b = 20;

            int max = (a > b) ? a : b;

            Console.WriteLine("Maximum Number: " + max);

            // Even or Odd
            int number = 7;

            string evenOrOdd = (number % 2 == 0)
                ? "Even"
                : "Odd";

            Console.WriteLine("Number Type: " + evenOrOdd);
        }
    }
}
