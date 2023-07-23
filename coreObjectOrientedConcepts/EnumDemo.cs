using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    enum WeekDays:byte
    {
        Monday = 5,         // 0
        Tuesday = 10,       // 1
        Wednesday = 15,     // 2
        Thursday = 25,      // 3
        Friday,             // 4
        Saturday = 30,      // 5
        Sunday              // 6
    }
    internal class EnumDemo
    {
        public void display()
        {
            Console.WriteLine(WeekDays.Monday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(WeekDays.Monday + " : " + day);

            Console.WriteLine(WeekDays.Tuesday);
            day = (int)WeekDays.Tuesday;
            Console.WriteLine(WeekDays.Tuesday + " : " + day);

            Console.WriteLine(WeekDays.Wednesday);
            day = (int)WeekDays.Wednesday;
            Console.WriteLine(WeekDays.Wednesday + " : " + day);
        }
    }
}
