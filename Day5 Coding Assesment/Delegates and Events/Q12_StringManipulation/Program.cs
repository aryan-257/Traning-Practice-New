Action<string> reverseStr = (str) =>
{
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    Console.WriteLine("Reversed : " + new string(chars));
};

Func<string , bool> isPalindrome = (str) =>
{
    string lower = str.ToLower();
    char[] chars = lower.ToCharArray();
    Array.Reverse(chars);
    return lower == new string(chars);
};

Func<string , string> toUpperCase = (str) => str.ToUpper();

Func<string , int> countVowels = (str) =>
{
    int count = 0;
    foreach(char c in str.ToLower())
    {
        if("aeiou".Contains(c))
            count++;
    }
    return count;
};

string[] words = { "madam" , "hello" , "racecar" , "world" , "level" };

foreach(var word in words)
{
    Console.WriteLine($"\nWord : {word}");
    reverseStr(word);
    Console.WriteLine("Is Palindrome : " + isPalindrome(word));
    Console.WriteLine("Upper case    : " + toUpperCase(word));
    Console.WriteLine("Vowel count   : " + countVowels(word));
}
