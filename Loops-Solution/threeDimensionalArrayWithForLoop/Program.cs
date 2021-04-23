using System;

namespace threeDimensionalArrayWithForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Dimensional Array
            //Taking Dimension or Frequency

            Console.Write("How many array = ");
            int firstSize = int.Parse(Console.ReadLine());

            Console.Write("Row of every array = ");
            int secondSize = int.Parse(Console.ReadLine());

            Console.Write("Column of every array = ");
            int thirdSize = int.Parse(Console.ReadLine());


            int[,,] threeDimArray = new int[firstSize, secondSize, thirdSize];

            //Taking Values
            for (var i = 0; i < firstSize; i++)
            {
                for (var j = 0; j < secondSize; j++)
                {
                    for (var k = 0; k < thirdSize; k++)
                    {
                        Console.Write($"Array[{i}][{j}][{k}] = ");
                        int values = int.Parse(Console.ReadLine());

                        threeDimArray[i,j,k] = values;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            //Showing Values : 
            for(var i = 0; i < firstSize; i++)
            {
                for(var j = 0; j < secondSize; j++)
                {
                    for(var k = 0; k < thirdSize; k++)
                    {
                        Console.Write(threeDimArray[i,j,k] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
