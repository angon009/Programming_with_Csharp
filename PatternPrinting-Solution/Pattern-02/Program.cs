using System;

namespace Pattern_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Pattern Type : 
             1
             1 2 
             1 2 3 
             1 2 3 4
             1 2 3 4 5
            Here, n = 5
            */
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
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
