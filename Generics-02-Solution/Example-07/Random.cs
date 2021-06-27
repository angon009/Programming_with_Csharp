using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_07
{
    public class Random<T,V> where T : struct
        where V : class 
    {
        public T structType; 
        public V classType;
    }
}
