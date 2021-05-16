using System;

namespace Example_02
{
    class Program
    {
        public enum WorkingDays
        {
            Sunday = 1,
            Monday ,
            Tuesday ,
            Wednesday,
            Thursday
        }
        static void Main(string[] args)
        {
            WorkingDays days;
            for(int i = 1; i <= 5; i++)
            {
                days = (WorkingDays)i;
                Console.WriteLine($"Day Number : {(int)days} Day's Name : {days}");
            }
            
        }
    }
}
