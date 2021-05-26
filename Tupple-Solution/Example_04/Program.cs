using System;

namespace Example_04
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = (length : 10 , breadth : 20); // Tuple
            var triangle = (firstSide : 3 , secondSide : 4 , thirdSide : 5); //Tuple

            var rectangleArea = rectangle.breadth * rectangle.length;
            Console.WriteLine("Area of Rectangle : " + rectangleArea);

            var triangleArea = triangle.firstSide * triangle.secondSide * triangle.thirdSide ;
            Console.WriteLine("Area of Triangle : " + triangleArea);


            var employeeInfo = (id: string.Empty, name: string.Empty, age: 0, weight: 0.0); //Tuple

            employeeInfo.id = "E234";
            employeeInfo.name = "John Wick";
            employeeInfo.age = 24;
            employeeInfo.weight = 70.7;

            Console.WriteLine(employeeInfo);

        }
    }
}
