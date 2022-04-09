using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/mini-max-sum/problem
    /// </summary>
    internal static class MinMaxSum
    {
        public static void Execute(List<int> arr)
        {
            List<long> larr = arr.ConvertAll(i => (long)i);
            List<long> sums = new List<long>();

            for(int i = 0;
                    i < larr.Count;
                    i++)
            {
                sums.Add(larr.Sum() - larr[i]);
            }

            Console.Write($"{sums.Min()} {sums.Max()}");
        }
    }
}
