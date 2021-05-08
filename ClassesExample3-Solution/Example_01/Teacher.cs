using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class Teacher   // Class can't be declared as Private,Protected,Protected internal
    {
        public string Name { get; set; }  // Auto Property // Use it for declaring Public field

        public int Id { get; set; }

        public string Info()
        {
            return $"Name : {Name} || ID : {Id}";
        }

        //Default type of field and methods are "Private"
        //Default type of Class are "Internal"

        private int _teacherSalary;

        public int Salary
        {
            get
            {
                if (_teacherSalary <= 1000)
                    return _teacherSalary = 1000;
                else
                    return _teacherSalary;
            }
            set
            {
                if (value <= 1000)
                {
                    _teacherSalary = 1000;
                }
                else
                {
                    _teacherSalary = value;
                }

            }
        }
    }
}
