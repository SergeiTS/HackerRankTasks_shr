using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace HackerRankTasks
{
    class CountingValleys
    {
        public static int MCountingValleys(int n, string s)
        {
            int result = 0;
            int zLevel = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    zLevel += 1;
                    if (zLevel == 0)
                    {
                        result += 1;
                    }
                }
                else 
                {
                    zLevel -= 1;
                }
            }
            return result;
        }
    }
}
