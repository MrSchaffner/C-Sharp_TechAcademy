using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6_TA 
{
    class Employee<T> : Person, IQuittable //empluyees are people too
    {
        public int id { get; set; }
        //not needed - inherited from base class
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public List<T> things { get; set; }


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

        public static bool operator ==(Employee<T> employee1, Employee<T> employee2)
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
        public static bool operator !=(Employee<T> employee1, Employee<T> employee2)
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
