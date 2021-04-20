using System;

namespace studentNameTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program to create student nametable of different class

            Console.Write("Total Class = ");
            int totalClass = int.Parse(Console.ReadLine());

            string[][] nameSheet = new string[totalClass][];


            //Taking Input from Office Staff of Students name
            for(var i = 0; i < nameSheet.Length; i++)
            {
                Console.Write($"Total Students of class {i + 1} = ");
                int totalStudent = int.Parse(Console.ReadLine());

                nameSheet[i] = new string[totalStudent];

                for(var j = 0; j < nameSheet[i].Length; j++)
                {
                    Console.Write($"Name of roll {j + 1} = ");
                    string name = Console.ReadLine();
                    nameSheet[i][j] = name;
                }
                Console.WriteLine();
            }

            //Showing Students Roll and Name

            for(var i = 0; i < nameSheet.Length; i++)
            {
                Console.WriteLine($"Class {i+1}'s Information->");
                Console.WriteLine();
                for (var j = 0; j < nameSheet[i].Length; j++)
                {
                    Console.WriteLine($"Roll {j + 1 } = {nameSheet[i][j]}");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
