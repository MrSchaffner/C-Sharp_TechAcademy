using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_TA
{
    class myClass
    {

        public static int multiplyByZero(int myInt)
        {
            return myInt * 0;
        }

        public static int squareAndSubtractSelf(int myInt)
        {
            return myInt * myInt - myInt;
        }

        public static int divideByThree(int myInt)
        {
            return myInt / 3 ;
        }

    }
}
