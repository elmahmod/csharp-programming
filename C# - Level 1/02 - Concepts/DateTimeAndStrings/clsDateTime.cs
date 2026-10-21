
using System;

namespace DateTimeAndStrings
{
    internal class clsDateTime
    {
        public static void Run()
        {
            // ========================================
            // 1. Default DateTime
            // ========================================

            DateTime dt1 = new DateTime();

            Console.WriteLine("=== DEFAULT DATETIME ===");
            Console.WriteLine($"Date: {dt1:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Kind: {dt1.Kind}");


            // ========================================
            // 2. Date Only
            // ========================================

            DateTime dt2 = new DateTime(2026, 10, 21);

            Console.WriteLine("\n=== DATE ONLY ===");
            Console.WriteLine($"Date: {dt2:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Kind: {dt2.Kind}");


            // ========================================
            // 3. Date and Time
            // ========================================

            DateTime dt3 = new DateTime(2026, 10, 21, 9, 56, 10);

            Console.WriteLine("\n=== DATE AND TIME ===");
            Console.WriteLine($"Date: {dt3:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Kind: {dt3.Kind}");


            // ========================================
            // 4. UTC DateTime
            // ========================================

            DateTime dt4 = new DateTime(
                2026, 10, 21, 9, 56, 10, DateTimeKind.Utc
            );

            Console.WriteLine("\n=== UTC DATETIME ===");
            Console.WriteLine($"UTC: {dt4:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Kind: {dt4.Kind}");
            Console.WriteLine($"Local: {dt4.ToLocalTime():yyyy-MM-dd HH:mm:ss}");


            // ========================================
            // 5. Current Date and Time
            // ========================================

            Console.WriteLine("\n=== CURRENT DATE AND TIME ===");
            Console.WriteLine($"Now: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"UTC Now: {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Today: {DateTime.Today:yyyy-MM-dd}");


            // ========================================
            // 6. Tick Constants
            // ========================================

            Console.WriteLine("\n=== TICK CONSTANTS ===");

            Console.WriteLine($"Ticks per Millisecond: {TimeSpan.TicksPerMillisecond}");
            Console.WriteLine($"Ticks per Second: {TimeSpan.TicksPerSecond}");
            Console.WriteLine($"Ticks per Minute: {TimeSpan.TicksPerMinute}");
            Console.WriteLine($"Ticks per Hour: {TimeSpan.TicksPerHour}");
            Console.WriteLine($"Ticks per Day: {TimeSpan.TicksPerDay}");

            DateTime date1 = new DateTime(2026, 10, 21, 10, 0, 0);
            DateTime date2 = new DateTime(2026, 10, 21, 10, 0, 1);

            long difference = date2.Ticks - date1.Ticks;

            Console.WriteLine(difference); // 10 000 000 = 1 second
        }
    }
}
