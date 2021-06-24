using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_02
{
    public class MathLibrary<TYPE>
    {
        /*
        public TYPE Sum(TYPE a, TYPE b)
        {
            return a + b;
        }
        *///Not possible because return type is ambiguous
    }
}
