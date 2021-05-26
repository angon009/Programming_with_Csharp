using System;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example - 01
            //dynamic obj = new { message = "Hello" , number = 10 };
            //var msg = obj.message = "Hi";

            //obj.number = 11;

            //Console.WriteLine(msg);
            #endregion

            #region Example - 02

            var studentInfo = new
            {
                name = "Angon",
                age = 24,
                weight = 64.7,
                type = 'S'
            };

            Console.WriteLine(studentInfo);
            #endregion
        }
    }
}
