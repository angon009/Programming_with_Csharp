using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    public class StudentIdGenerator<TYPE>
    {
        private TYPE _id;

        public StudentIdGenerator(TYPE id)
        {
            _id = id;
        }

    }
}
