Console.Write("Enter strings separated by commas : ");
string input = Console.ReadLine()!;

List<string> words = new List<string>(input.Split(','));

for(int i = 0; i < words.Count; i++)
    words[i] = words[i].Trim();

var sorted = words.OrderByDescending(w => w.Length).ThenBy(w => w).ToList();

Console.WriteLine("\nSorted by length (descending) :");
foreach(var w in sorted)
    Console.WriteLine($"  {w} (length: {w.Length})");
