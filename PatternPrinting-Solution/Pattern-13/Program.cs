using System;

namespace Pattern_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pattern Type
             A B C D E
             A B C D
             A B C
             A B
             A
             Here, n = 5
             */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = n; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)(j + 64)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
