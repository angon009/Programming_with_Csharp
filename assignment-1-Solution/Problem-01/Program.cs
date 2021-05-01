using System;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution of Problem - 01
            //Printing a two dimensional Jagged Array which contains a two dimensional Array

            int[][,] jaggedArray = new int[][,]
            {
                new int[,] {
                    {1,3},
                    {5,7}
                },
                new int[,] {
                    {0,2},
                    {4,6},
                    {8,10}
                },
                new int[,] {
                    {11,22},
                    {99,88},
                    {0,9}
                }
            };

            int count;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("{ ");
                count = 0;
                for (int j = 0; j < jaggedArray[i].GetLength(count); j++)  
                                                                          
                {
                    Console.Write("{");
                    for (int k = 0; k < jaggedArray[j].Rank; k++)  
                    {
                        Console.Write(jaggedArray[i][j, k] + " , ");
                    }
                    Console.Write("},");

                }
                Console.Write(" }");
                count++;
                Console.WriteLine();
            }
            
        }
    }
}
