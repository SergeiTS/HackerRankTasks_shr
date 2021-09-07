using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class GradingStudents
    {
        public static List<int> MGradingStudents(List<int> grades)
        {
            for ( int i = 0; i < grades.Count; i++ )
            {

                if ( grades[i] < 38 )
                {
                    continue;
                }
                else
                {
                    int rem = grades[i] % 5;
                    if ( rem >= 3 )
                    {
                        grades[i] += (5 - rem);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return grades;
        }
    }
}