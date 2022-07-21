using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the day");
            string input = Console.ReadLine().ToUpper();

            try
            {
                DaysOfTheWeek inputDay = (DaysOfTheWeek) Enum.Parse( typeof(DaysOfTheWeek), input);
                Console.WriteLine("You entered a valid enum: {0}", inputDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week. Exception: {0}", ex);
            }


            endProgram();
        }


        public static void endProgram()
        {
            Console.WriteLine("================= PROGRAM OVER - Enter 'r' to Restart =================");
            if (Console.ReadLine() == "r")
            {
                Main();
            }
        }

        public enum DaysOfTheWeek
        {
            SUNDAY, MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY
        }
    }
}
