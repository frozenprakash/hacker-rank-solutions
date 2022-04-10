using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    internal static class CountingValleysAndMountains
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/counting-valleys/problem
        /// </summary>
        /// <param name="steps"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        public static int countingValleys(int steps,
                                          string path)
        {
            int prevStep = 0,
                step = 0,
                mountain = 0,
                valley = 0;

            foreach (char c in path)
            {
                switch (c)
                {
                    case 'U':
                        step++;
                        if (prevStep == 0)
                        {
                            mountain++;
                        }

                        break;

                    case 'D':
                        step--;
                        if (prevStep == 0)
                        {
                            valley++;
                        }

                        break;
                }

                prevStep = step;
            }

            return valley;
            //return mountain;
        }
    }
}
