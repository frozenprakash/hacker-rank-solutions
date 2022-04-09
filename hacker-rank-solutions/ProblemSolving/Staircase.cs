using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/staircase/problem
    /// </summary>
    internal static class Staircase
    {
        public static void Execute(int n)
        {
            string space = "",
                    hash = "";

            for(int i = 1;
                    i <= n;
                    i++)
            {
                space = string.Concat(Enumerable.Repeat(" ",
                                                                n - i));
                hash = string.Concat(Enumerable.Repeat("#", 
                                                                i));
                Console.WriteLine(space + hash);
            }
        }
    }
}
