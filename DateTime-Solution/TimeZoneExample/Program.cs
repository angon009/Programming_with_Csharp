using System;

namespace TimeZoneExample
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            //UTC to Local
            DateTime timeNowUtc1 = DateTime.UtcNow;
            DateTime timeNowLocal1 = TimeZone.CurrentTimeZone.ToLocalTime(timeNowUtc1);
            Console.WriteLine(timeNowLocal1);


            //Local To UTC
            DateTime timeNowLocal2 = DateTime.Now;
            DateTime timeNowUtc2 = TimeZone.CurrentTimeZone.ToUniversalTime(timeNowLocal2);
            Console.WriteLine(timeNowUtc2);

            //All Time Zones
            foreach(TimeZoneInfo i in TimeZoneInfo.GetSystemTimeZones())
            {
                Console.WriteLine(i);
            }

        }
    }
}
