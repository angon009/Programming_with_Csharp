using System;

namespace multiDimensionalArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Array");
            Console.Write("Row = ");
            string rowTemp = Console.ReadLine();
            int row = Convert.ToInt32(rowTemp);

            Console.Write("Column = ");
            string colTemp = Console.ReadLine();
            int col = Convert.ToInt32(colTemp);

            int[,] mulArray = new int[row , col];
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("Array[" + i + "," + j + "] = ");
                    string elementTemp = Console.ReadLine();
                    int element = Convert.ToInt32(elementTemp);
                    mulArray[i, j] = element; 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Created Array : " );

            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write(mulArray[i , j] + "  ");
                }
                Console.WriteLine();
            }
        
        }
    }
}
