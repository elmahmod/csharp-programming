using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Unary
    {
        public static void Run()
        {
            int x = 10;

            // Unary Plus
            Console.WriteLine("Unary Plus: " + (+x));

            // Unary Minus
            Console.WriteLine("Unary Minus: " + (-x));

            // Increment
            Console.WriteLine("\nPre-Increment: " + (++x));
            Console.WriteLine("Post-Increment: " + (x++));
            Console.WriteLine("After Increment: " + x);

            // Decrement
            Console.WriteLine("\nPre-Decrement: " + (--x));
            Console.WriteLine("Post-Decrement: " + (x--));
            Console.WriteLine("After Decrement: " + x);

            // Logical NOT
            bool isActive = true;
            Console.WriteLine("\nLogical NOT: " + (!isActive));

            // Bitwise Complement
            int number = 5;
            Console.WriteLine("Bitwise NOT: " + (~number));
        }
    }
}
