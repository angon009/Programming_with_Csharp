using System;

namespace Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            TestMethod(ref x);
            Console.WriteLine(x);
             
        }
        public static void TestMethod(ref int a)
        {
            a = 25;
        }
    }

}
