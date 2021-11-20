using System;

namespace _02_b
{
    class P1
    {
        public static bool usingPrinter = false;

        public P1(bool isUsingPrinter)
        {
            if (isUsingPrinter && !Program.use())
                usingPrinter = isUsingPrinter;
            usingPrinter = false;
        }
    }
    class P2
    {
        public static bool usingPrinter = false;
        public P2(bool isUsingPrinter)
        {
            if (isUsingPrinter && !Program.use())
                usingPrinter = isUsingPrinter;
            usingPrinter = false;
        }
    }
    class Program
    {
        public static bool use()
        {
            return P1.usingPrinter || P2.usingPrinter;
        }

        static void Main(string[] args)
        {
            P1 p1 = new P1(true);
            P2 p2 = new P2(true);
            Console.WriteLine(use());
        }
    }
}
