using System;

namespace Pattern_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          Pattern Type : 
           1
           1 0 1 
           1 0 1 0
           1 0 1 0 1
           1 0 1 0 1 0
          Here, n = 5
          */


            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (j % 2 != 0) Console.Write("1 ");
                    else Console.Write("0 ");
                }
                Console.WriteLine();
            }


        }
    }
}
