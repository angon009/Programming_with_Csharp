using System;

namespace BloodDonationDateCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //A calculator to find when one can donate blood after a donation

            //Last Blood Donation Date
            Console.Write("Day = ");
            int daysDonate = int.Parse(Console.ReadLine());

            Console.Write("Month = ");
            int monthDonate = int.Parse(Console.ReadLine());

            Console.Write("Year = ");
            int yearDonate = int.Parse(Console.ReadLine());

             

            DateTime nextDonationDate = new DateTime(yearDonate, monthDonate, daysDonate).AddDays(90);
            Console.WriteLine("Last Donation Date : " + nextDonationDate);

        }
    }
}
