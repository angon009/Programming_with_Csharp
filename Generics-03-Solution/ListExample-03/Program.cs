using System;
using System.Collections.Generic;

namespace ListExample_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> subjects = new List<string>();

            subjects.Add("Compiler");
            subjects.Add("Data Structure");
            subjects.Add("Algorithm");
            subjects.Add("Database");

            string[] newSubjects = { "Data Science" , "Machine Learning"};

            subjects.InsertRange(2, newSubjects); // Inserting into a specified index
            
            foreach(string i in subjects)
            {
                Console.WriteLine(i);
            }
        }
    }
}
