using SinglyLinkedListStack;
using System;
using System.Collections.Generic;

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

        static void MatrixRepresentation()
        {
            int vertices = ReadInt();
            int edges = ReadInt();

            int[,] matrix = new int[vertices + 1, vertices + 1];

            for (int i = 0; i < edges; i++)
            {
                int[] arguments = ReadInts();
                matrix[arguments[0], arguments[1]] = 1;
                matrix[arguments[1], arguments[0]] = 1;
            }
            PrintArray(matrix);
        }

        static void PrintArrayOfLists(List<int>[] lists)
        {
            for (int i = 1; i < lists.Length; i++)
            {
                Console.Write(i + ": ");
                for (int j = 0; j < lists[i].Count; j++)
                    Console.Write(lists[i][j] + " ");
                Console.WriteLine();
            }
        }

        static void DepthFirstSearch(int currentNode, List<int>[] lists, bool[] visitedNodes, ref int counter)
        {
            counter++;
            visitedNodes[currentNode] = true;
            Console.WriteLine("Odwiedzono wierzchołek " + currentNode);
            for (int i = 0; i < lists[currentNode].Count; i++)
                if (visitedNodes[lists[currentNode][i]] == false)
                    DepthFirstSearch(lists[currentNode][i], lists, visitedNodes, ref counter);
        }

        static void DepthFirstSearchUsingStack(int vertices, List<int>[] lists)
        {
            int rootNode = 1;
            int currentNode = rootNode;
            bool[] visitedNodes = new bool[vertices + 1];
            SinglyLinkedListStack<int> stack = new SinglyLinkedListStack<int>();
            stack.Push(rootNode);
            while (stack.IsEmpty() == false)
            {
                currentNode = stack.Pop();
                if (visitedNodes[currentNode] == false)
                {
                    visitedNodes[currentNode] = true;
                    Console.WriteLine("Odwiedzono wierzchołek " + currentNode);
                    for (int i = 0; i < lists[currentNode].Count; i++)
                        if (visitedNodes[lists[currentNode][i]] == false)
                            stack.Push(lists[currentNode][i]);
                }
            }
        }

        static bool IsConnected(int vertices, List<int>[] lists)
        {
            int rootNode = 1;
            int counter = 0;

            bool[] visitedNodes = new bool[vertices + 1];

            DepthFirstSearch(rootNode, lists, visitedNodes, ref counter);
            Console.WriteLine(counter + " " + vertices);
            return counter == vertices;
        }

        static void Main(string[] args)
        {
            int vertices = ReadInt();
            int edges = ReadInt();

            List<int>[] lists = new List<int>[vertices + 1];
            for (int i = 1; i < vertices + 1; i++)
                lists[i] = new List<int>();
            for (int i = 0; i < edges; i++)
            {
                int[] arguments = ReadInts();
                lists[arguments[0]].Add(arguments[1]);
                lists[arguments[1]].Add(arguments[0]);
            }
            Console.WriteLine(IsConnected(vertices, lists));
            Console.WriteLine();
            DepthFirstSearchUsingStack(vertices, lists);
        }
    }
}
