using System;

namespace Non_Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            OlderVersion older = new OlderVersion();

            older.pointA = 23;
            older.pointB = 23.45;
            older.pointC = "24.55.33.22";
            older.pointD = "Angon Co ordinate";

            //string result = older.pointC + older.pointD; // Not Possible

            //var result = older.pointA + older.pointB + older.pointC; // Not Possible
            //Object does not support that because data type is not confronted
        }
    }
}
