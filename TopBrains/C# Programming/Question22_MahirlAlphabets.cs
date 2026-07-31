using System.Text;

namespace CodingProblems;

public class Question22_MahirlAlphabets
{
    private static bool IsVowel(char c)
    {
        return "aeiouAEIOU".IndexOf(c) >= 0;
    }

    public static string Process(string word1, string word2)
    {
        var commonConsonants = new System.Collections.Generic.HashSet<char>();

        foreach (char c in word2.ToLower())
        {
            if (!IsVowel(c))
                commonConsonants.Add(c);
        }

        var sb = new StringBuilder();
        foreach (char c in word1)
        {
            if (IsVowel(c) || !commonConsonants.Contains(char.ToLower(c)))
                sb.Append(c);
        }

        var result = new StringBuilder();
        for (int i = 0; i < sb.Length; i++)
        {
            if (i == 0 || char.ToLower(sb[i]) != char.ToLower(sb[i - 1]))
                result.Append(sb[i]);
        }

        return result.ToString();
    }
}
