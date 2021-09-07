using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class Staircase
    {
        public static void PrintStaircase(int n)
        {
            for ( int i = 1; i <= n; i++ )
            {
                Console.Write(new String(' ', n-i));
                Console.Write(new String('#', i));
                Console.WriteLine();
            }
            
        }
    }
}
