using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class @if
    {

        public static void Run()
        {
            int age = 20;
            int grade = 85;
            bool hasID = true;

            // Simple If
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }

            // If-Else
            if (age >= 18)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Minor");
            }

            // If-Else If-Else
            if (grade >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Needs Improvement");
            }

            // Nested If
            if (age >= 18)
            {
                if (hasID)
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    Console.WriteLine("ID Required");
                }
            }
            else
            {
                Console.WriteLine("Underage");
            }
        }

    }
}
