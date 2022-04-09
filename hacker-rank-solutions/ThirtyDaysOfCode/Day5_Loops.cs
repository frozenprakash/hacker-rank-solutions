using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-loops/problem
    /// </summary>
    internal static class Day5_Loops
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            for (int i = 1;
                    i <= 10;
                    i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
