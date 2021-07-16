using System;

namespace testConsole
{
    class Program
    {         
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int[] arr = new int[total];

            string[] inputs = Console.ReadLine().Split(" ");
            for(int i = 0; i < total; i++)
            {
                arr[i] = int.Parse(inputs[i]);
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine(sum);
        }
    }
}
