using System;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var lineNumber = Console.ReadLine();
            var individualNumber = lineNumber.Split(',');

            var firstPart = int.Parse(individualNumber[0]);
            var secondPart = double.Parse(individualNumber[1]);
            var thirdPart = int.Parse(individualNumber[2]);

             
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);
            Console.WriteLine(thirdPart);


             
        }
    }
}
