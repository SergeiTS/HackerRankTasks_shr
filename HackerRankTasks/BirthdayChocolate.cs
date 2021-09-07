using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class BirthdayChocolate
    {
        public static int Birthday(List<int> s, int d, int m)
        {
            int cnt = 0;
            if ( m != 1 )
            {
                for ( int i = 0; i <= s.Count - m; i++ )
                {
                    int sum = 0;
                    for ( int j = i; j < m + i; j++ )
                    {
                        sum += s[j];
                        Console.Write($"{s[j]} ");
                    }
                    if ( sum == d )
                    {
                        cnt++;
                    }
                    Console.Write($" = {sum} ");
                    Console.WriteLine();
                }
            }
            else
            {
                for ( int i = 0; i < s.Count; i++ )
                {
                    if ( s[i] == d )
                    {
                        cnt++;
                    }
                }
            }
            return cnt;
        }
    }
}
