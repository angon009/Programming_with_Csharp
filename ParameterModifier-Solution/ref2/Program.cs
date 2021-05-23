using System;

namespace ref2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20, b = 25;
            Console.WriteLine($"Initial Value of a = {a}");
            Console.WriteLine($"Initial Value of b = {b}");

            Addition(a);
            Subtraction(ref b);

            Console.WriteLine($"Final Value of a = {a}");
            Console.WriteLine($"Final Value of b = {b}");
        }

        public static void Addition(int a)
        {
            a = a + 10;
        }

        public static void Subtraction(ref int b)
        {
            b = b - 5;
        }
        
    }
}
