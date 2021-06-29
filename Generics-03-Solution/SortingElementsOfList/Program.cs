using System;
using System.Collections.Generic;

namespace SortingElementsOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            //numbers sorting
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(0);
            numbers.Add(-2);

            Console.Write("Before Sorting : ");
            foreach(int i in numbers)
            {
                Console.Write(i + "  ");
            }
             
            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(5));

            numbers.Sort(); //it sorts number in ascending orders

            Console.Write("After Sorting : ");
            foreach(int i in numbers)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine(numbers.IndexOf(5));





            //words sorting
            List<string> words = new List<string>();

            words.Add("Banana");
            words.Add("Apple");
            words.Add("Corn");
            words.Add("Apricots");
            words.Add("Carrots");

            Console.Write("Before Sorting : ");
            foreach (string i in words)
            {
                Console.Write(i + "  ");
            }

            Console.WriteLine();
            Console.WriteLine(words.IndexOf("Banana"));

            words.Sort(); //it sorts words lexicographically

            Console.Write("After Sorting : ");
            foreach (string i in words)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();
            Console.WriteLine(words.IndexOf("Banana"));



        }
    }
}
