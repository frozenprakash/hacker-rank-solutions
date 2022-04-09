using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    internal static class Day08_Dictionary
    {
        public static void Execute()
        {
            int count = 0;

            string input = "",
                    output = "";
            string name = "";
            int number;

            string[] inputs;
            Dictionary<string, int> dict;

            dict = new Dictionary<string, int>();
            count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0;
                    i < count;
                    i++)
            {
                input = Console.ReadLine();
                inputs = input.Split(' ');

                dict.Add(inputs[0],
                         Convert.ToInt32(inputs[1]));
            }

            for (int i = 0;
                    i < count;
                    i++)
            {
                name = Console.ReadLine();

                if (dict.TryGetValue(name,
                                     out number))
                {
                    Console.WriteLine($"{name}={number}");
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
