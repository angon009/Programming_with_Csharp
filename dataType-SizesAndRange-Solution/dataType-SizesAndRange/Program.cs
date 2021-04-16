using System;

namespace dataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = -124452;   //Range : -2,147,483,648 to 2,147,483,647
            uint num2 = 1234567890; //Range : 0 to 4,294,967,295
            //Size : 32-bit -> 4-byte

            long num3 = -123456789987654221; //Range : -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong num4 = 3344555513456566; //Range : 0 to 18,446,744,073,709,551,615
            //Size : 64-bit -> 8-byte

            byte num5 = 123; //It works as ubyte(unsigned byte) <> Range : 0 to 255 
            sbyte num6 = -13; // Range : -128 to 127
            //Size : 8-bit -> 1-byte

            short num7 = -123;//Range : -32,768 to 32,767
            ushort num8 = 123; //Range : 0 to 65,535
            //Size : 16-bit -> 2-byte

            float num9 = 13.66f;//Range : -3.402823e38 to 3.402823e38
            //Size : 32-bit -> 4-byte

            double num10 = 13.567d;//Range : -1.79769313486232e308 to 1.79769313486232e308
            //Size : 64-bit -> 8-byte

            decimal num11 = 13.4567m; //Range : (+ or -)1.0 x 10e-28 to 7.9 x 10e28
            //Size : 96-bit -> 24-byte
            //decimal can store values with more precision then double
            //decimal is used in financial and monetary calculations where every single penny is important

            char text = 'A'; //1.Any Valid Character , 2.Hexadecimal Value , 3.Unicode
            //Size : 16-bit -> 2-byte

            bool condtion = false; // true or False


            string name = "ANGON Chowdhury"; //Any Combination of Character

            DateTime timeNow = DateTime.Now; // For Date and Time


            //Object can be any types of data because it is parent to everything in C#
            object obj1 = 134;
            object obj2 = 'A';
            object obj3 = 13.56;
            object obj4 = true;
            object obj5 = "Angon";
            object obj6 = timeNow;


        }
    }
}
