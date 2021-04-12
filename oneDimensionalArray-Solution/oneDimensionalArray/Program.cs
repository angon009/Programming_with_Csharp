using System;

namespace oneDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One Dimensional Array");

            Console.Write("Enter the size of array = ");

            string temp = Console.ReadLine();

            int size = Convert.ToInt32(temp);

            int[] firstArr = new int[size];

            Console.WriteLine("Enter the values = ");

            for(int i = 0; i < size; i++)
            {
                string temp2 = Console.ReadLine();
                int value = Convert.ToInt32(temp2);
                firstArr[i] = value;
            }

            Console.WriteLine("Created Array : ");

            for(int i = 0; i < size; i++)
            {
                Console.Write(firstArr[i] + "    ");
            }
        }
    }
}
