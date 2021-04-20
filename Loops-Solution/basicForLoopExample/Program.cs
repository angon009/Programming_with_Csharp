using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple For Loop Implementation
            //Two Series : One is incrementing in ascending order and Another one is incrementing in descending order
            //Calculate sum of same index elements and print it

            Console.Write("First value of ascending series = ");
            int firstAscOrder = int.Parse(Console.ReadLine());

            Console.Write("Last value of descending series =  ");
            int lastAscOrder = int.Parse(Console.ReadLine());

            Console.Write("First value of descending series = ");
            int firstDescOrder = int.Parse(Console.ReadLine());

            Console.Write("Last value of descending series = ");
            int lastDescOrder = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = firstAscOrder, j = firstDescOrder; i <= lastAscOrder && j >= lastDescOrder; i++, j--)
            {
                sum = i + j;
                Console.WriteLine($"{i} + {j} = {sum}");
            }
            Console.WriteLine("Successfully Compiled!!!!");
        }
    }
}
