using System;

namespace Pattern_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pattern Type
            A A A A A
            B B B B
            C C C
            D D 
            E
            Here, n = 5
            */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)((n - i + 1) + 64)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
