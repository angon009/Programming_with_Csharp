using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic
            DateTime dateTime1 = new DateTime(1996,10,11,8,10,11);
            Console.WriteLine(dateTime1.ToString());


            //Maximum and Minimun Supported days in VS
            Console.WriteLine("Maximum Supported Date in VS : " + DateTime.MaxValue);
            Console.WriteLine("Minimum Supported Date in VS : " + DateTime.MinValue);

            //Date time in UTC now
             
            Console.WriteLine("Date in UTC now : " + DateTime.UtcNow);
             

        }
    }
}
