using System;
using System.Collections.Generic;

namespace RemovingItemFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> vowels = new List<char>();


            //adding elements in a list
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('g');
            vowels.Add('h');
            vowels.Add('o');
            vowels.Add('u');
            foreach(char i in vowels)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();



            //removing an element from a list
            vowels.Remove('g');
            foreach (char i in vowels)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();



            //removing element from a certain index
            vowels.RemoveAt(3);
            foreach (char i in vowels)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine();

            
            //removing elements from a certain index with total elements need to be removed
            vowels.RemoveRange(2,3);
            foreach (char i in vowels)
            {
                Console.WriteLine(i);
            }

            //removing all elements
            //vowels.RemoveAll;
            //Console.WriteLine();


            vowels.Clear();
            Console.WriteLine(vowels.Count);

             
        }
    }
}
