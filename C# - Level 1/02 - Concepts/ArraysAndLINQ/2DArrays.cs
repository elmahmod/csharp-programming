using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLINQ
{
    internal class _2DArrays
    {
        public static void Run()
        {
            // ========================================
            // 1. 2D Array Declaration
            // ========================================

            int[,] numbers;


            // ========================================
            // 2. 2D Array Initialization
            // ========================================

            // 2 Rows, 3 Columns
            numbers = new int[2, 3];


            // ========================================
            // 3. Assign Values
            // ========================================

            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 30;

            numbers[1, 0] = 40;
            numbers[1, 1] = 50;
            numbers[1, 2] = 60;


            // ========================================
            // 4. Access Array Elements
            // ========================================

            Console.WriteLine("=== ARRAY ELEMENTS ===");

            Console.WriteLine("numbers[0, 0]: " + numbers[0, 0]);
            Console.WriteLine("numbers[0, 1]: " + numbers[0, 1]);
            Console.WriteLine("numbers[1, 2]: " + numbers[1, 2]);


            // ========================================
            // 5. Array Dimensions & Length
            // ========================================

            Console.WriteLine("\n=== ARRAY DIMENSIONS ===");

            Console.WriteLine("Rows: " + numbers.GetLength(0));
            Console.WriteLine("Columns: " + numbers.GetLength(1));
            Console.WriteLine("Total Elements: " + numbers.Length);
            Console.WriteLine("Dimensions: " + numbers.Rank);


            // ========================================
            // 6. Nested For Loop
            // ========================================

            Console.WriteLine("\n=== 2D ARRAY USING FOR LOOP ===");

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + "\t");
                }

                Console.WriteLine();
            }


            // ========================================
            // 7. Short Array Initialization
            // ========================================

            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("\n=== SHORT INITIALIZATION ===");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }

                Console.WriteLine();
            }


            int[,] matrix2 = new int[3, 3]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine("\n=== Another SHORT INITIALIZATION ===");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix2[row, col] + "\t");
                }

                Console.WriteLine();
            }
        }

    }
}
