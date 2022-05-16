using System.Text.RegularExpressions;

namespace hacker_rank_solutions.RegExp
{
    internal static class IPAddressValidation
    {
        public static void Execute()
        {
            List<string> inputs;

            inputs = GetInputs();
            foreach (string input in inputs)
            {
                Console.WriteLine(ValidateIpAddress(input));
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

        static string ValidateIpAddress(string ipAddress)
        {
            if (Regex.IsMatch(ipAddress,
                                @"^(([0-9]|[0-9][0-9]|[0-1][0-9][0-9]|[0-2][0-5][0-5])\.){3}([0-9]|[0-9][0-9]|[0-1][0-9][0-9]|[0-2][0-5][0-5])$"))
            {
                return "IPv4";
            }
            else if (Regex.IsMatch(ipAddress,
                                   @"^([0-9a-f]{1,4}:){7}([0-9a-f]{1,4})$"))
            {
                return "IPv6";
            }
            else
            {
                return "Neither";
            }
        }
    }
}
