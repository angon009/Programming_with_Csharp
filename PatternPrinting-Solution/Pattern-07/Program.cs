using System;

namespace Pattern_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       Pattern Type : 
        A
        B B 
        C C C 
        D D D D 
        E E E E E
       Here, n = 5
       */

            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{(char)(i + 64)} ");
                }
                Console.WriteLine();
            }
        }
    }
}
