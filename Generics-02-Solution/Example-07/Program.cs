using System;

namespace Example_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random<int, Test> random = new Random<int, Test>();

            random.structType = 23;
        }
    }
}
