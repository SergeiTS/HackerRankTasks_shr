using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    public static class ArrayCompare
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            int aliR = 0;
            int bobR = 0;

            for ( int i = 0; i < a.Count; i++ )
            {
                if ( a.ElementAt(i) > b.ElementAt(i) )
                {
                    aliR += 1;
                }
                else if ( a.ElementAt(i) < b.ElementAt(i) )
                {
                    bobR += 1;
                }
            }

            List<int> lResult = new List<int>() { aliR, bobR };
            return lResult;
        }
    }
}
