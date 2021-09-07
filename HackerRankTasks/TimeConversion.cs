using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class TimeConversion
    {
        public static string MTimeConversion(string s)
        {
            DateTime.TryParse(s, out DateTime parsed);
            return parsed.TimeOfDay.ToString();
        }
    }
}
