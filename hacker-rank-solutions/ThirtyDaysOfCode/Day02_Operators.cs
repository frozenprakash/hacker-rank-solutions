using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hacker_rank_solutions.ThirtyDaysOfCode
{
    /// <summary>
    /// https://www.hackerrank.com/challenges/30-operators/problem
    /// </summary>
    internal static class Day02_Operators
    {
        public static void Execute(double meal_cost,
                                   int tip_percent,
                                   int tax_percent)
        {
            decimal meal,
                    tip,
                    tax,
                    total;

            meal = (decimal)meal_cost;
            tip = meal * (tip_percent / 100m);
            tax = meal * (tax_percent / 100m);

            total = meal + tip + tax;
            total = Math.Round(total,
                               0);

            Console.WriteLine(total);
        }
    }
}
