using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class ApplesOranges
    {
        public static void CountApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int cntApples = 0;
            int cntOranges = 0;
            //IEnumerable<int> house = Enumerable.Range(s, (t - s + 1));

            foreach ( int apple in apples )
            {
                int applePos = 0;
                applePos = a + apple;
                //if ( house.Contains(applePos) )
                if ( applePos >= s && applePos <= t )
                {
                    cntApples++;
                }
            }
            foreach ( int orange in oranges )
            {
                int orangePos = 0;
                orangePos = b + orange;
                //if ( house.Contains(orangePos) )
                if ( orangePos >= s && orangePos <= t )
                {
                    cntOranges++;
                }
            }

            Console.WriteLine($"{cntApples} \n{cntOranges}");
        }
    }
}
