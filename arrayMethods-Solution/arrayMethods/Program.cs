using System;

namespace arrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //For reversing an Array
            int[] arrayName = new int[] { 20, 30, 40, 50, 60 };
            Array.Reverse(arrayName);

            foreach (var values in arrayName)
            {
                Console.Write(values + "   ");
            }
        }
    }
}
