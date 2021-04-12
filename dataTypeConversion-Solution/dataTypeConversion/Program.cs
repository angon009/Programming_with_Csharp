using System;

namespace dataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //float to int
            float floatNum = 4.567f;
            int intNum = (int)floatNum;

            Console.WriteLine("Float to Int = " + intNum);

            //int to float
            int intNum2 = 34;
            float floatNum2 = intNum2;

            Console.WriteLine("Int to Float = " + floatNum2);

            //char to int
            char charText = 'A';
            int intNum3 = charText;

            Console.WriteLine("Char to Int = " + intNum3);

        }
    }
}
