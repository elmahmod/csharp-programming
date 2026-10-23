using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class BitwiseAndBitShift
    {
        public static void Run()
        {
            int a = 5; // Binary: 0101
            int b = 3; // Binary: 0011

            // =====================================
            // 1. Bitwise AND (&)
            // =====================================

            Console.WriteLine("Bitwise AND (&)");
            Console.WriteLine("5 & 3 = " + (a & b)); // 1


            // =====================================
            // 2. Bitwise OR (|)
            // =====================================

            Console.WriteLine("\nBitwise OR (|)");
            Console.WriteLine("5 | 3 = " + (a | b)); // 7


            // =====================================
            // 3. Bitwise XOR (^)
            // =====================================

            Console.WriteLine("\nBitwise XOR (^)");
            Console.WriteLine("5 ^ 3 = " + (a ^ b)); // 6


            // =====================================
            // 4. Bitwise Complement (~)
            // =====================================

            Console.WriteLine("\nBitwise NOT (~)");
            Console.WriteLine("~5 = " + (~a)); // -6


            // =====================================
            // 5. Left Shift (<<)
            // =====================================

            Console.WriteLine("\nLeft Shift (<<)");

            Console.WriteLine("5 << 1 = " + (a << 1)); // 10 ( 5 * 2 )
            Console.WriteLine("5 << 2 = " + (a << 2)); // 20 ( 5 * 4 )
            Console.WriteLine("5 << 3 = " + (a << 3)); // 40 ( 5 * 8 )


            // =====================================
            // 6. Right Shift (>>)
            // =====================================

            Console.WriteLine("\nRight Shift (>>)");

            int x = 40;

            Console.WriteLine("40 >> 1 = " + (x >> 1)); // 20 ( 5 / 2 )
            Console.WriteLine("40 >> 2 = " + (x >> 2)); // 10 ( 5 / 4 )
            Console.WriteLine("40 >> 3 = " + (x >> 3)); // 5  ( 5 / 8 )


            // =====================================
            // 7. Compound Shift Assignment
            // =====================================

            Console.WriteLine("\nCompound Shift Assignment");

            int number = 5;

            number <<= 2;
            Console.WriteLine("After <<= 2: " + number); // 20

            number >>= 1;
            Console.WriteLine("After >>= 1: " + number); // 10


            // =====================================
            // 8. Binary Representation
            // =====================================

            Console.WriteLine("\nBinary Representation");

            Console.WriteLine("5 in Binary: " +
                Convert.ToString(5, 2)); // (number, binary )

            Console.WriteLine("3 in Binary: " +
                Convert.ToString(3, 2));

            Console.WriteLine("5 & 3 in Binary: " +
                Convert.ToString(a & b, 2));

            Console.WriteLine("5 | 3 in Binary: " +
                Convert.ToString(a | b, 2));

            Console.WriteLine("5 ^ 3 in Binary: " +
                Convert.ToString(a ^ b, 2));

            Console.WriteLine("5 << 1 in Binary: " +
                Convert.ToString(a << 1, 2));

            Console.WriteLine("40 >> 1 in Binary: " +
                Convert.ToString(x >> 1, 2));
        }
    }
}
