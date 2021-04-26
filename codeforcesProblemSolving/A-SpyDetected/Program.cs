using System;

namespace A_SpyDetected
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem Link : https://codeforces.com/problemset/problem/1512/A

            int testCase = int.Parse(Console.ReadLine());
            int totalElement;

            while(testCase != 0)
            {
                //Creating Array
                totalElement = int.Parse(Console.ReadLine());

                int[] array = new int[totalElement];

                //Taking Inputs
                for (var i = 0; i < totalElement; i++)
                {
                    
                    element =  int.Parse(Console.ReadLine());
                    array[i] =  element;
                }

                //Checking for intruder
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] == array[i + 1])
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(i + 2);
                        break;
                    }
                }
                testCase--;
            }
            


        }
     }
}
