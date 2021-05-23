using System;

namespace InModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

             
            Console.WriteLine(Test(in a, in b));
        }

        public static int Test(in int a , in int b)
        {
            //a = 10; Its not Possible because in parameter is read only parameter.So it can't be modified
            int sum = a + b;
            return sum;
        }
    }
}
