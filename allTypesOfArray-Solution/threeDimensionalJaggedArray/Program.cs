using System;

namespace threeDimensionalJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jagged Array
            //Three Dimensional

            Console.Write("How many array = ");

            int totalArray = int.Parse(Console.ReadLine());

            int[][][] array = new int[totalArray][][];

            Console.WriteLine();
            
            //Taking Inputs For that array
            
            for(var i = 0; i < array.Length; i++)
            {
                Console.Write($"Total Array in {i}'th Position = ");
                int totalArrayIn = int.Parse(Console.ReadLine());

                array[i] = new int[totalArrayIn][];
                Console.WriteLine();

                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"Total elements in Array[{i}][{j}] = ");
                    int totalElementsIn = int.Parse(Console.ReadLine());

                    array[i][j] = new int[totalElementsIn];

                    for(var k = 0; k < array[i][j].Length; k++)
                    { 
                        Console.Write($"ARRAY[{i}][{j}][{k}] = ");
                        int elements = int.Parse(Console.ReadLine());

                        array[i][j][k] = elements;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //Showing array
            Console.WriteLine("Created Array : ");
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array[i].Length; j++)
                {
                    for (var k = 0; k < array[i][j].Length; k++)
                    {
                        Console.Write(array[i][j][k] + "    ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
