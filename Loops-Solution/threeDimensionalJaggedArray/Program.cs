using System;

namespace threeDimensionalJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many array : ");

            int totalArray = int.Parse(Console.ReadLine());

            int[][][] jaggedArray = new int[totalArray][][];

            for (var i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"{i}'th Array Size = ");
                int arraySize = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[arraySize][];
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{j}'th Array Size = ");
                    int arraySize2 = int.Parse(Console.ReadLine());

                    jaggedArray[i][j] = new int[arraySize2];
                    for (var k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Console.Write($"Jagged Array = [{i}][{j}][{k}] = ");
                        int values = int.Parse(Console.ReadLine());
                        jaggedArray[i][j][k] = values;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    for (var k = 0; k < jaggedArray[i][j].Length; k++)
                    {
                        Console.Write(jaggedArray[i][j][k] + "   ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}