using System;
using System.Text;

namespace Remove
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

            text.Remove(15,4); // (Start Index , totalCharacterToRemove)

            Console.WriteLine(text);
        }
    }
}
