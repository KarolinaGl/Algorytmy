using System;

namespace Graphs
{
    class Program
    {
        static int ReadInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static int[] ReadInts()
        {
            string input = Console.ReadLine();
            return Array.ConvertAll(input.Split(' '), int.Parse);
        }

        static void PrintArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            for (int i = 1; i < rows; i++)
            {
                for (int j = 1; j < columns; j++)
                    Console.Write(array[i, j] + " ");
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            int vertices = ReadInt();
            int edges = ReadInt();

            int[,] matrix = new int[vertices + 1, vertices + 1];

            for(int i = 0; i < edges; i++)
            {
                int[] arguments = ReadInts();
                matrix[arguments[0], arguments[1]] = 1;
                matrix[arguments[1], arguments[0]] = 1;
            }
            PrintArray(matrix);
        }
    }
}
