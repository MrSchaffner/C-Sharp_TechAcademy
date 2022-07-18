using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods2_TA
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 myClass1 = new Class1();
            //send as integer
            Console.WriteLine(myClass1.plusAMillion(43));
            //send as decimal
            Console.WriteLine(myClass1.plusAMillion(43.5m));
            //send as string
            Console.WriteLine(myClass1.plusAMillion("43"));

            Console.ReadLine();




        }
    }
}
