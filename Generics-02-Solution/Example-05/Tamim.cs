using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_05
{
    public class Tamim : ICricketer
    {
        private int _level;
        public int CoverDrive()
        {
            _level = 100;
            return _level;
        }

        public int Defense()
        {
            _level = 40;
            return _level;
        }

        public int LoftedDrive()
        {
            _level = 100;
            return _level;
        }

        public int StraightDrive()
        {
            _level = 50;
            return _level;
        }
    }
}
