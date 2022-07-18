using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods_TA
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to do three equations on");
            string input = Console.ReadLine();
            int toInt = Convert.ToInt32(input);
            Console.WriteLine("============== Okay, here we go =============");
            Console.WriteLine(myClass.divideByThree(toInt));
            Console.WriteLine(myClass.multiplyByZero(toInt));
            Console.WriteLine(myClass.squareAndSubtractSelf(toInt));
            Console.ReadLine();
        }
    }
}
