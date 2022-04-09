using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-conditional-statements/problem
    /// </summary>
    internal class Day03_ConditionalStatement
    {
        public static void Execute()
        {
            string output = "";
            int N = Convert.ToInt32(Console.ReadLine().Trim());

            if (N % 2 == 0)
            {
                if (N >= 2 &&
                    N <= 5)
                {
                    output = "Not Weird";
                }
                else if (N >= 6 &&
                            N <= 20)
                {
                    output = "Weird";
                }
                else if (N > 20)
                {
                    output = "Not Weird";
                }
            }
            else
            {
                output = "Weird";
            }

            Console.WriteLine(output);
        }
    }
}
