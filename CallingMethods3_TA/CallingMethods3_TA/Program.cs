using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods3_TA
{
    class Program
    {
        static void Main()
        {
            Class1 myClass1 = new Class1();

            Console.WriteLine("Enter a number to Multiply by 25:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter another number to also multiply, if you'd like, or hit ENTER to skip:");
            string input2 = Console.ReadLine();

            try
            {

                int input1Int;
                int input2Int;

                input1Int = Convert.ToInt32(input1);
                if (input2 != "")
                {
                    input2Int = Convert.ToInt32(input2);
                    Console.WriteLine(myClass1.multiplyBy25(input1Int, input2Int));
                }
                else
                {
                    Console.WriteLine(myClass1.multiplyBy25(input1Int));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("input1 = {0}, input2 = {1}", input1,input2);
                Console.WriteLine("There was an issue: {0}", ex);
            }
            finally
            {

            }

            endProgram();



        }

        public static void endProgram()
        {
            Console.WriteLine("================= PROGRAM OVER - Enter 'r' to Restart =================");
            if (Console.ReadLine() == "r") {
                Main();
            }
        }

    }
}
