using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods4_TA
{
    class Program
    {
        static void Main()
        {

            Class1 class1 = new Class1();
            class1.subtract2(98, 123213);
            class1.subtract2(int1: 100, int2: 34);

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
