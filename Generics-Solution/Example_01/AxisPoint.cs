using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_01
{
    public class AxisPoint<TYPE>
    {
        public TYPE pointX;
        public TYPE pointY;
        public TYPE pointZ;

    }
    public class AxisPoint2D<TYPE>
    {
        public TYPE pointX;
        public TYPE pointY;
    }
    public class AxisPoint5D<TYPE>
    {
        public TYPE pointA;
        public TYPE pointB;
        public TYPE pointC;
        public TYPE pointD;
        public TYPE pointE;
    }

    public class AxisError<TYPE>
    {
        
        /*public TYPE Sum (TYPE num1 , TYPE num2)
        {
            return num1 + num2;
        }
        */
        /*This is not working because we can't do any operation here because TYPE doesn't know which
        type of data will come here to execute sum operation*/
    }
}
