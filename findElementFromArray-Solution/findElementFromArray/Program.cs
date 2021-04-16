using System;

namespace findElementFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding a element from an Array : ");

            int[] arr = { 12 , 13 , 11 , 15 , 16};

            Console.WriteLine("What are you searching For : ");

            string searchValTemp = Console.ReadLine();
            int searchVal = Convert.ToInt32(searchValTemp);

            int find = 0 , pos = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == searchVal)
                {
                    find++;
                    pos = i;
                    break;
                }                
            }
            if (find > 0)
            {
                Console.WriteLine(searchVal + " found on " + (pos + 1) + " position");
            }
            else
            {
                Console.WriteLine(searchVal + " doesn't exist!!!");
            }
        }
    }
}
