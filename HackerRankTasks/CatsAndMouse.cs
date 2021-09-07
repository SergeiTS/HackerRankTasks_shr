using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTasks
{
    class CatsAndMouse
    {
        public static string CatAndMouse(int x, int y, int z)
        {
            int catA = Math.Abs(z - x);
            int catB = Math.Abs(z - y);
            if ( catA < catB )
            {
                return  "Cat A";
            }
            else if ( catA > catB )
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }

    }
}
