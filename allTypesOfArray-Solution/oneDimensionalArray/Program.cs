using System;

namespace oneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            Console.Write("How many elements = ");

            int totalElements = int.Parse(Console.ReadLine());

            string[] oneDimArray = new string[totalElements];

            //Taking Inputs for array
            for(var i = 0; i < oneDimArray.Length; i++)
            {
                Console.Write($"Array[{i + 1}] = ");
                string elements =  Console.ReadLine();

                oneDimArray[i] = elements;
            }

            //Showing that array
            Console.Write("Elements : ");
            for(var i = 0; i < oneDimArray.Length; i++)
            {
                Console.Write(oneDimArray[i] + "  ");
            }
        }
    }
}
