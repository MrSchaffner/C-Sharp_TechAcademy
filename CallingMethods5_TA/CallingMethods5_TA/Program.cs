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
            int IntOUT; 
            Class1 class1 = new Class1();

            Console.WriteLine("enter a number to halve");
            string input = Console.ReadLine();
            int inputInt = Convert.ToInt32(input);

            class1.Halve(inputInt: inputInt, out IntOUT); // input should come from out property

            Console.WriteLine("You don't know the half of it: {0}", IntOUT);

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
