using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_04
{
    public abstract class Admin
    {
        public abstract string  StudentFees(int studentClass, int totalSubject); // Abstract method can be declared without body
                                                                                 // But it needs to be implemented in its child class

        public string StudentInfo(string name , int rollNum)
        {
            return $"Name : {name} || Roll : {rollNum}";
        }
    }
}
