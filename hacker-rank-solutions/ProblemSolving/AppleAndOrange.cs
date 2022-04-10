using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ProblemSolving
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/apple-and-orange/problem
    /// </summary>
    internal static class AppleAndOrange
    {
        public static void countApplesAndOranges(int s,
                                                 int t,
                                                 int a,
                                                 int b,
                                                 List<int> apples,
                                                 List<int> oranges)
        {
            List<int> droppedApples,
                        droppedOranges;
            int applesOnHouse = 0,
                orangesOnHouse = 0;

            droppedApples = new List<int>();
            droppedOranges = new List<int>();

            droppedApples = apples.Select(x => a + x)
                                  .ToList();
            droppedOranges = oranges.Select(x => b + x)
                                    .ToList();

            applesOnHouse = droppedApples.Where(x => x >= s &&
                                                        x <= t)
                                            .Count();

            orangesOnHouse = droppedOranges.Where(x => x >= s &&
                                                        x <= t)
                                            .Count();

            Console.WriteLine(applesOnHouse.ToString());
            Console.WriteLine(orangesOnHouse.ToString());
        }
    }
}
