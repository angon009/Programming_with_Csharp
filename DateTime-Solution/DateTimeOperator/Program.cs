using System;

namespace DateTimeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adding days
            DateTime dateTime1 = DateTime.Now;

            TimeSpan addedTime = new TimeSpan(10,20,30);

            DateTime addTime = dateTime1 + addedTime;

            Console.WriteLine("After adding time : " + addTime);


            //Deleting days
            DateTime dateTime2 = DateTime.UtcNow;

            TimeSpan deletedTime = new TimeSpan(20,10,25);

            DateTime deleteTime = dateTime2 - deletedTime;

            Console.WriteLine("After deleting time : " + deleteTime);


            //Checking Equality of two date

            DateTime lastDate = new DateTime(2021,5,20);
            DateTime submissionDate1 = new DateTime(2021, 5, 20);
            DateTime submissionDate2 = new DateTime(2021, 5, 25);

            if(lastDate == submissionDate1)
            {
                Console.WriteLine("Matched!!!");
            }
            
            if(lastDate != submissionDate2)
            {
                Console.WriteLine("Not Matched!!!");
            }
        }
    }
}
