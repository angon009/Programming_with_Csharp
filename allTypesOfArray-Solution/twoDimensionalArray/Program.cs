using System;

namespace twoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multidimensional Array
            //Two dimensional Array

            Console.Write("Rows = ");
            int rowSize = int.Parse(Console.ReadLine());

            Console.Write("Columns = ");
            int colSize = int.Parse(Console.ReadLine());

            int[,] twoDimArray = new int[rowSize,colSize];

            //Taking Inputs for array

            for(var i = 0; i < rowSize; i++)
            {
                for(var j = 0; j < colSize; j++)
                {
                    Console.Write($"ARRAY[{i}][{j}] = ");
                    int values = int.Parse(Console.ReadLine());
                    twoDimArray[i, j] = values;
                }
                Console.WriteLine();
            }

            //Showing Array

            for(var i = 0; i < rowSize; i++)
            {
                for (var j = 0; j < colSize; j++)
                {
                    Console.Write(twoDimArray[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
