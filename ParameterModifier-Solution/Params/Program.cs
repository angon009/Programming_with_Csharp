using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethod1( 1 , 2 , 3 , 4);

            Console.WriteLine(TestMethod2(10, 20, 30, 40, 50, 60));

            Console.WriteLine(TestMethod3(1,20,15,16,17,18,19,20));

            TestMethod4("Angon Chowdhury" , 6 ,"CSE" , 3.02 , "IIUC");
        }

        public static void TestMethod1(params int[] arr)
        {

        }

        public static int TestMethod2(params int[] arr)
        {
            int sum = 0;
            foreach (var i in arr)
            {
                sum = sum + i;
            }
            return sum;
        }

        public static int TestMethod3(int start , int end, params int[] numbers)
        {
            int sum = 0;
            foreach (var i in numbers)
            {
                sum = sum + i;
            }
            sum = sum + start + end;
            return sum;
        }

        public static void TestMethod4(params object[] arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }



    }
}
