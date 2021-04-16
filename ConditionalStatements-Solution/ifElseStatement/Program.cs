using System;

namespace ifElseStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Largest Among Three Numbers
            //Using if-else statement 


            Console.Write("Enter First Number : ");
            var firstNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            Console.Write("Enter Second Number : ");
            var secondNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            Console.Write("Enter Third Number : ");
            var thirdNum = int.Parse(Console.ReadLine()); //Taking input in Integer

            int largest; //This variable will hold the largest number

            if(firstNum >= secondNum && firstNum >= thirdNum)
            {
                largest = firstNum;
            }
            else if(secondNum >= firstNum && secondNum >= thirdNum)
            {
                largest = secondNum;
            }
            else
            {
                largest = thirdNum;
            }
            Console.WriteLine(largest + " is Largest!!!!");
        }
    }
}
