using System;

namespace Pattern_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pattern Type
            * 
            * * 
            * * *
            * * * *
            * * *
            * *
            * 
            Here, n = 4
            */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
