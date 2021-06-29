using System;
using System.Collections.Generic;

namespace ListExample_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("John Cena");
            names.Add("Kane");
            names.Add("Big Show");
            names.Add("Undertaker");
            names.Add("Triple H");
            names.Add("Batista");
            names.Add("Ray Mystereo");
            names.Add("Randy Orton");
            names.Add("Umaca");


            Console.WriteLine(names[0]);
            Console.WriteLine(names[3]);
            //Console.WriteLine(names[10]); //Out of range

            for(int i = 0; i < names.Count; i++) // listName.count -> Total number of elements in list
            {
                Console.WriteLine($"{i + 1}  ===> {names[i]}");
            }

            Console.WriteLine(names.Capacity); //List Capacity is dynamic according to total items 
                                               //Capacity Allocation : 0 , 2 , 4 , 8 , 16.......
        }
    }
}
