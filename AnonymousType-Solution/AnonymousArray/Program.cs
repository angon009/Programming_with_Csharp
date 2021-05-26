using System;
using System.Linq;

namespace AnonymousArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentList = new[]
            {
                new{name = "John" , age = 24, id = "C181" , mail = "john@gmail.com"},
                new{name = "Anton" , age = 22, id = "C182" , mail = "anton@gmail.com"},
                new{name = "Danik", age = 21, id = "C183" , mail = "danik@gmail.com"},
                new{name = "Alan", age = 27, id = "C182" , mail = "alan@gmail.com"}
            };

            for(int i = 0; i < studentList.Length; i++)
            {
                Console.WriteLine($"{studentList[i].name}  {studentList[i].age}  {studentList[i].id}  {studentList[i].mail}");
            }

            //To find elements which name start with A
            var searchFilter = studentList.Where(c => c.name.StartsWith("A")).ToList();

            //To find elements which id is C182
            var studentName = studentList.FirstOrDefault(c => c.id == "C182");
        }
    }
}
