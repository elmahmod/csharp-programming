
using System;

namespace Methods
{
    internal class Program
    {
        // ========================================
        // 1. C# Methods
        // ========================================

        static void SayHello()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to C# Programming!");
        }


        // ========================================
        // 2. Method Parameters
        // ========================================

        static void GreetUser(string name, int age)
        {
            Console.WriteLine($"Hello {name}, you are {age} years old.");
        }

        static void PrintSum(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }


        // ========================================
        // 3. Default Parameter Values
        // ========================================

        static void Greet(string name = "Guest")
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        static void DisplayCountry(string name, string country = "Turkey")
        {
            Console.WriteLine($"{name} lives in {country}.");
        }


        // ========================================
        // 4. Return Values
        // ========================================

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static bool IsAdult(int age)
        {
            return age >= 18;
        }

        static string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }


        // ========================================
        // 5. Named Arguments
        // ========================================

        static void PrintPerson(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }


        // ========================================
        // 6. Method Overloading
        // ========================================

        // Overloading with different parameter counts
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }

        static int CalculateSum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloading with different parameter types
        static double CalculateSum(double a, double b)
        {
            return a + b;
        }


        // ========================================
        // 7. Main Method
        // ========================================

        static void Main(string[] args)
        {
            // ========================================
            // 1. C# Methods
            // ========================================

            Console.WriteLine("=== C# METHODS ===");

            SayHello();
            SayHello();


            // ========================================
            // 2. Method Parameters
            // ========================================

            Console.WriteLine("\n=== METHOD PARAMETERS ===");

            GreetUser("Ali", 20);
            GreetUser("Ahmed", 25);

            PrintSum(10, 20);
            PrintSum(50, 30);


            // ========================================
            // 3. Default Parameter Values
            // ========================================

            Console.WriteLine("\n=== DEFAULT PARAMETER VALUES ===");

            Greet();
            Greet("Mohammed");

            DisplayCountry("Ali");
            DisplayCountry("Ahmed", "Syria");


            // ========================================
            // 4. Return Values
            // ========================================

            Console.WriteLine("\n=== RETURN VALUES ===");

            int sum = Add(10, 20);
            Console.WriteLine("Sum: " + sum);

            double product = Multiply(5.5, 2);
            Console.WriteLine("Product: " + product);

            Console.WriteLine("Is Adult: " + IsAdult(20));

            string fullName = GetFullName("Mohammed", "Ali");
            Console.WriteLine("Full Name: " + fullName);


            // ========================================
            // 5. Named Arguments
            // ========================================

            Console.WriteLine("\n=== NAMED ARGUMENTS ===");

            // Positional Arguments
            PrintPerson("Ali", 20, "Amman");

            // Named Arguments
            PrintPerson(name: "Ahmed", age: 25, city: "Damascus");

            // Named Arguments in Different Order
            PrintPerson(city: "Istanbul", age: 22, name: "Mohammed");


            // ========================================
            // 6. Method Overloading
            // ========================================

            Console.WriteLine("\n=== METHOD OVERLOADING ===");

            // Two Integer Parameters
            Console.WriteLine("Sum (2 ints): " + CalculateSum(10, 20));

            // Three Integer Parameters
            Console.WriteLine("Sum (3 ints): " + CalculateSum(10, 20, 30));

            // Two Double Parameters
            Console.WriteLine("Sum (2 doubles): " + CalculateSum(10.5, 20.5));


            Console.ReadKey();
        }
    }
}
