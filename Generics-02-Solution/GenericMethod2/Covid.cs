using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod2
{
    public class Covid
    {
        public P TestedPositive<P, F, S, C>(F fever, S soreThroat, C cough)
            where P : new()
            where F : class
            where S : class
            where C : class
        {
            if (fever != null && soreThroat != null && cough != null)
                return default(P);
            else
                return new P();
        }
    
    }
}
