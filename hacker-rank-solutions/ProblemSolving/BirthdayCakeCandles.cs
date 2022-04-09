using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    /// </summary>
    internal static class BirthdayCakeCandles
    {
        public static int Exeucte(List<int> candles)
        {
            int max = candles.Max();
            return candles.Where(x => x == max)
                          .Count();
        }
    }
}
