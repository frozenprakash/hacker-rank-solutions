using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hacker_rank_solutions.RegEx
{
    internal static class Emails
    {
        public static void Execute()
        {
            string output;
            List<string> emails = GetAllEmails();

            // Distinct & sort lexicographically
            emails = emails.Distinct()
                            .OrderBy(e => e)
                            .ThenBy(e => e.Length)
                            .ToList();

            output = string.Join(";",
                                    emails);
            Console.WriteLine(output);
        }

        private static List<string> GetAllEmails()
        {
            int count;
            string input;
            List<string> emails;
            MatchCollection mc;

            count = Convert.ToInt32(Console.ReadLine());
            emails = new List<string>();

            for (int i = 1;
                    i <= count;
                    i++)
            {
                input = Console.ReadLine();

                mc = Regex.Matches(input,
                                    @"([a-zA-Z0-9_.]+)@([a-zA-Z0-9_.]+)");
                foreach (Match m in mc)
                {
                    emails.Add(m.Value);
                }
            }

            return emails;
        }
    }
}
