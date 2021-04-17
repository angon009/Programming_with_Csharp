using System;

namespace twoDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two dimensional Array
            Console.Write("Enter the First Dimension Size : ");
            int firstDimSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Dimension Size : ");
            int secondDimSize = int.Parse(Console.ReadLine());

            int[,] twoDimensionalArray = new int[firstDimSize, secondDimSize];

            //Taking Input
            for(var i = 0; i < firstDimSize; i++)
            {
                for(var j = 0; j < secondDimSize; j++)
                {
                    Console.Write("Array[" + i + "," + j + "] = ");
                    int values = int.Parse(Console.ReadLine());
                    twoDimensionalArray[i, j] = values;
                }
                Console.WriteLine();
            }

            //Showing Output
            Console.WriteLine("Created Array : ");
            for(var i = 0; i < firstDimSize; i++)
            {
                for(var j = 0; j < secondDimSize; j++)
                {
                    Console.Write(twoDimensionalArray[i,j] + "   ");
                }
                Console.WriteLine();
            }


        }
    }
}
