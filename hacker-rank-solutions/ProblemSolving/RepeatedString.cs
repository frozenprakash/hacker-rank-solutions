using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/repeated-string/problem
    /// </summary>
    internal static class RepeatedString
    {
        public static long Execute(string s,
                                   long n)
        {
            int aCountStart = 0,
                aCountEnd = 0;

            long div = 0,
                    rem = 0,
                    aCountTotal;

            string lastSubString;

            if (!s.Contains('a'))
            {
                return 0;
            }

            aCountStart = s.Count(c => c == 'a');
            div = n / s.Count();
            rem = n % s.Count();

            if (rem != 0)
            {
                lastSubString = s.Substring(0,
                                            Convert.ToInt32(rem));
                aCountEnd = lastSubString.Count(c => c == 'a');
            }
            aCountTotal = (aCountStart * div) + aCountEnd;

            return aCountTotal;
        }
    }
}
