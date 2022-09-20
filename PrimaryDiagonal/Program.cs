using System;
using System.Linq;

namespace PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrixSize; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrixSize; col++)
                    matrix[row, col] = rowData[col];
            }

            int sum = 0;

            for (int row = 0; row < matrixSize; row++)
                sum += matrix[row, row];

            Console.WriteLine(sum);
        }
    }
}
