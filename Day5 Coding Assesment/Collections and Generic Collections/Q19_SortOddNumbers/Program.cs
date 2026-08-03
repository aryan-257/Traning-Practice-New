Console.Write("Enter numbers separated by spaces : ");
string input = Console.ReadLine()!;

List<int> oddNumbers = new List<int>();

foreach(string token in input.Split(' '))
{
    if(int.TryParse(token.Trim() , out int num))
    {
        if(num % 2 != 0)
            oddNumbers.Add(num);
    }
    else
    {
        if(!string.IsNullOrWhiteSpace(token))
            Console.WriteLine("Ignoring non-numeric : " + token);
    }
}

oddNumbers.Sort();

Console.WriteLine("Odd numbers in ascending order :");
Console.WriteLine(string.Join(" , " , oddNumbers));
