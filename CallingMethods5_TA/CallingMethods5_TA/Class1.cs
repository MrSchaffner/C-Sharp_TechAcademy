using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods5_TA
{
    class Class1
    {

        // void method that OUTPUTS TO CONSOLE an integer
        public void Halve(int inputInt)
        {
            Console.WriteLine(inputInt/2);
        }

        // overloaded void method that has OUTPUT parameter
        public void Halve(int inputInt, out int myIntOUT)
        {
            myIntOUT = inputInt / 2;
        }

        //ASSIGNMENT create a method with output parameters

        public void outPutMethod(out int myInt2OUT, out int myIntOUT)
        {
            myIntOUT = 5;
            myInt2OUT = 30;
        }
    }
}
