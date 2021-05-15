using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class TestClass
    {
        public void TestMethod()
        {
            Console.WriteLine("First Overload");
        }
        public void TestMethod(int id) 
        {
            Console.WriteLine("Second Overload");
        }
        public void TestMethod(string name)
        {
            Console.WriteLine("Third Overload");
        }
        public void TestMethod(string name , int id)
        {
            Console.WriteLine("Fourth Overload");
        }
        public void TestMethod(int id , string name)
        {
            Console.WriteLine("Fifth Overload");
        }
         
         

    }
}
