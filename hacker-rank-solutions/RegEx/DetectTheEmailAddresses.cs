using System.Text.RegularExpressions;

namespace hacker_rank_solutions.RegEx
{
    internal static class DetectTheEmailAddresses
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
            string input,
                    pattern;
            List<string> emails;
            MatchCollection mc;

            count = Convert.ToInt32(Console.ReadLine());
            emails = new List<string>();

            for (int i = 1;
                    i <= count;
                    i++)
            {
                input = Console.ReadLine();
                pattern = @"([a-zA-Z0-9_.]+)@([a-zA-Z0-9_.]+)";

                mc = Regex.Matches(input,
                                    pattern);
                foreach (Match m in mc)
                {
                    emails.Add(m.Value);
                }
            }

            return emails;
        }
    }
}
