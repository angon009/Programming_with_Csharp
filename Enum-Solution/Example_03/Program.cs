using System;

namespace Example_03
{
    class Program
    {
        public enum Groups
        {
            Science = 7,
            Commerce = 4,
            Arts = 1,
            Humanities = 2,
            Bussiness = 5
        }
        static void Main(string[] args)
        {
             
            foreach(int i in Enum.GetValues(typeof(Groups)))
            {
                Console.WriteLine($"{(Groups)i}  Rating {i}");
            }

            foreach (int i in Enum.GetValues(typeof(Groups)))
            {
                Console.WriteLine($"{(Groups)i}");
            }

        }
    }
}
