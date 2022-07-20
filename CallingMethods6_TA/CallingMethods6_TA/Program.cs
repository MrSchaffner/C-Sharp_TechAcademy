using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods6_TA
{
    class Program
    {
        static void Main()
        {
            //Add employees
            Employee employee1 = new Employee() { FirstName = "SamPle", LastName = "Student", id=006 };
            Employee employee2 = new Employee() { FirstName = "Sample", LastName = "Pupil", id=005 };
            employee1.SayName();
            employee2.SayName();

            //use of operator overloading
            if (employee1 == employee2)
            {
                Console.WriteLine("These two appear to have the same ID");
            } else if (employee1 != employee2) //checking that other operator functions properly, though else would suffice in this case.
            {
                Console.WriteLine("These two have different IDs");
            } else
            {
                Console.WriteLine("THis should never run");
            }


            // CREATES an OBJECT AND DEMONSTRATES it can Quit
            IQuittable quitObject = new Employee(); 
            quitObject.Quit();

            endProgram();
        }// END MAIN()
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
