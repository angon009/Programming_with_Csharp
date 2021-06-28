using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public class Receipe
    {
        //var result1 = receipe.TestTaste<Taste, Level>(new Level());
        //var result2 = receipe.TestTaste<Taste, Level>(null);
        public P TestTaste<P,Q>(Q salt) // P = Taste    Q = Level
            where P : new()             // salt is new instance at first example
            where Q : class             // salt is null at second example
        {
            if (salt == null)
                return default(P); // return will be null
            else
                return new P(); // return will be Taste class new instance
        }    
    }
}
