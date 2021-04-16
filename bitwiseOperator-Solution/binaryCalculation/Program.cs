using System;

namespace binaryCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Binary number Toggling
            uint binaryNum1 = 0b_0000_1111_0000_1111_0000_1111_0000_1010;

            uint toggleResult = ~binaryNum1; // O transformed into 1
                                             // 1 transformed into 0  
             
            Console.WriteLine(Convert.ToString(toggleResult , toBase : 2));



            //Binary Number Left Shifting
            uint binaryNum2 = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine("Before Shifting  : " + Convert.ToString(binaryNum2, toBase: 2));

            uint leftShiftResult = binaryNum2 << 4;
            Console.WriteLine("After 4-bit left shifting : " + Convert.ToString(leftShiftResult, toBase: 2));


            //Binary Right Shifting
            uint binaryNum3 = 0b_1001;
            Console.WriteLine("Before Shifting" + Convert.ToString(binaryNum3, toBase: 2));

            uint rightShiftResult = binaryNum3 >> 2;
            Console.WriteLine("After 2-bit Right Shifting : " + Convert.ToString(rightShiftResult, toBase: 2));

            //AND Operation 
            uint binaryNum4 = 0b_1101_1001;
            uint binaryNum5 = 0b_1010_1000;
             
            uint andResult = binaryNum4 & binaryNum5;// 1 <-> 1 : 1   true - true : true
                                                     // 0 <-> 0 : 0   false - false : false
                                                     // 1 <-> 0 : 0   true - false : false
            Console.WriteLine("AND Operation Result :" + Convert.ToString(andResult, toBase: 2));


            //OR operation
            uint binaryNum6 = 0b_1101_1001;
            uint binaryNum7 = 0b_1010_1000;

            uint orResult = binaryNum6 | binaryNum7;// 1 <-> 1 : 1  true - true : true
                                                    // 0 <-> 0 : 0  false - false : false
                                                    // 1 <-> 0 : 1  true - false : true
            Console.WriteLine("OR Operation Result : " + Convert.ToString(orResult , toBase : 2));

            //XOR Operation
            uint binaryNum8 = 0b_1101_0011;
            uint binaryNum9 = 0b_1001_1100;

            uint xorResult = binaryNum8 ^ binaryNum9; // 1 <-> 1 : 0  true - true  : false
                                                     // 0 <-> 0 : 0   false - false : false
                                                     // 1 <-> 0 : 0   false - true : true
                                                     
            Console.WriteLine("XOR Operation Result : " + Convert.ToString(xorResult , toBase : 2));

        }
    }
}
