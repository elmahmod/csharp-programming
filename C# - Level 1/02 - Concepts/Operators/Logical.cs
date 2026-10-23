using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Logical
    {
        public static void Run()
        {
            bool a = false;
            bool b = true;

            Console.WriteLine("Logical AND: " + (a && b));
            Console.WriteLine("Logical OR: " + (a || b));
            Console.WriteLine("Logical NOT: " + (!a));
            Console.WriteLine("Logical XOR: " + (a ^ b));

        }
    }
}
