using System;
using System.Text;

namespace Insert
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            Console.WriteLine("Enter Your First Name : ");
            text.Append(Console.ReadLine() + " ");

            Console.WriteLine("Enter Your Middle Name : ");
            text.Append(Console.ReadLine() + " ");

            Console.WriteLine("Enter Your Last Name : ");
            text.Append(Console.ReadLine() + " ");

             
            text.Insert(text.Length - 1 , " , CSE");

            Console.WriteLine(text);
        }
    }
}
