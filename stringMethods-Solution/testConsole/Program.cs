using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find frequency of a character from a string


            Console.Write("Enter DNA Sequence : ");
            string myString = Console.ReadLine().ToUpper();

            Console.Write("Which Base : ");
            char nitrogenBase = char.Parse(Console.ReadLine().ToUpper());
             

            int count = 0;
            for(var i = 0; i < myString.Length; i++)
            {
                if(myString[i] == nitrogenBase)
                {
                    count++;
                }
            }

            Console.WriteLine($"Frequency of {nitrogenBase} Base = {count}");
           
            

        }
    }
}
