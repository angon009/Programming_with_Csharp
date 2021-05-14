using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_08
{
    public partial class Student
    {
        public string Id { get; set; }
        public string StudentID()
        {
            Id = Guid.NewGuid().ToString();
            return Id;
        }

        public void ShowID()
        {
            Console.WriteLine("ID : " + StudentID());
        }
        public void Message()
        {
            Console.WriteLine("ID Validation Successfull");
        }

        public Student()
        {
            Message();
        }
    }
}
