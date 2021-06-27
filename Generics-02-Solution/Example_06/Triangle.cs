using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_06
{
    public class Triangle<T> where T : struct
    {
        public T firstSide;
        public T secondSide;
        public T thirdSide;
    }
}
