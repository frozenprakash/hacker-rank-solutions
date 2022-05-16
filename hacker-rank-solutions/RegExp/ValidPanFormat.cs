using System.Text.RegularExpressions;

namespace hacker_rank_solutions.RegExp
{
    internal static class ValidPanFormat
    {
        public static void Execute()
        {
            List<string> inputs;
            bool isMatch;

            inputs = GetInputs();
            foreach (string input in inputs)
            {
                isMatch = Regex.IsMatch(input,
                                        @"^[A-Z]{5}[0-9]{4}[A-Z]$");
                if (isMatch)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
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