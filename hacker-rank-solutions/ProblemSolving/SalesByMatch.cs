using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/sock-merchant/problem
    /// </summary>
    internal static class SalesByMatch
    {
        public static int sockMerchant(int n,
                                       List<int> ar)
        {
            List<int> lst = ar;
            int pairCount = 0;

            while (lst.Count != lst.Distinct()
                                   .Count())
            {
                for(int i = 1;
                        i < lst.Count;
                        i++)
                {
                    if (ar[i] == ar[0])
                    {
                        pairCount++;

                        ar.RemoveAt(i);
                        ar.RemoveAt(0);

                        break;
                    }

                    if (i == lst.Count - 1)
                    {
                        ar.RemoveAt(0);
                    }
                }
            }

            return pairCount;
        }
    }
}
