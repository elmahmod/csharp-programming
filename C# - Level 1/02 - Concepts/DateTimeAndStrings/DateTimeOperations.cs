
using System;

namespace DateTimeAndStrings
{
    internal class DateTimeOperations
    {
        public static void Run()
        {
            // ========================================
            // 1. Creating DateTime and TimeSpan
            // ========================================

            DateTime dt1 = new DateTime(2015, 12, 20);
            DateTime dt2 = new DateTime(2016, 12, 31, 5, 10, 20);

            // Days, Hours, Minutes, Seconds
            TimeSpan duration = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine("=== ORIGINAL VALUES ===");
            Console.WriteLine($"Date 1: {dt1:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Date 2: {dt2:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Duration: {duration}");


            // ========================================
            // 2. DateTime Arithmetic
            // ========================================

            Console.WriteLine("\n=== DATETIME ARITHMETIC ===");

            DateTime newDate = dt2 + duration;
            TimeSpan difference = dt2 - dt1;

            Console.WriteLine($"Date + TimeSpan: {newDate:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Date - Date: {difference}");
            Console.WriteLine($"Total Days: {difference.TotalDays:F2}");


            // ========================================
            // 3. DateTime Comparison
            // ========================================

            Console.WriteLine("\n=== DATETIME COMPARISON ===");

            Console.WriteLine($"dt1 == dt2: {dt1 == dt2}");
            Console.WriteLine($"dt1 != dt2: {dt1 != dt2}");
            Console.WriteLine($"dt1 > dt2: {dt1 > dt2}");
            Console.WriteLine($"dt1 < dt2: {dt1 < dt2}");
            Console.WriteLine($"dt1 >= dt2: {dt1 >= dt2}");
            Console.WriteLine($"dt1 <= dt2: {dt1 <= dt2}");
        }
    }
}
