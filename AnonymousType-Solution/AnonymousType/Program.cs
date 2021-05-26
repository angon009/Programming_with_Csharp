using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic obj = new { message = "Hello" , number = 10 };
            var msg = obj.message = "Hi";

            obj.number = 11;

            Console.WriteLine(msg);
        }
    }
}
