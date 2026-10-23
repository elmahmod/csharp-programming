using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLINQ
{
    internal class Arrays
    {

        public static void Run()
        {
            // ========================================
            // 1. Array Declaration
            // ========================================

            int[] age;


            // ========================================
            // 2. Array Initialization
            // ========================================

            // Allocate memory for 5 elements
            age = new int[5];


            // ========================================
            // 3. Assign Values
            // ========================================

            age[0] = 20;
            age[1] = 25;
            age[2] = 30;
            age[3] = 35;
            age[4] = 40;


            // ========================================
            // 4. Access Array Elements
            // ========================================

            Console.WriteLine("=== ARRAY ELEMENTS ===");

            Console.WriteLine("Age 1: " + age[0]);
            Console.WriteLine("Age 2: " + age[1]);
            Console.WriteLine("Age 3: " + age[2]);
            Console.WriteLine("Age 4: " + age[3]);
            Console.WriteLine("Age 5: " + age[4]);


            // ========================================
            // 5. Array Length
            // ========================================

            Console.WriteLine("\n=== ARRAY LENGTH ===");

            Console.WriteLine("Array Length: " + age.Length);


            // ========================================
            // 6. Loop Through Array
            // ========================================

            Console.WriteLine("\n=== ARRAY USING FOR LOOP ===");

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine($"age[{i}] = {age[i]}");
            }


            // ========================================
            // 7. Short Array Initialization
            // ========================================

            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("\n=== SHORT INITIALIZATION ===");

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("\n=== Another SHORT INITIALIZATION ===");

            int[] numbers2 = new int[4] { 0, 1, 2, 3 };

            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }
        }
    }
}
