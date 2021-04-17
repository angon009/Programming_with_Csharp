using System;

namespace multiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two-Dimensional Array
            int[,] firstArray = new int[2,2];

            firstArray[0, 0] = 1;
            firstArray[0, 1] = 2;
            firstArray[1, 0] = 3;
            firstArray[1, 1] = 4;

            int[,] secondArray = new int[,] //Size can be empty.It will be allocated automatically
            {
                {1,2},
                {2,4}
            };

            string[,] nameList = new string[3, 3] //Size can also be mentioned
            {
                {"Jack" , "Smith" , "Will" },
                {"Steve" , "Nan", "Mike" },
                {"Pik" , "Tom" , "Nick" }
            };

             
            

            //Three Dimensional Array
            int[,,] threeDimensionArray = new int[2, 2, 2];

            threeDimensionArray[0, 0, 0] = 1;
            threeDimensionArray[0, 0, 1] = 2;

            threeDimensionArray[0, 1, 0] = 3;
            threeDimensionArray[0, 1, 1] = 4;

            threeDimensionArray[1, 0, 0] = 5;
            threeDimensionArray[1, 0, 1] = 6;

            threeDimensionArray[1, 1, 0] = 7;
            threeDimensionArray[1, 1, 1] = 8;

            int[,,] fifthThreeDimArray = new int[4,2,2] 
            {
                 { 
                    {1,2} ,
                    {3,4}
                },
                 { 
                    {5,6} ,
                    {7,8}
                },
                 { 
                    {9,10} ,
                    {11,12}
                },
                 { 
                    {13,14} ,
                    {15,16}
                }
            };

            Console.WriteLine(fifthThreeDimArray[0,0,0]);
            Console.WriteLine(fifthThreeDimArray[0,0,1]);
            Console.WriteLine(fifthThreeDimArray[0,1,0]);
            Console.WriteLine(fifthThreeDimArray[0,1,1]);


            Console.WriteLine(fifthThreeDimArray[1,0,0]);
            Console.WriteLine(fifthThreeDimArray[1,0,1]);
            Console.WriteLine(fifthThreeDimArray[1,1,0]);
            Console.WriteLine(fifthThreeDimArray[1,1,1]);

            Console.WriteLine(fifthThreeDimArray[2,0,0]);
            Console.WriteLine(fifthThreeDimArray[2,0,1]);
            Console.WriteLine(fifthThreeDimArray[2,1,0]);
            Console.WriteLine(fifthThreeDimArray[2,1,1]);


            Console.WriteLine(fifthThreeDimArray[3,0,0]);
            Console.WriteLine(fifthThreeDimArray[3,0,1]);
            Console.WriteLine(fifthThreeDimArray[3,1,0]);
            Console.WriteLine(fifthThreeDimArray[3,1,1]);




        }
    }
}
