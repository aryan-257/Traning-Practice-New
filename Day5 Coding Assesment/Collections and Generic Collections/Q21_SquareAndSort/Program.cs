Console.Write("Enter integers separated by spaces : ");
string input = Console.ReadLine()!;

List<int> numbers = new List<int>();

foreach(string token in input.Split(' '))
{
    if(int.TryParse(token.Trim() , out int num))
        numbers.Add(num);
    else if(!string.IsNullOrWhiteSpace(token))
        Console.WriteLine("Invalid input ignored : " + token);
}

Console.WriteLine("\nOriginal : " + string.Join(" , " , numbers));

List<int> squared = new List<int>();
foreach(int n in numbers)
    squared.Add(n * n);

for(int i = 0; i < squared.Count - 1; i++)
{
    for(int j = 0; j < squared.Count - i - 1; j++)
    {
        if(squared[j] > squared[j + 1])
        {
            int temp      = squared[j];
            squared[j]    = squared[j + 1];
            squared[j + 1]= temp;
        }
    }
}

Console.WriteLine("Squared and sorted : " + string.Join(" , " , squared));
