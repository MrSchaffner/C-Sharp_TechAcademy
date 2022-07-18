using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods2_TA
{
    class Class1
    {
        public int plusAMillion(int myInt)
        {
            return myInt + 1000000;
        }

        public int plusAMillion(decimal myDecimal)
        {
            return Convert.ToInt32(myDecimal + 1000000.0m);
        }

        public int plusAMillion(string numString)
        {
            try
            {
                return Convert.ToInt32(numString)+1000000;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Couldn't convert to Int: {0}", ex);
                return 0;
            }
            finally
            {
                
            }
        }


    }
}
