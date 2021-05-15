using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int xx = x;
            x = 10;
            Console.WriteLine(xx);


            string y = "Angon";
            string yy = y;
            y = "Chowdhury";
            Console.WriteLine(yy);

            //Though string is a reference type but copying a string by using '=' assignment will work as value type
            //Value type copy create a whole new memory address and value
        }
    }
}
