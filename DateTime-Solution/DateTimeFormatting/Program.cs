using System;

namespace DateTimeFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.ToString("dd MMMM, yyyy"));
            Console.WriteLine(dateTime.ToString("MMMM dd, yyyy"));
            Console.WriteLine(dateTime.ToString("yyyy , MMMM dd"));
            Console.WriteLine(dateTime.ToString("yyyy , dd MMMM"));



            Console.WriteLine(dateTime.ToString("d"));
            Console.WriteLine(dateTime.ToString("D"));

            Console.WriteLine(dateTime.ToString("t"));
            Console.WriteLine(dateTime.ToString("T"));

            Console.WriteLine(dateTime.ToString("g"));
            Console.WriteLine(dateTime.ToString("G"));

            Console.WriteLine(dateTime.ToString("Y"));

            Console.WriteLine(dateTime.ToString("dddd"));
            Console.WriteLine(dateTime.ToString("MMMM"));
            Console.WriteLine(dateTime.ToString("yyyy"));

        }
    }
}
