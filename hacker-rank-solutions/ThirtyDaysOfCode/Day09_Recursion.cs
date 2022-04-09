using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-recursion/problem
    /// </summary>
    internal static class Day09_Recursion
    {
        public static int Factorial(int n)
        {
            int f = 1;

            for (int i = n;
                    i >= 1;
                    i--)
            {
                f *= i;
            }

            return f;
        }
    }
}