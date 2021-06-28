using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_10
{
    public class Player<T> : BasePlayer , IPlayer //Inheritance
        where T : struct , IPlayer // Generic Constraint
    {
         
    }

}
