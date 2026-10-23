
using System;

namespace Exceptions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // ========================================
            // 1. Basic Try-Catch
            // ========================================

            Console.WriteLine("=== BASIC TRY-CATCH ===");

            try
            {
                int number1 = 10;
                int number2 = 0;

                int result = number1 / number2;

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                Console.WriteLine("Message: " + ex.Message);
            }


            // ========================================
            // 2. Multiple Catch Blocks
            // ========================================

            Console.WriteLine("\n=== MULTIPLE CATCH BLOCKS ===");

            try
            {
                string input = "abc";

                int number = int.Parse(input);

                Console.WriteLine("Number: " + number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid number format.");
                Console.WriteLine("Message: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number is too large or too small.");
                Console.WriteLine("Message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected Error: " + ex.Message);
            }


            // ========================================
            // 3. Try-Catch-Finally
            // ========================================

            Console.WriteLine("\n=== TRY-CATCH-FINALLY ===");

            try
            {
                int[] numbers = { 10, 20, 30 };

                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Array index is out of range.");
                Console.WriteLine("Message: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }


            // ========================================
            // 5. Exception Properties
            // ========================================

            Console.WriteLine("\n=== EXCEPTION PROPERTIES ===");

            try
            {
                int number = int.Parse("Hello");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Type: " + ex.GetType().Name);
                Console.WriteLine("Message: " + ex.Message);
            }


            // ========================================
            // 6. TryParse (Avoiding Exceptions)
            // ========================================

            Console.WriteLine("\n=== TRYPARSE ===");

            string inputValue = "123";

            int parsedNumber;

            bool isValid = int.TryParse(inputValue, out parsedNumber);

            if (isValid)
            {
                Console.WriteLine("Valid Number: " + parsedNumber);
            }
            else
            {
                Console.WriteLine("Invalid Number!");
            }
        }
    }
}
