using System;

namespace TupleVsAnonymous
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tuple
            //Tuple
            var tupleObj = (Name : "Angon" , Age : 24, Weight : 64.5); // Value must be initialized


            Console.WriteLine(tupleObj.Name);
            Console.WriteLine(tupleObj.Age);
            Console.WriteLine(tupleObj.Weight);

            tupleObj.Name = "John Wick";
            tupleObj.Age = 34;
            tupleObj.Weight = 78.4;

            Console.WriteLine(tupleObj.Name);
            Console.WriteLine(tupleObj.Age);
            Console.WriteLine(tupleObj.Weight);
            #endregion

            #region Anonymous
            //Anonymous 
            var anonymousObj = new { Name = "Angon", Age = 24, Weight = 64.5 }; // Value must be initialized

            Console.WriteLine(anonymousObj.Name);
            Console.WriteLine(anonymousObj.Age);
            Console.WriteLine(anonymousObj.Weight);

            //anonymousObj.Name = "John Wick";
            //anonymousObj.Age = 34;            //Not Possible Because Anonymous types are read only and not mutable
            //anonymousObj.Weight = 67.9;
            #endregion

            #region Tuple in method
            var result = Calculator(2,3,4,5,6,7,8,3,1,3,5,6,10);
            Console.WriteLine(result.sum); 
            Console.WriteLine(result.mul);
            Console.WriteLine(result.avrg);
             

            var result2 = Calculator(10,20,30,40,50,60,70);
            Console.WriteLine(result2.Item1); // That is also available
            Console.WriteLine(result2.Item2);
            Console.WriteLine(result2.Item3);
            #endregion
        }
        //Tuple can also be used return multiple output from a method
        public static (int sum , int mul , double avrg) Calculator(params int[] numbers)
        {
            int sum = 0 , mul = 1;
            foreach (var item in numbers)
            {
                sum = sum + item;
                mul = mul * item;
            }
            return (sum, mul, sum * 1.0 / numbers.Length);
        }
    }
}
