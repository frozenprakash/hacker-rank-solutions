using System.Text.RegularExpressions;

namespace hacker_rank_solutions.RegExp
{
    internal static class SplitThePhoneNumbers
    {
        static void Main(String[] args)
        {
            List<string> inputs;
            Match m;

            inputs = GetInputs();
            foreach (string input in inputs)
            {
                m = Regex.Match(input,
                                @"^(.*?)[-| ](.*?)[-| ](.*?)$");
                Console.WriteLine($"CountryCode={m.Groups[1].Value},LocalAreaCode={m.Groups[2].Value},Number={m.Groups[3].Value}");
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
