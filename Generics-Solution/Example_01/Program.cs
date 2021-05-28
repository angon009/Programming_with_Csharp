using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            AxisPoint<int> axisPoint1 = new AxisPoint<int>();

            axisPoint1.pointX = 2;
            axisPoint1.pointY = 3;
            axisPoint1.pointZ = 4;
            
            //Addition of field value of same class
            int addition = axisPoint1.pointX + axisPoint1.pointY;
            Console.WriteLine(addition);

            AxisPoint<float> axisPoint2 = new AxisPoint<float>();

            axisPoint2.pointX = 23.34f;
            axisPoint2.pointY = 34.11f;
            axisPoint2.pointZ = 37.78f;


            //Addition of field value of different class
            int addition2 = axisPoint1.pointX + (int)axisPoint2.pointX;
            Console.WriteLine(addition2);

            AxisPoint2D<double> axisPoint2D = new AxisPoint2D<double>();

            axisPoint2D.pointX = 2.45;
            axisPoint2D.pointY = 3.56;

            AxisPoint5D<string> axisPoint5D = new AxisPoint5D<string>();

            axisPoint5D.pointA = "LFR";
            axisPoint5D.pointB = "RFR";
            axisPoint5D.pointC = "YFR";
            axisPoint5D.pointD = "UFR";
            axisPoint5D.pointE = "IFR";

            //String Concatenation of field value of same class
            Console.WriteLine(axisPoint5D.pointA + axisPoint5D.pointC);

            //String Concatenation of field value of different class
            Console.WriteLine($"{axisPoint2D.pointX}  {axisPoint5D.pointB}");

        }
    }
}
