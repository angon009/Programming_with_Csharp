using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stacks = new Stack<int>();


            //Adding elements in stack
            stacks.Push(100);        //Elements store visualization
            stacks.Push(20);         //691  500  456  350  20   100
            stacks.Push(350);
            stacks.Push(456);
            stacks.Push(500);
            stacks.Push(691); 

            foreach(int i in stacks)
            {
                Console.WriteLine(i); 
            }



            //Removing elements from stack
            Console.WriteLine("After Popping");
            stacks.Pop();
            foreach (int i in stacks)
            {
                Console.WriteLine(i);
            } // LIFO : Last in First Out




            //Showing topmost elements of stack
            Console.WriteLine("At Top : " + stacks.Peek());
            stacks.Pop();
            Console.WriteLine("At Top : " + stacks.Peek());





            //Searching an elements from stack
            Console.Write("Enter Search Element : ");
            int searchItem = int.Parse(Console.ReadLine());

            if(stacks.Contains(searchItem))
            {
                Console.WriteLine("Item Found");
            }
            else
            {
                Console.WriteLine("Not found");
            }

        }
    }
}
