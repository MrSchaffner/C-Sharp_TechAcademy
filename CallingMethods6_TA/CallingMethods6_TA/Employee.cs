using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6_TA 
{
    class Employee : Person, IQuittable //empluyees are people too
    {
        public int id { get; set; }


        public void Quit()
        {
            Console.WriteLine("I'm Fired!");
           // throw new NotImplementedException();
        }
    }
}
