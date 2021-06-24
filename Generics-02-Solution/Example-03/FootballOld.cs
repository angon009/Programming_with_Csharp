using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public class FootballOld : IStriker
    {
        private IStriker _striker;

        public IStriker Bootcamp
        {
            get
            {
                return _striker;
            }
        }

        public FootballOld(IStriker striker)
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
