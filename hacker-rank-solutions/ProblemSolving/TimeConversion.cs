using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/time-conversion/problem
    /// </summary>
    internal static class TimeConversion
    {
        public static string Execute(string s)
        {
            return DateTime.Parse(s)
                           .ToString("HH:mm:ss");
        }
    }
}
