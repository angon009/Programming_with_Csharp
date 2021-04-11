using System;

namespace VerySimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //A Very Simple Calculator
            int x = 10 , y = 5;
            int sum = x + y;
            int sub = x - y;
            int mul = x * y;
            int div = x / y;
            int mod = x % y;
            Console.WriteLine("Result of Addition = " + sum);
            Console.WriteLine("Result of Subtraction = " + sub);
            Console.WriteLine("Result of Multiplication = " + mul);
            Console.WriteLine("Result of Division = " + div);
            Console.WriteLine("Result of Modulus = " + mod);
             
        }
    }
}
