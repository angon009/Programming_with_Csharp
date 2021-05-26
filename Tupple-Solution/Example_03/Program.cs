using System;

namespace Example_03
{
    class Program
    {
        static void Main(string[] args)
        {
            (string name, string occupation, int age, double weight) information; // Tuple

            Console.Write("Enter Your Full Name : ");
            information.name = Console.ReadLine();

            Console.Write("Enter Your Occupation : ");
            information.occupation = Console.ReadLine();

            Console.Write("Enter Your Age : ");
            information.age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Weight");
            information.weight = double.Parse(Console.ReadLine());


            Console.Write($"Name : {information.name} Type : {information.occupation} ");
            Console.Write($"Age : {information.age} Weight : {information.weight}");
        }
    }
}
