using System;

namespace NullableDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Nullable Example for int
            int? number = null;

            number = 10;

            if(number.HasValue)
                Console.WriteLine(number);
            else
                Console.WriteLine("No value assigned");
            #endregion


            #region Nullable Example for bool

            bool? condition = null;

            condition = true;

            if(condition.HasValue)
                Console.WriteLine(condition);
            else
                Console.WriteLine("No condition Type");
            #endregion


            #region Nullable Example for char
            char? letter = null;

            //letter = 'A';
            Console.WriteLine(letter);
            #endregion
        }
    }
}
