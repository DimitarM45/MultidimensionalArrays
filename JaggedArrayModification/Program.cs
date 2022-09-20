using System;
using System.Linq;

namespace JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[matrixRows][];

            for (int row = 0; row < matrixRows; row++)
            {
                int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[row] = rowData;
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
                {
                    switch (command[0])
                    {
                        case "Add":
                            jaggedArray[row][col] += value;
                            break;

                        case "Subtract":
                            jaggedArray[row][col] -= value;
                            break;

                        default:
                            break;
                    }
                }

                else
                    Console.WriteLine("Invalid coordinates");

                command = Console.ReadLine().Split();
            }

            foreach (int[] array in jaggedArray)
                Console.WriteLine(string.Join(' ', array));
        }
    }
}
