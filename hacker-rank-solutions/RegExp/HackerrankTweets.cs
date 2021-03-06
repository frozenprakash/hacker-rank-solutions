using System.Text.RegularExpressions;

namespace hacker_rank_solutions.RegExp
{
    internal class HackerrankTweets
    {
        public static void Execute()
        {
            List<string> inputs;
            bool isMatch;
            int count = 0;

            inputs = GetInputs();
            foreach (string input in inputs)
            {
                isMatch = Regex.IsMatch(input,
                                        @"^.*?(hackerrank).*?$",
                                        RegexOptions.IgnoreCase);
                if (isMatch)
                {
                    count++;
                }
            }

            Console.WriteLine(count.ToString());
        }

        static List<string> GetInputs()
        {
            int count;
            List<string> inputs;

            count = Convert.ToInt32(Console.ReadLine());
            inputs = new List<string>();

            for (int i = 1;
                    i <= count;
                    i++)
            {
                inputs.Add(Console.ReadLine());
            }

            return inputs;
        }
    }
}