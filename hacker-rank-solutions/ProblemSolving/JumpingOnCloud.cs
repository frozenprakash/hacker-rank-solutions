using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
    /// </summary>
    internal static class JumpingOnCloud
    {
        public static int Execute(List<int> c)
        {
            int jump = 0;

            for(int i = 0;
                    i < c.Count;
                    i++)
            {
                if (i + 2 < c.Count &&
                    c[i + 2] == 0)
                {
                    jump++;
                    i += 1;
                }
                else if (i + 1 < c.Count &&
                            c[i + 1] == 0)
                {
                    jump++;
                }
            }

            return jump;
        }
    }
}
