using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Variables
    {
        public static void Run()
        {
            // ========================================
            // 1. Declaring and Initializing Variables
            // ========================================

            string myName = "mohammed el mahmod";
            Console.WriteLine("The name is: {0}", myName);
            Console.WriteLine($"My name is: {myName}\n");

            int x = 10, y = 20, z = 30;
            Console.WriteLine("x = " + x);
            Console.WriteLine($"y = {y}");
            Console.WriteLine("Z = {0}\n", z);

            Console.WriteLine("x + y = " + (x + y));
            Console.WriteLine("x + z = {0}", (x + z));
            Console.WriteLine($"z + y = {z + y}\n");




            // ========================================
            // 2. Updating Variables
            // ========================================

            int score = 10;
            Console.WriteLine("Original score: " + score);

            score = 20;
            Console.WriteLine("Updated score: " + score);




            // ========================================
            // 4. Constants (const)
            // ========================================

            const double PI = 3.14159D;
            Console.WriteLine("PI: " + PI);

            // PI = 3; // Error: constants cannot be reassigned.




            // ========================================
            // 5. Implicitly Typed Variables (var)
            // ========================================

            var count = 5;              // Inferred as int
            var course = "C# Level 1";  // Inferred as string

            Console.WriteLine("Count: " + count);
            Console.WriteLine("Course: " + course);

            // count = "text"; // Error: count is still an int.




            // ========================================
            // 6. Naming Rules and Conventions
            // ========================================

            int studentAge = 20;          // camelCase
            const int MAX_STUDENTS = 30; // Constant naming convention

            Console.WriteLine("Student age: " + studentAge);
            Console.WriteLine("Maximum students: " + MAX_STUDENTS);

        }
    }
}
