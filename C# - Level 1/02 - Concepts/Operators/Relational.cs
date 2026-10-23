using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Relational
    {
        public static void Run()
        {
            int a = 10;
            int b = 5;

            Console.WriteLine("Equal: " + (a == b));
            Console.WriteLine("Not Equal: " + (a != b));
            Console.WriteLine("Greater Than: " + (a > b));
            Console.WriteLine("Less Than: " + (a < b));
            Console.WriteLine("Greater Than or Equal: " + (a >= b));
            Console.WriteLine("Less Than or Equal: " + (a <= b));
        }
    }
}
