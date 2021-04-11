using System;

 
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 3;
            int secondNum = 2;
            int thirdNum = 4;
            
            if(firstNum >= secondNum && firstNum >= thirdNum){
            Console.WriteLine(firstNum + " is largest!!!");
        }
            else if (secondNum >= firstNum && secondNum >= thirdNum) {
            Console.WriteLine(secondNum + " is largest!!!");
        }
            else{
            Console.WriteLine(thirdNum + " is largest!!!!");
        }
        }
    }
 
