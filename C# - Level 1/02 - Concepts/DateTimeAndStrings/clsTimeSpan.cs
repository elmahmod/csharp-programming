
using System;

namespace DateTimeAndStrings
{
    internal class clsTimeSpan
    {
        public static void Run()
        {
            // ========================================
            // 1. Creating TimeSpan
            // ========================================

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);

            Console.WriteLine("=== CREATING TIMESPAN ===");
            Console.WriteLine("TimeSpan: " + ts);


            // ========================================
            // 2. TimeSpan Properties
            // ========================================

            Console.WriteLine("\n=== TIMESPAN PROPERTIES ===");

            Console.WriteLine("Days: " + ts.Days);
            Console.WriteLine("Hours: " + ts.Hours);
            Console.WriteLine("Minutes: " + ts.Minutes);
            Console.WriteLine("Seconds: " + ts.Seconds);
            Console.WriteLine("Milliseconds: " + ts.Milliseconds);
            Console.WriteLine("Ticks: " + ts.Ticks);


            // ========================================
            // 3. Total TimeSpan Values
            // ========================================

            Console.WriteLine("\n=== TOTAL TIMESPAN VALUES ===");

            Console.WriteLine($"Total Days: {ts.TotalDays:F2}");
            Console.WriteLine($"Total Hours: {ts.TotalHours:F2}");
            Console.WriteLine($"Total Minutes: {ts.TotalMinutes:F2}");
            Console.WriteLine($"Total Seconds: {ts.TotalSeconds:F2}");


            // ========================================
            // 4. Adding TimeSpan to DateTime
            // ========================================

            Console.WriteLine("\n=== ADDING TIMESPAN TO DATETIME ===");

            DateTime dt = new DateTime(2026, 10, 21);

            DateTime newDate = dt.Add(ts);

            Console.WriteLine($"Original Date: {dt:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Added Duration: {ts}");
            Console.WriteLine($"New Date: {newDate:yyyy-MM-dd HH:mm:ss}");
        }
    }
}
