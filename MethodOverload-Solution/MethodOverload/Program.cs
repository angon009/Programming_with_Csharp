using System;

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();

            testClass.TestMethod();
            testClass.TestMethod(6);
            testClass.TestMethod("Angon");
            testClass.TestMethod("Angon" , 6);
            testClass.TestMethod(6 , "Angon");
            testClass.TestMethod(6.0 , "Angon");
        }
    }
}
