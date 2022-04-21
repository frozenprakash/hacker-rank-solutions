using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    internal static class Day11_2DArrays
    {
        public static void Execute()
        {
            List<List<int>> list = new List<List<int>>();
            List<int> sumList = new List<int>();

            int rows = 0,
                cols = 0,
                sum = 0;

            for(int i = 0;
                    i < 6;
                    i++)
            {
                list.Add(Console.ReadLine()
                                        .TrimEnd()
                                        .Split(' ')
                                        .ToList()
                                        .Select(arrTemp => Convert.ToInt32(arrTemp))
                                        .ToList());
            }

            rows = list.Count;
            cols = list[0].Count;

            for(int row = 0;
                    row < rows - 2;
                    row++)
            {
                for(int col = 0;
                        col < cols - 2;
                        col++)
                {
                    // 1st row + 2nd row + 3rd row
                    sum = 0;
                    sum = list[row][col] + list[row][col + 1] + list[row][col + 2] +
                            list[row + 1][col + 1] +
                            list[row + 2][col] + list[row + 2][col + 1] + list[row + 2][col + 2];
                    sumList.Add(sum);
                }
            }

            Console.WriteLine($"{sumList.Max()}");
        }
    }
}
