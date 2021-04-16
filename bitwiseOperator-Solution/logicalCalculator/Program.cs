using System;

namespace logicalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logical Calculator
            //It will take input from user
            //This calculator will do AND , OR , XOR operation
            //It will show the result both in binary and decimal format

            Console.Write("Enter the Sirst Number : ");
            uint firstNum = uint.Parse(Console.ReadLine());

            Console.Write("Enter the Second Number : ");
            uint secondNum = uint.Parse(Console.ReadLine());

            Console.WriteLine("First Number in Binary : " + Convert.ToString(firstNum, toBase: 2)); //Converting to binary
            Console.WriteLine("Second Number in Binary : " + Convert.ToString(secondNum, toBase: 2));//Converting to binary

            uint andResult = firstNum & secondNum; // AND Operation
            uint orResult = firstNum | secondNum;  // OR Operation
            uint xorResult = firstNum ^ secondNum; // XOR Operation

            Console.WriteLine(firstNum + " AND " + secondNum + " = " + andResult);
            Console.WriteLine("In Binary : " + Convert.ToString(andResult , toBase : 2));//Converting to binary

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(firstNum + " OR " + secondNum + " = " + orResult);
            Console.WriteLine("In Binary : " + Convert.ToString(orResult , toBase : 2));//Converting to binary

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(firstNum + " XOR " + secondNum + " = " + xorResult);
            Console.WriteLine("In Binary : " + Convert.ToString(xorResult , toBase : 2));//Converting to binary

        }
    }
}
