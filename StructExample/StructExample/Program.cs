using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main()
        {
            Number myNumber = new Number() { Amount = 44.4m };
            Console.WriteLine(myNumber.Amount);

            endProgram();
        }

        //REUSABLE CODES

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
