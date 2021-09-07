using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class BonAppetit
    {
        public static void MBonAppetit(List<int> bill, int k, int b)
        {
            int sum = 0;
            for ( int i = 0; i < bill.Count; i++ )
            {
                if ( i == k )
                {
                    continue;
                }
                else
                {
                    sum += bill[i];
                }
            }
            int payAnna = sum / 2;
            if ( payAnna == b )
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(b - payAnna);
            }
        }
    }
}
