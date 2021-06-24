using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class Football<TYPE> where TYPE : IStriker
    {
        private TYPE _striker;

        public TYPE Bootcamp
        {
            get
            {
                return _striker;
            }
        }

        public Football( TYPE striker)
        {
            _striker = striker;
        }

        public bool Play()
        {
            try
            {
                _striker.Pass();
                _striker.Shoot();
                _striker.Dribble();
                _striker.Freekick();

                return true;
            }
            catch
            {
                return false;

            }
        }

        

    }
}
