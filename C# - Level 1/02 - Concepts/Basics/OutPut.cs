
using System;

namespace Basics
{
    internal class OutPut
    {
        public static void Run()
        {
            // ========================================
            // 1. Console.WriteLine()
            // ========================================

            Console.WriteLine("Hello World!");
            Console.WriteLine("My name is Mohammed El-Mahmud");
            Console.WriteLine("I am learning C#");

            Console.WriteLine("The sum of 10 + 20 is " + (10 + 20));
            Console.WriteLine("The sum of 10 + 20 is " + "30");


            // ========================================
            // 2. Console.Write()
            // ========================================

            Console.Write("It is an easy language ");
            Console.WriteLine("to learn.");

            // Print an empty line
            Console.WriteLine();


            // ========================================
            // 3. Formatted Strings
            // ========================================

            Console.WriteLine("{0} {1}", "Welcome to", "programming");
            Console.WriteLine("I am {0} for {1}", "happy", "you");


            // ========================================
            // 4. String Formatting vs Concatenation
            // ========================================

            // Using placeholders
            Console.WriteLine("{0} + {1} = {2}", 1, 1, 1 + 1);

            // Using string concatenation
            Console.WriteLine(1 + " + " + 1 + " = " + (1 + 1));


            // ========================================
            // 5. Escape Characters
            // ========================================

            // New Line (\n)
            Console.Write("New line\n");
            Console.Write("Welcome to\nprogramming\n");

            // Tab (\t)
            Console.WriteLine("\tTab\t:");

            // Backspace (\b)
            Console.WriteLine("Welcome to \bprogramming");

            // Single Quote (\')
            Console.WriteLine("Welcome to \'programming\'");

            // Double Quote (\")
            Console.WriteLine("Welcome to \"programming\"");

            // Backslash (\\)
            Console.WriteLine("Welcome to \\ programming");

            // Alert (\a)
            Console.WriteLine("Alert\a");
        }
    }
}
