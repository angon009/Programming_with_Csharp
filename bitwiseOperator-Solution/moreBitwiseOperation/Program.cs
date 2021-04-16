using System;

namespace moreBitwiseOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a number in binary System
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int andResultNum = firstNum & secondNum;
            string andResult = Convert.ToString(andResultNum , toBase : 2);
            Console.WriteLine("And Operation Result : " + andResultNum + "  In Binary : " + andResult);

            int orResultNum = firstNum | secondNum;
            string orResult = Convert.ToString(orResultNum , toBase : 2);
            Console.WriteLine("Or Operation Result : " + orResultNum + "  In Binary : " + orResult);
        }
    }
}
