using System;
using System.Collections.Generic;

namespace ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();

            intList.Add(10);
            intList.Add(11);
            intList.Add(12);
            intList.Add(13);

            Console.Write("Integer List : ");
            foreach(int i in intList)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();



            List<string> stringList = new List<string>();

            stringList.Add("Java");
            stringList.Add("Python");
            stringList.Add("Dart");

            Console.Write("Strings List : ");
            foreach(string i in stringList)
            {
                Console.Write(i + "   ");
            }
            Console.WriteLine();



            string[] names = { "Jack", "Joe", "James" };
            string[] designation = { "CEO", "CTO" };

            List<string> collectionList = new List<string>();
            collectionList.AddRange(names); // It is used to add a collection
            collectionList.AddRange(designation);

            Console.Write("Collection List :   ");
            foreach(string i in collectionList)
            {
                Console.Write(i + "    ");
            }
            Console.WriteLine();

            

            List<object> objectList = new List<object>();

            objectList.Add(10);
            objectList.Add("Angon");
            objectList.Add('T');

            Console.Write("Object List :   ");
            foreach(object i in objectList)
            {
                Console.Write(i + "  ");
            }
            Console.WriteLine();

            


        }
    }
}
