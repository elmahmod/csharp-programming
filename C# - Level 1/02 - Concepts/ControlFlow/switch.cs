using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class @switch
    {

        public static void Run()
        {
            int day = 3;

            // Traditional Switch
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                case 7:
                    Console.WriteLine("Weekend");
                    break;

                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }

            // Switch with Strings
            string color = "Red";

            switch (color)
            {
                case "Red":
                    Console.WriteLine("Stop");
                    break;

                case "Yellow":
                    Console.WriteLine("Wait");
                    break;

                case "Green":
                    Console.WriteLine("Go");
                    break;

                default:
                    Console.WriteLine("Unknown Color");
                    break;
            }
        }

    }
}
