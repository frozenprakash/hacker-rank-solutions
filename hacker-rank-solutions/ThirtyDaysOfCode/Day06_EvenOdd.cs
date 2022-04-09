using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    internal static class Day06_EvenOdd
    {
        static string Even { get; set; } = "";
        static string Odd { get; set; } = "";

        public static void Execute()
        {
            int count;
            List<string> inputs = new List<string>();
            List<string> outputs = new List<string>();

            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;
                    i <= count;
                    i++)
            {
                inputs.Add(Console.ReadLine());
            }

            foreach (string input in inputs)
            {
                EvenOdd(input);
                Console.WriteLine($"{Even} {Odd}");
            }
        }

        static void EvenOdd(string input)
        {
            Even = "";
            Odd = "";

            for (int i = 0;
                    i < input.Length;
                    i++)
            {
                if (i % 2 == 0)
                {
                    Even += input[i].ToString();
                }
                else
                {
                    Odd += input[i].ToString();
                }
            }
        }

    }
}
