using System;

namespace Example_02
{
    class Program
    {
        static void Main(string[] args)
        {
            (int x, int y)[] array = new (int x, int y)[2];

            array[0].x= 10;
            array[1].x = 25;
            array[0].x = 15;
            array[1].y = 20;


        }
    }
}
