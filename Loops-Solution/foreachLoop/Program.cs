using System;

namespace foreachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimArray = new int[] { 20, 22, 22, 45, 23 };

            foreach (var values in oneDimArray)
            {
                Console.Write(values + " ");
            }

            int arraySize = int.Parse(Console.ReadLine());
            int[] twoDimArray = new int[arraySize];


        }
    }
}
