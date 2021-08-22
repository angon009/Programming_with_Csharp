using System;

namespace Pattern_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pattern Type
             1 1 1 1 1 
             2 2 2 2
             3 3 3
             4 4
             5
             Here, n = 5
             */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{n - i + 1} ");
                }
                Console.WriteLine();
            }
        }
    }
}
