using System;

namespace compareToMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare method

            string firstString;
            Console.Write("Enter a string : ");

            firstString = Console.ReadLine();

            string secondString;
            Console.Write("Enter another string : ");

            secondString = Console.ReadLine();
             

            int compareResult = firstString.CompareTo(secondString);

            Console.WriteLine(compareResult);
        }
    }
}
