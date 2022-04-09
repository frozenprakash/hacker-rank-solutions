using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    internal static class Day10_BinaryNumbers
    {
        public static void Execute()
        {
            List<string> binary;
            List<int> continuousLength;
            int currentLength,
                binaryCount;

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            binary = new List<string>();
            binary = Convert.ToString(n, 2)
                            .ToList()
                            .ConvertAll(x => x.ToString());

            currentLength = 0;
            continuousLength = new List<int>();
            binaryCount = binary.Count;

            for (int i = 0;
                        i < binaryCount;
                        i++)
            {
                if (binary[i] == "1")
                {
                    currentLength++;
                }

                if (binary[i] != "1" ||
                    i == binaryCount-1)
                {
                    continuousLength.Add(currentLength);
                    currentLength = 0;
                    continue;
                }
            }

            Console.WriteLine(continuousLength.Max());
        }
    }
}
