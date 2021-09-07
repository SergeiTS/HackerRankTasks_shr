using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class SaveThePrisoner
    {
        public static int MSaveThePrisoner(int n, int m, int s)
        {
            #region Cases
            //#1
            //for ( int i = s; i <= n; i++ )
            //{
            //    m--;
            //    if ( m == 0 )
            //    {
            //        return i;
            //    }
            //    if ( (i == (n)) && (m != 0) )
            //    {
            //        i = 0;
            //        continue;
            //    }
            //}
            //return 0;
            // #2
            //int remSw = m % n;
            //for (int i = s; i <= n; i++)
            //{
            //    remSw--;
            //    if (remSw == 0)
            //    {
            //        return i;
            //    }
            //    if ((i == (n)) && (remSw != 0))
            //    {
            //        i = 0;
            //        continue;
            //    }
            //}
            //return 0;
            //#3
            //if ((n - m) < 0) //when quantity of prisoners is smaller than sweets
            //{
            //    int rem = m % n;
            //    if (rem == 0)
            //    {
            //        if (s + n - 1 <= n)
            //        {
            //            return s + n - 1;
            //        }
            //        else
            //        {
            //            return n - (n - s + 1);
            //        }
            //    }
            //    if (s + rem - 1 <= n)
            //    {
            //        return s + rem - 1;
            //    }
            //    else
            //    {
            //        return rem - (n - s + 1);
            //    }
            //}
            //else //if ((n - m) >= 0) //when quantity of prisoners is bigger than sweets
            //{
            //    if (s + m - 1 <= n)
            //    {
            //        return s + m - 1;
            //    }
            //    else
            //    {
            //        return m - (n - s + 1);
            //    }
            //}
            #endregion Cases
            int res = (m + s - 1) % n;
            if ( res == 0 )
            {
                return n;
            }
            else
            {
                return res;
            }
        }

    }
}
