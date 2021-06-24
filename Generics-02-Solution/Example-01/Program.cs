using System;

namespace Example_01
{
    class Program
    {
        static void Main(string[] args)
        {
            AxisPoint<int> axisPointInt = new AxisPoint<int>();

            var first1 = axisPointInt.first = 10;
            var second1 = axisPointInt.second = 11;
            var third1 = axisPointInt.third = 12;


            Console.WriteLine($"{first1}  {second1}  {third1}");

            var result = first1 + second1;
            Console.WriteLine(result);



            AxisPoint<double> axisPointDouble = new AxisPoint<double>();

            var first2 = axisPointDouble.first = 10.5;
            var second2 = axisPointDouble.second = 12.22;
            var third2 = axisPointDouble.third = 32;

            Console.WriteLine($"{first2}  {second2}  {third2}");

            var result2 = first2 + second2;
            Console.WriteLine(result2);

            AxisPoint<float> axisPointFloat = new AxisPoint<float>();

            var first3 = axisPointFloat.first = 10.3f;
            var second3 = axisPointFloat.second = 23.4f;
            var third3 = axisPointFloat.third = 34.2f;

            Console.WriteLine($"{first3}   {second3}    {third3}");

            var result3 = first3 + second3;
            Console.WriteLine(result3);

            AxisPoint<string> axisPointString = new AxisPoint<string>();

            var first4 = axisPointString.first = "EastWest";
            var second4 = axisPointString.second = "SouthNorth";
            var third4 = axisPointString.third = "WestNorth";


            Console.WriteLine($"{first4}  {second4}   {third4}");

            var result4 = first4 + second4;
            Console.WriteLine(result4);


            AxisPointOld old = new AxisPointOld();

            var first5 = old.x = 34.5;
            var second5 = old.y = 45;
            var third5 = old.z = 34.6f;
            var sixth5 = old.s = "eastwest";

            Console.WriteLine($"{first5}   {second5}   {third5}   {sixth5}");


            /* 
             * var result5 = first5 + second5;
            Console.WriteLine(result5); 
            *///Not possible because type of result is umambiguous
             
        }
    }
}
