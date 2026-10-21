
using System;

namespace DateTimeAndStrings
{
    internal class Strings
    {
        private static void PrintSection(string title)
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(new string('=', 50));
            Console.WriteLine("  " + title);
            Console.WriteLine(new string('=', 50));

            Console.ResetColor();

            Console.WriteLine();
        }

        public static void Run()
        {
            string s1 = "Mohammed El-Mahmud";


            // ========================================
            // 1. String Length & Character Access
            // ========================================

            PrintSection("1. STRING LENGTH & CHARACTER ACCESS");

            Console.WriteLine("Original: " + s1);
            Console.WriteLine("Length: " + s1.Length);
            Console.WriteLine("Character at index 2: " + s1[2]);


            // ========================================
            // 2. String Manipulation
            // ========================================

            PrintSection("2. STRING MANIPULATION");

            Console.WriteLine("Substring: " + s1.Substring(2, 7));
            Console.WriteLine("ToLower: " + s1.ToLower());
            Console.WriteLine("ToUpper: " + s1.ToUpper());
            Console.WriteLine("Insert: " + s1.Insert(3, "KKK"));
            Console.WriteLine("Replace: " + s1.Replace("m", "*"));


            // ========================================
            // 3. Searching in Strings
            // ========================================

            PrintSection("3. SEARCHING IN STRINGS");

            Console.WriteLine("IndexOf('m'): " + s1.IndexOf("m"));
            Console.WriteLine("LastIndexOf('m'): " + s1.LastIndexOf("m"));
            Console.WriteLine("Contains('m'): " + s1.Contains("m"));
            Console.WriteLine("Contains('x'): " + s1.Contains("x"));


            // ========================================
            // 4. Splitting Strings
            // ========================================

            PrintSection("4. SPLITTING STRINGS");

            string s2 = "Ali,Ahmed,Khalid";
            string[] namesList = s2.Split(',');

            Console.WriteLine("Original: " + s2);

            for (int i = 0; i < namesList.Length; i++)
            {
                Console.WriteLine($"Name {i + 1}: {namesList[i]}");
            }


            // ========================================
            // 5. Trimming Strings
            // ========================================

            PrintSection("5. TRIMMING STRINGS");

            string s3 = "   abu-ahmed";

            Console.WriteLine($"Original:  '{s3}'");
            Console.WriteLine($"Trim:      '{s3.Trim()}'");
            Console.WriteLine($"TrimStart: '{s3.TrimStart()}'");
            Console.WriteLine($"TrimEnd:   '{s3.TrimEnd()}'");
        }
    }
}
