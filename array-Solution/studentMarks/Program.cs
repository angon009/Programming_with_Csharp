using System;

namespace studentMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //A program to show Mathematics Marks of different class of students



            //Creating Result Sheet
            Console.Write("Total Class = ");
            int totalClass = int.Parse(Console.ReadLine());

            int[][] numbersTable = new int[totalClass][];

            for(var i = 0; i < totalClass; i++)
            {
                Console.Write($"Total Students in Class {i + 1} = ");
                int totalStudents = int.Parse(Console.ReadLine());

                numbersTable[i] = new int[totalStudents];

                for(var j = 0; j < numbersTable[i].Length; j++)
                {
                    Console.Write($"Class : {i + 1} : Roll : {j + 1}  : Marks = ");
                    int marks = int.Parse(Console.ReadLine());
                    numbersTable[i][j] = marks;
                }
                Console.WriteLine();
            }


            //Showing ResultSheet
            Console.WriteLine("Marksheet : ");

            for(var i = 0; i < numbersTable.Length; i++)
            {
                Console.Write($"Class {i + 1} = ");
                for(var j = 0; j < numbersTable[i].Length; j++)
                {
                    Console.Write($"Roll : {j + 1} ==> {numbersTable[i][j]}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
