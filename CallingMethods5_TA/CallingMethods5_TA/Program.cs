using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods5_TA
{
    class Program
    {
        static void Main()
        {
            int IntOUT = 0; //output parameter
            Class1 class1 = new Class1();

            //have the user enter a number:
            Console.WriteLine("enter a number to halve");
            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);

            class1.Halve(inputInt: inputInt); //outputs to console
            Console.WriteLine("Same function, overloaded, using an output parameter");
            class1.Halve(inputInt: inputInt, out IntOUT); //uses OUT property

            Console.WriteLine("You don't know the half of it: {0}", IntOUT);
            Console.WriteLine("a static function's output in a static class:");
            StaticClass.printRandom();

            endProgram();
        }

        public static void endProgram()
        {
            Console.WriteLine("================= PROGRAM OVER - Enter 'r' to Restart =================");
            if (Console.ReadLine() == "r")
            {
                Main();
            }
        }
    }
}
