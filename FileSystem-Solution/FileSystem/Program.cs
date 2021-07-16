using System;
using System.IO;

namespace FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Creating a new directory
            //Directory.CreateDirectory("Test");
            //Console.WriteLine("Done");


            ////Deleting a directory
            //Directory.Delete("Test");
            //Console.WriteLine("Done");



            //Get Current Directory file path
            string currentFilePath = Directory.GetCurrentDirectory();
            Console.WriteLine(currentFilePath);


            //Getting upper directory of a file
            DirectoryInfo directoryInfo = new DirectoryInfo(currentFilePath);

            string upperFile = directoryInfo.Parent.Parent.Parent.FullName;
            Console.WriteLine(upperFile);

        }
    }
}
