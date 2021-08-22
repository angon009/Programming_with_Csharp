using System;

namespace Pattern_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
       Pattern Type : 
        A
        A B 
        A B C 
        A B C D 
        A B C D E
       Here, n = 5
       */
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 1; i <= n; i++)
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
