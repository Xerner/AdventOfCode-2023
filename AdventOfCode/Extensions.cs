
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Day1
{
    public static class ExtensionMethods
    {
        public static int CharSwitch(this char c)
        {
            return c switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                _ => -1,
            };
        }

        static string pattern = @"(?^(one|two|three|four|five|six|seven|eight|nine|[0-9]))";
        public static string ReplaceNumberStrs(this string str)
        {
            var result = "";
            var str_ = "";
            MatchEvaluator evaluator = new MatchEvaluator(ConvertToInteger);

            // Replace the spelled out numbers with their integer form
            var match = Regex.Match(str, pattern);
            match.Groups.Values.SelectMany(() => { })
            return result;
        }

        public static string ConvertToInteger(Match match)
        {
            string number = match.Value.ToLower();

            switch (number)
            {
                case "one":
                    return "1";
                case "two":
                    return "2";
                case "three":
                    return "3";
                case "four":
                    return "4";
                case "five":
                    return "5";
                case "six":
                    return "6";
                case "seven":
                    return "7";
                case "eight":
                    return "8";
                case "nine":
                    return "9";
                default:
                    return match.Value;
            }
        }
    }
}
