using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class RunGame<TYPE> where TYPE : IRun 
    {
        private TYPE _level;
        public RunGame(TYPE level)
        {
            _level = level;
            
        }
    }
}
