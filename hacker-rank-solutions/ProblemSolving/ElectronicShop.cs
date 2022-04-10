using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/electronics-shop/problem
    /// </summary>
    internal static class ElectronicShop
    {
        static int getMoneySpent(int[] keyboards,
                                 int[] drives,
                                 int b)
        {
            List<int> sums = new List<int>();
            int closest = -1;

            foreach (int k in keyboards)
            {
                foreach (int d in drives)
                {
                    sums.Add(k + d);
                }
            }

            sums.Sort();

            if (sums[0] > b)
            {
                return -1;
            }

            for(int i = 0;
                    i < sums.Count;
                    i++)
            {
                if (sums[i] <= b)
                {
                    closest = sums[i];
                }
            }

            return closest;
        }
    }
}
