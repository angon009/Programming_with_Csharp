using System;

namespace DateTimeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.Year + " years");
            Console.WriteLine(dateTime.Month + " months");
            Console.WriteLine(dateTime.Day + " days");
            Console.WriteLine(dateTime.Hour + " hours");
            Console.WriteLine(dateTime.Minute + " minutes");
            Console.WriteLine(dateTime.Second + " seconds");
            Console.WriteLine(dateTime.Millisecond + " miliseconds");
            Console.WriteLine(dateTime.DayOfWeek);


            //Specifying kind(local,utc) of datetime


            //Specifying as local
            DateTime TimeNow1 = DateTime.Now;
            DateTime date1 = DateTime.SpecifyKind(TimeNow1, DateTimeKind.Local);
            Console.WriteLine($"{date1.Kind} time :  {TimeNow1}");


            //Specifying as Utc
            DateTime TimeNow2 = DateTime.UtcNow;
            DateTime date2 = DateTime.SpecifyKind(TimeNow2 , DateTimeKind.Utc);
            Console.WriteLine($"{date2.Kind} time :  {TimeNow2}");

        }
    }
}
