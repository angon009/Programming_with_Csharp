using System;

namespace twoDimensionalJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jagged Array
            //Two Dimensional

            Console.Write("Total Arrays = ");
            int totalArray = int.Parse(Console.ReadLine());

            int[][] array = new int[totalArray][];

            Console.WriteLine();
            //Taking Inputs for array
            
            for(var i = 0; i < totalArray; i++)
            {
                Console.Write($"Size of {i+1}'th Array = ");
                int size = int.Parse(Console.ReadLine());

                array[i] = new int[size];

                for(var j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"ARRAY[{i}][{j}] = ");
                    int values = int.Parse(Console.ReadLine());

                    array[i][j] = values;
                }
                Console.WriteLine();
            }


            //Showing Array
            for (var i = 0; i < totalArray; i++)
            {                 
                for (var j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + "    ");
                }
                Console.WriteLine();
            }
        }
    }
}
