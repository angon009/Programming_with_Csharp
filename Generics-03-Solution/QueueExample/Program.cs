using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ages = new Queue<int>();

            //Adding elements in Queue
            ages.Enqueue(30);   //Elements store visualization
            ages.Enqueue(28);   // 30 28 29 22
            ages.Enqueue(29);
            ages.Enqueue(22);

            foreach(int i in ages)
            {
                Console.WriteLine(i);
            }


            //Removing elements from queue
            ages.Dequeue();
            Console.WriteLine("After a dequeue");
            foreach (int i in ages)
            {
                Console.WriteLine(i);
            } //FIFO : First in First Out


            //Showing top elements of queue
            Console.WriteLine("Top Elements : " + ages.Peek());
            ages.Dequeue();
            Console.WriteLine("Top Elements : " + ages.Peek());

            ages.Enqueue(39);
            ages.Enqueue(41);
            ages.Enqueue(36);

            //Searching elements from a queue
            Console.Write("Search Element : ");
            int element = int.Parse(Console.ReadLine());

            if(ages.Contains(element))
            {
                Console.WriteLine("Item Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }
    }
}
