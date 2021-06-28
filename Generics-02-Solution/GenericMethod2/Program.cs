using System;

namespace GenericMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Covid covid = new Covid();

            var result = covid.TestedPositive<int, Fever, SoreThroat, Cough>(new Fever(),new SoreThroat(),new Cough());
            if(result == 0)
                Console.WriteLine("Covid Positive");
            else
                Console.WriteLine("Covid Negative");


            var result2 = covid.TestedPositive<int, Fever, SoreThroat, Cough>(null , null , null);
            if (result2 != 0)
                Console.WriteLine("Covid Positive");
            else
                Console.WriteLine("Covid Negative");

        }
    }
}
