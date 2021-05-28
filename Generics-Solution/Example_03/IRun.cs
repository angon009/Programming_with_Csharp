using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_03
{
    public interface IRun
    {
        public void Start();
        public void SpeedUp();
        public void SpeedDown();
        public void Stop();
        public void GoLeft();
        public void GoRight();
        public void Jump();
        public void Descend();

    }
}
