using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/plus-minus/problem
    /// </summary>
    internal static class PlusMinus
    {
        public static void Execute(List<int> arr)
        {
            int negative = 0,
                zero = 0,
                positive = 0,
                count = arr.Count;

            decimal positiveRatio,
                    negativeRatio,
                    zeroRatio;

            foreach (int i in arr)
            {
                if (i < 0)
                {
                    negative++;
                }
                else if (i == 0)
                {
                    zero++;
                }
                else if (i > 0)
                {
                    positive++;
                }
            }

            positiveRatio = Math.Round(((decimal)positive / count), 6);
            negativeRatio = Math.Round(((decimal)negative / count), 6);
            zeroRatio = Math.Round(((decimal)zero / count), 6);

            Console.WriteLine(positiveRatio);
            Console.WriteLine(negativeRatio);
            Console.WriteLine(zeroRatio);
        }
    }
}
