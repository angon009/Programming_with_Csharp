using System;

namespace Problem_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem - 02 Solution
            //Sum of all elements of a string
            string numbers = "123,343,45,45,47,23,58,42,96";

            string[] numbersString = numbers.Split(',');

            int sum = 0, realNumbersInt;


            foreach (var realNumbers in numbersString)
            {
                realNumbersInt = int.Parse(realNumbers);
                sum = sum + realNumbersInt;
            }

            Console.WriteLine("Sum = " + sum);
        }
    }
}
