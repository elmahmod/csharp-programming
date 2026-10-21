
using System;

namespace Basics
{
    internal class UserInput
    {
        public static void Run()
        {
            // ========================================
            // 1. Reading String Input
            // ========================================

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Please enter your phone number: ");
            string phone = Console.ReadLine();


            // ========================================
            // 2. Reading Integer Input
            // ========================================

            Console.Write("Please enter your age: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Please enter your height (cm): ");
            int height = Convert.ToInt32(Console.ReadLine());


            // ========================================
            // 3. Reading Decimal Input
            // ========================================

            Console.Write("Please enter your account balance: ");
            decimal balance = Convert.ToDecimal(Console.ReadLine());


            // ========================================
            // 4. Displaying User Information
            // ========================================

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("           USER INFORMATION");
            Console.WriteLine("========================================");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Account Balance: {balance}");

            Console.WriteLine("========================================");
        }
    }
}
