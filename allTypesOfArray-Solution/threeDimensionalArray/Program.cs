using System;

namespace threeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multidimensional Array
            //Three Dimensional Array

            Console.Write("How many array = ");
            int totalArray = int.Parse(Console.ReadLine());

            Console.Write("How many Rows of every array =  ");
            int totalRow = int.Parse(Console.ReadLine());


            Console.Write("How many Columns of every array = ");
            int totalCol = int.Parse(Console.ReadLine());


            int[,,] array = new int[totalArray, totalRow, totalCol];

            //Taking inputs for array

            for(var i = 0; i < totalArray; i++)
            {
                for(var j = 0; j < totalRow; j++)
                {
                    for(var k = 0; k < totalCol; k++)
                    {
                        Console.Write($"ARRAY[{i},{j},{k}] = ");
                        int values = int.Parse(Console.ReadLine());

                        array[i, j, k] = values;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //Showing Array
            Console.WriteLine("Created Array : ");

            for (var i = 0; i < totalArray; i++)
            {
                for (var j = 0; j < totalRow; j++)
                {
                    for (var k = 0; k < totalCol; k++)
                    {
                        Console.Write(array[i,j,k] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }




        }
    }
}
