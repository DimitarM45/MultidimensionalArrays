using System;

namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            if (rows == 1)
                Console.WriteLine(1);

            else
            {
                long[][] pascal = new long[rows][];

                pascal[0] = new long[1] { 1 };
                pascal[1] = new long[2] { 1, 1 };

                for (int row = 2; row < pascal.GetLength(0); row++)
                {
                    pascal[row] = new long[row + 1];

                    pascal[row][0] = 1;
                    pascal[row][pascal[row].Length - 1] = 1;

                    for (int i = 1; i < pascal[row].Length - 1; i++)
                        pascal[row][i] = pascal[row - 1][i - 1] + pascal[row - 1][i];
                }

                foreach (long[] array in pascal)
                    Console.WriteLine(string.Join(' ', array));
            }
        }
    }
}
