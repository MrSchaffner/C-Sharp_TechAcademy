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
            //LAMBDA ASSIGNMENT step 338

            Employee<int> employee4 = new Employee<int>() { FirstName = "Joe", LastName = "Pupil", id = 004 };
            Employee<int> employee5 = new Employee<int>() { FirstName = "Joe", LastName = "Pupil", id = 005 };
            Employee<int> employee6 = new Employee<int>() { FirstName = "Rick", LastName = "Pupil", id = 025 };
            Employee<int> employee7 = new Employee<int>() { FirstName = "Fred", LastName = "Pupil", id = 026 };
            Employee<int> employee8 = new Employee<int>() { FirstName = "George", LastName = "Pupil", id = 027 };
            Employee<int> employee9 = new Employee<int>() { FirstName = "Ender", LastName = "Pupil", id = 028 };
            Employee<int> employee10 = new Employee<int>() { FirstName = "Harry", LastName = "Pupil", id = 029 };
            Employee<int> employee11 = new Employee<int>() { FirstName = "Bilbo", LastName = "Pupil", id = 030 };
            Employee<int> employee12 = new Employee<int>() { FirstName = "mack", LastName = "Pupil", id = 031 };
            Employee<int> employee13 = new Employee<int>() { FirstName = "Daddy", LastName = "Pupil", id = 032 };
            List<Employee<int>> Walmart = new List<Employee<int>>() { employee4, employee5, employee6, employee7, employee8, employee9, employee10, employee11, employee12, employee13 };
            Console.WriteLine("All employees in list:");
            foreach (Employee<int> emp in Walmart)
            {
                Console.WriteLine("{0} {2} has an id of {1}", emp.FirstName, emp.id, emp.LastName);
            }

            List<Employee<int>> WalmartJoes = new List<Employee<int>>();
            //adding joes to new list
            //foreach (Employee<int> emp in Walmart)
            //{
            //    if (emp.FirstName == "Joe")
            //    {
            //        WalmartJoes.Add(emp);
            //    }
            //}
            //same task with lambda func
            WalmartJoes = Walmart.Where(x => x.FirstName == "Joe").ToList();
            Console.WriteLine("All employees in list named Joe:");
            foreach (Employee<int> emp in WalmartJoes)
            {
                Console.WriteLine("{0} has an id of {1}", emp.FirstName, emp.id);
            }

            //
            List<Employee<int>> WalmartOverFive = new List<Employee<int>>();
            WalmartOverFive = Walmart.Where(x => x.id > 5).ToList();
            Console.WriteLine("All employees in list with id over 5:");
            foreach (Employee<int> emp in WalmartOverFive)
            {
                Console.WriteLine("{0} {2} has an id of {1}", emp.FirstName, emp.id, emp.LastName);
            }

            Console.WriteLine("-------------------------------------------------");



            //Add employees
            Employee<string> employee1 = new Employee<string>() { FirstName = "SamPle", LastName = "Student", id = 006 };
            Employee<string> employee2 = new Employee<string>() { FirstName = "SamPle", LastName = "Learner", id = 006 };
            Employee<int> employee3 = new Employee<int>() { FirstName = "Sample", LastName = "Pupil", id = 005 };
            employee1.SayName();
            employee2.SayName();
            employee3.SayName();

            //use of operator overloading
            if (employee1 == employee2)
            {
                Console.WriteLine("These two appear to have the same ID");
            }
            else if (employee1 != employee2) //checking that other operator functions properly, though else would suffice in this case.
            {
                Console.WriteLine("These two have different IDs");
            }
            else
            {
                Console.WriteLine("THis should never run");
            }

            // populating lists and PRINTING
            employee2.things = new List<string>() { "hats", "balls", "coats" };
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
