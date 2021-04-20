using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jagged Array Initialization
            //Jagged Array can't be single Dimensional
            //Jagged Array are array of arrays


            //Two Dimensional Jagged Array
            //Jagged Array Declaration (First Way)
            int[][] jaggedTwoDim = new int[5][];

            jaggedTwoDim[0] = new int[5] { 3, 2, 1, 4, 5 };
            jaggedTwoDim[1] = new int[3] { 2, 3, 2 };
            jaggedTwoDim[2] = new int[2] { 1, 2 };
            jaggedTwoDim[3] = new int[3] { 1, 2, 3 };
            jaggedTwoDim[4] = new int[3] { 1, 2, 3 };


            //Jagged Array Declaration (Second Way)

            int[][] jaggedArrayFirst = new int[][]
            {
                new int[3]  {1,2,3},
                new int[5]  {3,4,5,6,7},
                new int[2]  {1,2}
            };

            //Jagged Array Declaration (Third Way) //Recomended Way //Dynamically Assigned

            int[][] jaggedArraySecond =
            {
                new int[]  {1,2,3},
                new int[]  {3,4,5,6,7},
                new int[]  {1,2}
            };
            //Showing Jagged Array by using for loop
            for (var i = 0; i < jaggedArraySecond.Length; i++)
            {
                for (var j = 0; j < jaggedArraySecond[i].Length; j++)
                {
                    Console.Write(jaggedArraySecond[i][j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
