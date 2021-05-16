using System;

namespace DateTimeMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add days to recent date by using TimeSpan object
            TimeSpan timeSpan1 = new TimeSpan(30, 0, 0, 0);
            DateTime dateTime2 = DateTime.Now.Add(timeSpan1);
            Console.WriteLine("After adding days by using timespan  : " + dateTime2.ToString());

            //Adding days to a date
            DateTime dateToday = DateTime.Now;
            DateTime dateAfterAddingDays = dateToday.AddDays(60);
            Console.WriteLine("After adding days : " + dateAfterAddingDays.ToString());

            //Calculating Time Difference
            DateTime dateTime3 = DateTime.Now;
            DateTime dateTime4 = new DateTime(1996, 10, 11);

            TimeSpan difference = dateTime3.Subtract(dateTime4);
            Console.WriteLine("Difference = " + difference);

            //Converting to UTC
            DateTime dateTime5 = DateTime.Now;
            Console.WriteLine("In UTC : " + dateTime5.ToUniversalTime());
        }
    }
}
