
using System;

namespace MathAndRandom
{
    internal class Program
    {
        public static void Run()
        {
            // ========================================
            // 1. Random Numbers
            // ========================================

            Console.WriteLine("=== RANDOM NUMBERS ===");

            Random rnd = new Random();

            // Random integer from 0 to 99
            Console.WriteLine("Random (0-99): " + rnd.Next(100));

            // Random integer from 10 to 19
            Console.WriteLine("Random (10-19): " + rnd.Next(10, 20));

            // Random double from 0.0 to less than 1.0
            Console.WriteLine("Random Double: " + rnd.NextDouble());


            // ========================================
            // 2. Random Numbers Using Loop
            // ========================================

            Console.WriteLine("\n=== RANDOM NUMBERS USING LOOP ===");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Random {i + 1}: {rnd.Next(10, 20)}");
            }


            // ========================================
            // 3. Math.Max()
            // ========================================

            Console.WriteLine("\n=== MATH.MAX ===");

            Console.WriteLine("Max(5, 10): " + Math.Max(5, 10));
            Console.WriteLine("Max(25, 15): " + Math.Max(25, 15));


            // ========================================
            // 4. Math.Min()
            // ========================================

            Console.WriteLine("\n=== MATH.MIN ===");

            Console.WriteLine("Min(5, 10): " + Math.Min(5, 10));
            Console.WriteLine("Min(25, 15): " + Math.Min(25, 15));


            // ========================================
            // 5. Math.Sqrt()
            // ========================================

            Console.WriteLine("\n=== MATH.SQRT ===");

            Console.WriteLine("Sqrt(64): " + Math.Sqrt(64));
            Console.WriteLine("Sqrt(100): " + Math.Sqrt(100));
            Console.WriteLine("Sqrt(25): " + Math.Sqrt(25));


            // ========================================
            // 6. Math.Abs()
            // ========================================

            Console.WriteLine("\n=== MATH.ABS ===");

            Console.WriteLine("Abs(-4.7): " + Math.Abs(-4.7));
            Console.WriteLine("Abs(-100): " + Math.Abs(-100));
            Console.WriteLine("Abs(50): " + Math.Abs(50));


            // ========================================
            // 7. Math.Round()
            // ========================================

            Console.WriteLine("\n=== MATH.ROUND ===");

            Console.WriteLine("Round(9.99): " + Math.Round(9.99));
            Console.WriteLine("Round(9.49): " + Math.Round(9.49));
            Console.WriteLine("Round(9.75): " + Math.Round(9.75));
        }

        static void Main(string[] args)
        {
            Run();

            Console.ReadKey();
        }
    }
}
