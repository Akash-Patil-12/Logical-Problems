using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class Day
    {
        //variables
        int day, month, year;
        //constants
        const int SUNDAY = 0, MONDAY = 1, TUESDAY = 2, WHENSDAY = 3, THUESDAY = 4, FRIDAY = 5, SATURDAY = 6;
        /// <summary>
        /// Display day according to entered date
        /// </summary>
        public void DayOfWeek()
        {
            Console.WriteLine("Enter day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());
            int valueY = year - (14 - month) / 12;
            int valueX = valueY + valueY / 4 - valueY / 100 + valueY / 400;
            int valueM = month + 12 * ((14 - month) / 12) - 2;
            int valueD = (day + valueX + (31 * valueM) / 12) % 7;
            switch (valueD)
            {
                case SUNDAY:
                    Console.WriteLine("Sunday");
                    break;
                case MONDAY:
                    Console.WriteLine("Monday");
                    break;
                case TUESDAY:
                    Console.WriteLine("Tuesday");
                    break;
                case WHENSDAY:
                    Console.WriteLine("Wensday");
                    break;
                case THUESDAY:
                    Console.WriteLine("Thuesday");
                    break;
                case FRIDAY:
                    Console.WriteLine("Friday");
                    break;
                case SATURDAY:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    break;
            }     
        }
    }
}
