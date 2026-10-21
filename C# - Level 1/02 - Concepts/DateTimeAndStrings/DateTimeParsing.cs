
using System;

namespace DateTimeAndStrings
{
    internal class DateTimeParsing
    {
        public static void Run()
        {
            // ========================================
            // 1. Valid Date String
            // ========================================

            Console.WriteLine("=== VALID DATE STRING ===");

            string str1 = "6/12/2023";
            DateTime dt1;

            bool isValidDate1 = DateTime.TryParse(str1, out dt1);

            if (isValidDate1)
            {
                Console.WriteLine("Input: " + str1);
                Console.WriteLine("Valid: " + isValidDate1);
                Console.WriteLine("Date: " + dt1.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine($"{str1} is not a valid date string.");
            }


            // ========================================
            // 2. Invalid Date String
            // ========================================

            Console.WriteLine("\n=== INVALID DATE STRING ===");

            string str2 = "6/65/2023";
            DateTime dt2;

            bool isValidDate2 = DateTime.TryParse(str2, out dt2);

            if (isValidDate2)
            {
                Console.WriteLine("Input: " + str2);
                Console.WriteLine("Valid: " + isValidDate2);
                Console.WriteLine("Date: " + dt2.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine($"{str2} is not a valid date string.");
            }
        }
    }
}
