using System;
using System.Collections.Generic;

namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> studentList = new Dictionary<int, string>();


            //adding elements in dictionary
            studentList.Add(1, "Jack");
            studentList.Add(2, "Joey");
            studentList.Add(7, "Ross");
            studentList.Add(3, "Chandler");
            studentList.Add(9, "Ganther");

            foreach (KeyValuePair<int, string> elements in studentList)
            {
                Console.WriteLine($"{elements.Key}   {elements.Value}");
            }

            int totalElements = studentList.Count;
            Console.WriteLine($"Size : {totalElements}");
            Console.WriteLine();
            Console.WriteLine();



            //removing a element from dictionary
            studentList.Remove(3);
            foreach (KeyValuePair<int, string> elements in studentList)
            {
                Console.WriteLine($"{elements.Key}   {elements.Value}");
            }

            int totalElements2 = studentList.Count;
            Console.WriteLine($"Size : {totalElements2}");
            Console.WriteLine();
            Console.WriteLine();




            //Different way to add elements
            Dictionary<string, double> result = new Dictionary<string, double>(10);

            result["Monica"] = 3.67;
            result["Rachel"] = 2.5;
            result["Phoebe"] = 3;

            foreach(KeyValuePair<string , double> outputs in result)
            {
                Console.WriteLine($"Name : {outputs.Key}  CGPA : {outputs.Value}");
            }


        }
    }
}
