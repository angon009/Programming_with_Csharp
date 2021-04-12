using System;

namespace findAsciiValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character : ");
            char inputChar = Console.ReadLine()[0];

            int asciiVal = inputChar;

            Console.WriteLine("ASCII value of " + asciiVal + " is : " +asciiVal);

        }
    }
}
