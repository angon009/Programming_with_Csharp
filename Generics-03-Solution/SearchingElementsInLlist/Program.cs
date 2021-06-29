using System;
using System.Collections.Generic;

namespace SearchingElementsInLlist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();

            students.Add("Ron");
            students.Add("Jack");
            students.Add("Melvin");
            students.Add("Amter");
            students.Add("Jack");



            //searching the index of every elements
            foreach (string i in students)
            {
                Console.WriteLine($"Roll : {students.IndexOf(i)}  Name : {i}");
            }
            Console.WriteLine();
            Console.WriteLine();


            //searching  index of an elements after a certain index
            Console.WriteLine(students.IndexOf("Melvin" , 3)); //It will start searching from index 3



            //searching the last index of an element
            Console.WriteLine(students.IndexOf("Jack"));
        }
    }
}
