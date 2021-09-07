using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class BreakingTheRecords
    {
        public static int[] BreakingRecords(int[] scores)
        {
            int[] res = new int[2];
            int cntMaxScores = 0;
            int cntMinScores = 0;
            int MaxScores = scores[0];
            int MinScores = scores[0];
            for ( int i = 1; i < scores.Length; i++ )
            {
                if ( scores[i] > MaxScores )
                {
                    MaxScores = scores[i];
                    cntMaxScores++;
                }
                if ( scores[i] < MinScores )
                {
                    MinScores = scores[i];
                    cntMinScores++;
                }
            }
            res[0] = cntMaxScores;
            res[1] = cntMinScores;
            return res;
        }
    }
}
