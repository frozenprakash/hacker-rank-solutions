using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/compare-the-triplets/problem
    /// </summary>
    internal static class CompareTheTriplets
    {
        public static List<int> Execute(List<int> a,
                                    List<int> b)
        {
            int alice = 0,
            bob = 0;

            for (int i = 0;
                    i < a.Count;
                    i++)
            {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (b[i] > a[i])
                {
                    bob++;
                }
            }

            return new List<int>() { alice, bob };
        }
    }
}
