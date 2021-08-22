using System;

namespace Pattern_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Pattern Type : 
             *
             * *
             * * *
             * * * *
             * * * * *
             Here, n = 5
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

        }
    }
}
