using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class MigratoryBirds
    {
        public static int MMigratoryBirds(List<int> arr)
        {
            List<int> res = new List<int>();
            for ( int i = 1; i <= 5; i++ )
            {
                int cnt = 0;
                for ( int j = 0; j < arr.Count; j++ )
                {
                    if ( arr[j] == i )
                    {
                        cnt++;
                    }
                }
                res.Add(cnt);
            }
            int max = res.Max();
            int maxi = 0;
            for ( int i = 0; i < res.Count; i++ )
            {
                if ( res[i] == max )
                {
                    maxi = i + 1;
                    break;
                }
            }
            return maxi;
        }
    }
}
