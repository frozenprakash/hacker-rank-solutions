using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-arrays/problem
    /// </summary>
    internal static class Day07_Arrays
    {
        public static void Execute()
        {
            int n = Convert.ToInt32(Console.ReadLine()
                        .Trim());
            List<int> arr = Console.ReadLine()
                                    .TrimEnd()
                                    .Split(' ')
                                    .ToList()
                                    .Select(arrTemp => Convert.ToInt32(arrTemp))
                                    .ToList();
            arr.Reverse();
            Console.WriteLine(string.Join(" ",
                                                arr));
        }
    }
}
