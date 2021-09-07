using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HackerRankTasks
{
    class ProgrammersDay
    {
        public static string DayOfProgrammer(int year)
        {
            if ( year == 1918 )
            {
                return $"26.09.{year}";
            }
            if ( year > 1918 )
            {
                if ( DateTime.IsLeapYear(year) )
                {
                    return $"12.09.{year}";
                }
                else
                {
                    return $"13.09.{year}";
                }
            }
            else
            {
                if ( NewJulianCalendar(year) )
                {
                    return $"12.09.{year}";
                }
                else
                {
                    return $"13.09.{year}";
                }
            }
            
        }
        static bool NewJulianCalendar(int y)
        {
            JulianCalendar jCalendar = new JulianCalendar();
            return jCalendar.IsLeapYear(y);
        }
        
    }
}
