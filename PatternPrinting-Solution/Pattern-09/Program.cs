using System;

namespace Pattern_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pattern Type
             1 2 3 4 5
             1 2 3 4
             1 2 3
             1 2
             1
             Here, n = 5
             */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
