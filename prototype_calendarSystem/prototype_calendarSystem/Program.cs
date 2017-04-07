using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace prototype_calendarSystem
{
    class Program
    {
        public static void Main()
        {
            bool alive = true;
            DateTime myDT = new DateTime(2017, 1, 1, new GregorianCalendar());

            // Uses the default calendar of the InvariantCulture.
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

            // Displays the values of the DateTime.
            Console.WriteLine("January 1, 2017 of the Gregorian calendar:");
            
            DisplayValues(myCal, myDT);
            while (alive)
            {
                Console.WriteLine("exit or next");
                var userInput = Console.ReadLine();
                if (userInput == "next")
                {
                    // Adds 1 month.
                    myDT = myCal.AddMonths(myDT, 1);

                    // Displays the values of the DateTime.

                    Console.WriteLine("one month later");
                    DisplayValues(myCal, myDT);
                }
                else if(userInput == "exit")
                {
                    alive = false;
                }
            }
            
            
        }

        public static void DisplayValues(Calendar myCal, DateTime myDT)
        {
            Console.WriteLine("   Era:          {0}", myCal.GetEra(myDT));
            Console.WriteLine("   Year:         {0}", myCal.GetYear(myDT));
            Console.WriteLine("   Month:        {0}", myCal.GetMonth(myDT));
            Console.WriteLine("   DayOfYear:    {0}", myCal.GetDayOfYear(myDT));
            Console.WriteLine("   DayOfMonth:   {0}", myCal.GetDayOfMonth(myDT));
            Console.WriteLine("   DayOfWeek:    {0}", myCal.GetDayOfWeek(myDT));
            Console.WriteLine();
        }
    }
}
