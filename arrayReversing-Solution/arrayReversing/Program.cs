using System;

namespace arrayReversing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reversing an Array : ");

            Console.Write("Enter the size of array = ");
            string sizeTemp = Console.ReadLine();
            int size = Convert.ToInt32(sizeTemp);

            int[] arr = new int[size];
            Console.WriteLine("Enter the elements : ");
            for (int i = 0; i < size; i++) 
            {
                string valueTemp = Console.ReadLine();
                int value = Convert.ToInt32(valueTemp);

                arr[i] = value;
            }

            Console.WriteLine("Initial Array : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + "    ");
            }
 
            Console.WriteLine();
            Console.WriteLine("Reversed Array : ");
            for(int i = size-1; i >= 0; i--)
            {
                Console.Write(arr[i] + "   ");
            }
        }
    }
}
