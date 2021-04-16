using System;

namespace SimpleBitwiseOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Bitwise Operations
            while (true) // For many test 
            {
                Console.Write("Enter First Number : ");
                int firstNum = int.Parse(Console.ReadLine());

                Console.Write("Enter Second Number : ");
                int secondNum = int.Parse(Console.ReadLine());

                int andOperationResult = firstNum & secondNum;
                Console.WriteLine(firstNum + " & " + secondNum + " = " + andOperationResult);

                int orOperationResult = firstNum | secondNum;
                Console.WriteLine(firstNum + " | " + secondNum + " = " + orOperationResult);
            }
             
        }
    }
}
