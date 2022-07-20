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
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void Quit()
        {
            Console.WriteLine("I'm Fired!");
           // throw new NotImplementedException();
        }

        public override void SayName()
        {
            base.SayName();
            Console.WriteLine("I am an employee");
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.id == employee2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            //uses == operator that was overloaded above
            if (!(employee1 == employee2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //{
        //    if (employee1.id != employee2.id)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
