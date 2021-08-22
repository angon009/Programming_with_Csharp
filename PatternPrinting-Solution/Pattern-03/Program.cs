using System;

namespace Pattern_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           Pattern Type : 
            1
            2 2 
            3 3 3
            4 4 4 4
            5 5 5 5 5
           Here, n = 5
           */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }
    }
}
