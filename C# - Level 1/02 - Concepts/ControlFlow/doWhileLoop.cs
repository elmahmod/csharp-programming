using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class doWhileLoop
    {

        public static void Run()
        {
            // Count from 1 to 5
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);

            // Executes At Least Once
            int number = 10;

            do
            {
                Console.WriteLine("Executed Once");
            }
            while (number < 5);

            // Simple Menu
            int choice;

            do
            {
                Console.WriteLine("\n1. Say Hello");
                Console.WriteLine("2. Say Goodbye");
                Console.WriteLine("0. Exit");

                Console.Write("Enter Choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    choice = -1;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello!");
                        break;

                    case 2:
                        Console.WriteLine("Goodbye!");
                        break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (choice != 0);
        }

    }
}
