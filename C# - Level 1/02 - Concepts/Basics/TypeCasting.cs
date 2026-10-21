
using System;

namespace Basics
{
    internal class TypeCasting
    {
        public static void Run()
        {
            // ========================================
            // 1. Original Values
            // ========================================

            int iNumber = 10;
            float fNumber = 20.2f;
            double dNumber = 25.5d;
            decimal dcNumber = 30.22m;


            // ========================================
            // 2. Implicit Casting (Automatic)
            // ========================================

            // int -> float
            float myFloat = iNumber;

            // float -> double
            double myDouble = fNumber;


            Console.WriteLine("=== Implicit Casting ===");

            Console.WriteLine("int to float: " + myFloat);
            Console.WriteLine("float to double: " + myDouble);


            // ========================================
            // 3. Explicit Casting (Manual)
            // ========================================

            // float -> int
            int myInteger = (int)fNumber;

            // double -> decimal
            decimal convertedDecimal = (decimal)dNumber;

            // decimal -> double
            double convertedDouble = (double)dcNumber;

            Console.WriteLine();
            Console.WriteLine("=== Explicit Casting ===");

            Console.WriteLine("float to int: " + myInteger);
            Console.WriteLine("double to decimal: " + convertedDecimal);
            Console.WriteLine("decimal to double: " + convertedDouble);
        }
    }
}
