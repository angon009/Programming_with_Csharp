using System;

namespace Example_04
{
    class Program
    {
        public enum Divisions : short
        {
            Barishal,
            Chittagong,
            Dhaka,
            Khulna,
            Mymensingh,
            Rajshahi,
            Rangpur,
            Sylhet

        }
        static void Main(string[] args)
        {
            foreach(short i in Enum.GetValues(typeof(Divisions)))
            {
                Console.WriteLine((Divisions)i);
            }
        }
    }
}
