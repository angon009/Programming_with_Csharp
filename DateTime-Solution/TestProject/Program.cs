using System;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date Difference  
            DateTime date1 = new DateTime(2015, 3, 10, 2, 15, 10);

            DateTime date2 = new DateTime(2015, 7, 15, 6, 30, 20);

            DateTime date3 = new DateTime(2015, 12, 28, 10, 45, 30);


            TimeSpan diff1 = date2.Subtract(date1);
            Console.WriteLine(diff1);

            DateTime date4 = date3.Subtract(diff1);
            Console.WriteLine(date4);

             
        }
    }
}
