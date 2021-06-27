using System;

namespace Example_04
{
    class Program
    {
        static void Main(string[] args)
        {
            CartesianValue<int> intValue = new CartesianValue<int>();

            var x1 = intValue.xAxis = 3;
            var y1 = intValue.yAxis = 6;
            var z1 = intValue.zAxis = 9;

            Console.WriteLine($"{x1}  {y1}   {z1}");

            CartesianValue<double> doubleValue = new CartesianValue<double>();

            var x2 = doubleValue.xAxis = 4.5;
            var y2 = doubleValue.yAxis = 6;
            var z2 = doubleValue.zAxis = 9.8;

            Console.WriteLine($"{x2}   {y2}   {z2}");

            CartesianValue<string> stringValue = new CartesianValue<string>();

            var x3 = stringValue.xAxis = "First Quadrant";
            var y3 = stringValue.yAxis = "Second Quadrant";
            var z3 = stringValue.zAxis = "Third Quadrant";

            Console.WriteLine($"{x3}    {y3}   {z3}");
        }
    }
}
