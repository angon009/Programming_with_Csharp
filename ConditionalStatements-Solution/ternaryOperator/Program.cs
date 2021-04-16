using System;

namespace ternaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Largest among three Numbers
            By Using Ternary Operator
            Ternary Operator saves code lines 
            Don't create too much branch on ternary condition
            Too much Branching make a 
            program more complex
            */

            Console.Write("Enter First Number : ");
            var firstNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            Console.Write("Enter Second Number : ");
            var secondNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            Console.Write("Enter Third Number : ");
            var thirdNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            int largest;

            largest = (firstNum >= secondNum && firstNum >= thirdNum) ? firstNum : (secondNum >= firstNum && secondNum >= thirdNum) ? secondNum : thirdNum;
            


            Console.WriteLine(largest + " is Largest!!!");
        }
    }
}
