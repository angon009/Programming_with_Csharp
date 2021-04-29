using System;

namespace frequecyCalculatorAtoZ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate frequency of a string from A to Z

            Console.Write("Enter your full name : ");
            string fullName = Console.ReadLine().ToLower();

            int[] frequency = new int[26];

             

            for (var i = 0; i < fullName.Length; i++)
            {
                 
                if (fullName[i] >= 'a' && fullName[i] <= 'z')
                {
                    frequency[fullName[i] - 97]++; // ASCII value of 'a' = 97
                }
                 
            }


            for (var i = 0; i < 26; i++)
            {
                 
                if (frequency[i] != 0)
                {
                    Console.WriteLine($"{(char)(i + 97)} = {frequency[i]}");
                }
            }

        }
    }
}
