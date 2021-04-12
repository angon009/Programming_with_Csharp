using System;

namespace minuteToYearAndDate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total Minutes = ");
            string minsTemp = Console.ReadLine();

            int mins = Convert.ToInt32(minsTemp);

            int years = mins / 525600;

            int remMins = mins - (years * 525600);

            int days = remMins / 1440;

            Console.WriteLine(mins + " minutes = " + years + " years and " + days + " days");


        }
    }
}
