using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/kangaroo/problem
    /// </summary>
    internal static class NumberLineJump
    {
        public static string kangaroo(int x1,
                                    int v1,
                                    int x2,
                                    int v2)
        {
            if (x1 == x2 &&
                v1 == v2)
            {
                return "YES";
            }

            if (x2 >= x1 &&
                v2 >= v1)
            {
                return "NO";
            }

            while (true)
            {
                if (v1 > v2 &&
                    x1 > x2)
                {
                    return "NO";
                }
                if (x1 == x2)
                {
                    return "YES";
                }

                x1 += v1;
                x2 += v2;
            }

            return "NO";
        }
    }
}
