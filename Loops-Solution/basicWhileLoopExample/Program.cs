using System;

namespace basicWhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decimal number to binary number by using while loop

            Console.Write("Enter Decimal Number : ");
            int number = int.Parse(Console.ReadLine());

            int[] binaryNumber = new int[number];


            int result, i = 0;

            while (number != 0 && i <= 7)
            {
                result = number % 2;
                binaryNumber[i] = result;
                number = number / 2;
                i++;
            }

            for(var j = 7; j >= 0; j--)
            {
                Console.Write(binaryNumber[j]);
            }

        }
    }
}

