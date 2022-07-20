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
            Employee<string> employee1 = new Employee<string>() { FirstName = "SamPle", LastName = "Student", id = 006 };
            Employee<string> employee2 = new Employee<string>() { FirstName = "SamPle", LastName = "Learner", id = 006 };
            Employee<int> employee3 = new Employee<int>() { FirstName = "Sample", LastName = "Pupil", id=005 };
            employee1.SayName();
            employee2.SayName();
            employee3.SayName();

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

            // populating lists and PRINTING
            employee2.things = new List<string>(){ "hats","balls","coats"};
            employee3.things = new List<int>() { 5, 6, 7, 2, 5 };

            Console.WriteLine("Employee 2 things:");
            foreach (string thing in employee2.things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine("Employee 3 things:");
            foreach (int thing in employee3.things)
            {
                Console.WriteLine(thing);
            }

            // CREATES an OBJECT AND DEMONSTRATES it can Quit
            IQuittable quitObject = new Employee<string>(); 
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
