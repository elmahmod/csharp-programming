using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Assignment
    {
        public static void Run()
        {
            int a = 10;
            int b = 3;

            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

            // Compound Assignment Operators
            int x = 10;

            x += 5;
            Console.WriteLine("\nAddition Assignment: " + x);

            x -= 3;
            Console.WriteLine("Subtraction Assignment: " + x);

            x *= 2;
            Console.WriteLine("Multiplication Assignment: " + x);

            x /= 4;
            Console.WriteLine("Division Assignment: " + x);

            x %= 4;
            Console.WriteLine("Modulus Assignment: " + x);
        }
    }
}
