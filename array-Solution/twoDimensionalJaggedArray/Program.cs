using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
             
            //Creating a Two Dimensional Jagged Array by taking inputs from user
            

            Console.Write("How many array : ");
            int size = int.Parse(Console.ReadLine());


            int[][] jaggedArrayThird = new int[size][];

            for(var i = 0; i < size; i++)
            {
                Console.Write($"{i}'th Array Size = ");
                int arraySize = int.Parse(Console.ReadLine());

                jaggedArrayThird[i] = new int[arraySize];
                 
                for(var j = 0; j < arraySize; j++)
                {
                    Console.Write($"Jagged Array = [{i}][{j}] = ");
                    int values = int.Parse(Console.ReadLine());
                    jaggedArrayThird[i][j] = values;
                }
                
                Console.WriteLine();
            }

            
            for (var i = 0; i < jaggedArrayThird.Length; i++)
            {
                for (var j = 0; j < jaggedArrayThird[i].Length; j++)
                {
                    Console.Write(jaggedArrayThird[i][j] + "   ");
                }
                Console.WriteLine();
            }

        }
    }
}
