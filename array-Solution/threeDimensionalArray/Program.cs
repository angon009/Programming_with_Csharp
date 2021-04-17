using System;

namespace threeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First Dimension : ");
            int firstDimSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the Second Dimension : ");
            int secondDimSize = int.Parse(Console.ReadLine());

            Console.Write("Enter the third Dimension : ");
            int thirdDimSize = int.Parse(Console.ReadLine());

            int[,,] thirdDimensionArray = new int[firstDimSize,secondDimSize,thirdDimSize];

            //Taking Input 
            for(var i = 0; i < firstDimSize; i++)
            {
                for(var j = 0; j < secondDimSize; j++)
                {
                    for(var k = 0; k < thirdDimSize; k++)
                    {
                        Console.Write("Array[" + i + "," + j + "," + k + "] = ");
                        int values = int.Parse(Console.ReadLine());
                        thirdDimensionArray[i, j, k] = values;
                    }
                }
                Console.WriteLine();
            }

            //Showing Output
            Console.WriteLine("Created Array : ");
            for (var i = 0; i < firstDimSize; i++)
            {
                for (var j = 0; j < secondDimSize; j++)
                {
                    for (var k = 0; k < thirdDimSize; k++)
                    {
                        Console.Write(thirdDimensionArray[i,j,k] + "   ");
                    } 
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            var size = thirdDimensionArray.Length;

            Console.WriteLine("Total Elements in that array : " + size);

            /*The length of any multi-dimensional array will be the product of all of its dimension
            and it can hold that numbers of element in it.*/
        }
    }
}
