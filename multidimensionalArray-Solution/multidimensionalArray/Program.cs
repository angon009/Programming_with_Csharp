using System;

namespace multidimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Array");


            int[,] mulArray = new int[2, 2];
            mulArray[0 , 0] = 3;
            mulArray[0 , 1] = 4;
            mulArray[1 , 0] = 7;
            mulArray[1 , 1] = 9;

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(mulArray[i, j] + "   ");
                }
                Console.WriteLine();
                 
            }




        }
    }
}
