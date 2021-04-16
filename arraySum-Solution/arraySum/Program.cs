using System;

namespace arraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all Elements of an Array : ");
            Console.Write("How many Elements = ");
            string totalTemp = Console.ReadLine();
            int totalElement = Convert.ToInt32(totalTemp);

            int[] arr = new int[totalElement];

            Console.WriteLine("Enter the elements : ");
            for(int i = 0; i < totalElement; i++)
            {
                string elementTemp = Console.ReadLine();
                int element = Convert.ToInt32(elementTemp);
                arr[i] = element;
            }
            int sum = 0;
            for(int i = 0; i < totalElement; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("Sum of all Elements = " + sum);
        }
    }
}
