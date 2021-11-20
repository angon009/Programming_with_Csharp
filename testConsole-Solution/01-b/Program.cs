using System;

namespace _01_b
{
    class Stopwatch
    {
        public int elapsedTime;
        public void Start()
        {
            Console.WriteLine("Count started...........");
        }
        public void Stop()
        {
            Console.WriteLine("Stopped");
        }
        public void Show()
        {
            Console.WriteLine(elapsedTime);
        }
        Stopwatch()
        {
            elapsedTime = 0;
        }
        ~Stopwatch()
        {
            Console.WriteLine(elapsedTime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             
        }
    }
}
