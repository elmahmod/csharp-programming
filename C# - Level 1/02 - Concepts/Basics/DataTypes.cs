using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class DataTypes
    {
        private enum enDay
        {
            Sunday,
            Monday,
            Tuesday
        }

        private struct Point
        {
            public int X;
            public int Y;
        }

        private static void printSection()
        {

        }

        public static void Run()
        {
            // ========================================
            // 1. Integer Types (Signed & Unsigned)
            // ========================================

            // 8-bit Integers
            sbyte signedByte = -100;
            byte unsignedByte = 255;

            // 16-bit Integers
            short signedShort = -32000;
            ushort unsignedShort = 65000;

            // 32-bit Integers
            int signedInt = -100000;
            uint unsignedInt = 100000U;

            // 64-bit Integers
            long signedLong = -9000000000L;
            ulong unsignedLong = 9000000000UL;

            Console.WriteLine("sbyte: " + signedByte);
            Console.WriteLine("byte: " + unsignedByte);

            Console.WriteLine("short: " + signedShort);
            Console.WriteLine("ushort: " + unsignedShort);

            Console.WriteLine("int: " + signedInt);
            Console.WriteLine("uint: " + unsignedInt);

            Console.WriteLine("long: " + signedLong);
            Console.WriteLine("ulong: " + unsignedLong);



            // ========================================
            // 2. Floating-Point and Decimal Types
            // ========================================

            float temperature = 36.5f;
            double distance = 12.75d;
            decimal price = 19.99m;

            Console.WriteLine("float: " + temperature);
            Console.WriteLine("double: " + distance);
            Console.WriteLine("decimal: " + price);


            // ========================================
            // 3. Other Common Types
            // ========================================

            char grade = 'A';
            bool isPassed = true;
            string message = "you passed";

            Console.WriteLine("char: " + grade);
            Console.WriteLine("bool: " + isPassed);
            Console.WriteLine("string: " + message);



            // ========================================
            // 4. Default Values
            // ========================================

            Console.WriteLine("Default int: " + default(int));
            Console.WriteLine("Default char: " + default(char));
            Console.WriteLine("Default bool: " + default(bool));
            Console.WriteLine("Default string is null: " + (default(string) == null));



            // ========================================
            // 5. Enums
            // ========================================

            enDay today = enDay.Monday;
            Console.WriteLine("Enum value: " + today);
            Console.WriteLine("Enum number: " + (int)today);



            // ========================================
            // 6. Nullable Value Types
            // ========================================

            int? optionalAge = null;
            Console.WriteLine("has age: " + optionalAge.HasValue);

            optionalAge = 20;
            Console.WriteLine("has age: " + optionalAge.HasValue);



            // ========================================
            // 7. Structures (struct)
            // ========================================
            Point point = new Point();
            point.X = 10;
            point.Y = 20;

            Console.WriteLine("Point: (" + point.X + ", " + point.Y + ")");



            // ========================================
            // 8. Anonymous Types
            // ========================================

            var student = new { Name = "Ali", Age = 20 };
            Console.WriteLine("Student: " + student.Name + ", " + student.Age);
            Console.WriteLine(student);

            //you cannot change the values of properties as they are read-only.

            // student.Id = 2;//Error: cannot chage value
            // student.FirstName = "Ali";//Error: cannot chage value

            //An anonymous type's property can include another anonymous type.
            var student2 = new
            {
                Id = 20,
                FirstName = "Mohammed",
                LastName = "Abu-Hadhoud",
                Address = new { Id = 1, City = "Amman", Country = "Jordan" }
            };

            Console.WriteLine("\nExample2:\n");
            Console.WriteLine(student2.Id);
            Console.WriteLine(student2.FirstName);
            Console.WriteLine(student2.LastName);

            Console.WriteLine(student2.Address.Id);
            Console.WriteLine(student2.Address.City);
            Console.WriteLine(student2.Address.Country);
            Console.WriteLine(student2.Address);




            // ========================================
            // 9. Dynamic Types
            // ========================================


            // 'dynamic' postpones type binding until runtime.
            dynamic changingValue = 10;
            Console.WriteLine("Dynamic number: " + changingValue);
            Console.WriteLine("Dynamic Type: " + changingValue.GetType());

            changingValue = "Now I am text";
            Console.WriteLine("Dynamic text: " + changingValue);
            Console.WriteLine("Dynamic Type: " + changingValue.GetType());
        }
    }
}
