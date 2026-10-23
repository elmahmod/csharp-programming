using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLINQ
{
    internal class LINQ
    {
        public static void Run()
        {
            // ========================================
            // 1. Array Declaration & Initialization
            // ========================================

            int[] numbers = { 10, 20, 5, 30, 15, 10 };

            Console.WriteLine("=== ORIGINAL ARRAY ===");
            Console.WriteLine(string.Join(", ", numbers));


            // ========================================
            // 2. Minimum & Maximum
            // ========================================

            Console.WriteLine("\n=== MINIMUM & MAXIMUM ===");

            Console.WriteLine("Minimum: " + numbers.Min());
            Console.WriteLine("Maximum: " + numbers.Max());


            // ========================================
            // 3. Sum & Average
            // ========================================

            Console.WriteLine("\n=== SUM & AVERAGE ===");

            Console.WriteLine("Sum: " + numbers.Sum());
            Console.WriteLine("Average: " + numbers.Average());


            // ========================================
            // 4. Count & Length
            // ========================================

            Console.WriteLine("\n=== COUNT & LENGTH ===");

            Console.WriteLine("Count: " + numbers.Count());
            Console.WriteLine("Length: " + numbers.Length);


            // ========================================
            // 5. First & Last Elements
            // ========================================

            Console.WriteLine("\n=== FIRST & LAST ===");

            Console.WriteLine("First: " + numbers.First());
            Console.WriteLine("Last: " + numbers.Last());


            // ========================================
            // 6. Check if an Element Exists
            // ========================================

            Console.WriteLine("\n=== CONTAINS ===");

            Console.WriteLine("Contains 20: " + numbers.Contains(20));
            Console.WriteLine("Contains 100: " + numbers.Contains(100));

        }
    }
}
