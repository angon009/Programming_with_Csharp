using System;

namespace Out
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Test(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Test(out int a , out int b)
        {
            a = 10;
            b = 20;
        }
    }
}
