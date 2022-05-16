using System.Text.RegularExpressions;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace hacker_rank_solutions.RegExp
{
    internal static class DetectHtmlLinks
    {
        public static void Execute()
        {
            int count;
            string input,
                    pattern;
            string link,
                    text;
            MatchCollection mc;
            List<string> outputs;

            count = Convert.ToInt32(Console.ReadLine());
            outputs = new List<string>();
            pattern = @"(?<=<a href="")(.*?)(?:"")(?:.*?>)(.*?)(?=</a>)";

            for (int i = 1;
                    i <= count;
                    i++)
            {
                input = Console.ReadLine();
                mc = Regex.Matches(input,
                                    pattern);

                foreach (Match m in mc)
                {
                    link = m.Groups[1].Value.Trim();
                    text = m.Groups[2].Value.Trim();

                    if (Regex.IsMatch(text,
                                        @"<b>.*</b>"))
                    {
                        text = Regex.Match(text,
                                            @"(?<=<b>)(.*?)(?=</b>)").Value;
                    }

                    text = Regex.Replace(text,
                                            @"<(.*)>",
                                            "");

                    if (link != "")
                    {
                        outputs.Add($"{link},{text}");
                    }
                }
            }

            outputs.ForEach(o => Console.WriteLine(o));
        }
    }
}
