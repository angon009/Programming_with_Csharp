using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum, secondNum ;
            firstNum = Console.ReadLine();
            secondNum = Console.ReadLine();
             

            int first = Convert.ToInt32(firstNum);
            int second = Convert.ToInt32(secondNum);
             

            int add = first + second;
            int sub = first - second;
            int mul = first * second;
            double div = first / second;
            int mod = first % second;

            Console.WriteLine("Result of addition = " + add);
            Console.WriteLine("Result of subtraction = " + sub);
            Console.WriteLine("Result of Multiplication = " + mul);
            Console.WriteLine("Result of Division = " + div);
            Console.WriteLine("Result of Modulas = " + mod);

            
        }
    }
}
