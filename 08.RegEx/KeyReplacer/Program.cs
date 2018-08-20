using System;
using System.Text;
using System.Text.RegularExpressions;

public class Key_Replacer
{
    public static void Main()
    {
        var key = Console.ReadLine();
        var text = Console.ReadLine();

        var pattern = @"^([a-zA-Z]*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)([a-zA-Z]*)$";


        var keyMatch = Regex.Match(key, pattern);

        if (keyMatch.Success)
        {
            var startKey = keyMatch.Groups[1].Value;
            var endKey = keyMatch.Groups[2].Value;

            var textPattern = $"{startKey}(?<word>.*?){endKey}";
            var matches = Regex.Matches(text, textPattern);

            var result = new StringBuilder();

            foreach (Match m in matches)
            {
                result.Append(m.Groups["word"].Value);
            }
            Console.WriteLine(result.ToString().Length == 0 ? "Empty result" : result.ToString());
        }
    }
}