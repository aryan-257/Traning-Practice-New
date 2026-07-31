using System;
using CodingProblems;

Console.WriteLine("=== Q1: Swapping ===");
int x = 10, y = 20;
Console.WriteLine($"Before ref swap: x={x}, y={y}");
Question1_Swapping.SwapWithRef(ref x, ref y);
Console.WriteLine($"After ref swap: x={x}, y={y}");
Question1_Swapping.SwapWithOut(30, 40, out int p, out int q);
Console.WriteLine($"Out swap result: p={p}, q={q}");

Console.WriteLine("\n=== Q2: Multiplication Table ===");
int[] table = Question2_MultiplicationTable.GetMultiplicationRow(3, 5);
Console.WriteLine($"Table (3 x 5): [{string.Join(", ", table)}]");

Console.WriteLine("\n=== Q4: String Format ===");
string[] students = { "Alice:85", "Bob:60", "Charlie:90", "Dave:70" };
string json = Question4_StringFormat.FilterAndSerialize(students, 70);
Console.WriteLine($"Filtered JSON: {json}");

Console.WriteLine("\n=== Q9: Arithmetic Expressions ===");
Console.WriteLine($"10 + 5 = {Question9_ArithmeticExpressions.EvaluateExpression("10 + 5")}");
Console.WriteLine($"10 / 0 = {Question9_ArithmeticExpressions.EvaluateExpression("10 / 0")}");
Console.WriteLine($"abc + 5 = {Question9_ArithmeticExpressions.EvaluateExpression("abc + 5")}");

Console.WriteLine("\n=== Q10: Largest Integer ===");
Console.WriteLine($"Largest of 10, 30, 20 = {Question10_LargestInteger.FindLargest(10, 30, 20)}");

Console.WriteLine("\n=== Q13: Display Height ===");
Console.WriteLine($"140cm = {Question13_DisplayHeight.GetHeightCategory(140)}");
Console.WriteLine($"165cm = {Question13_DisplayHeight.GetHeightCategory(165)}");
Console.WriteLine($"185cm = {Question13_DisplayHeight.GetHeightCategory(185)}");

Console.WriteLine("\n=== Q16: Lucky Numbers ===");
Console.WriteLine($"Lucky numbers between 20-30 = {Question16_LuckyNumbers.CountLuckyNumbers(20, 30)}");

Console.WriteLine("\n=== Q19: Bank Transaction ===");
int finalBalance = Question19_BankTransaction.GetFinalBalance(1000, new int[] { 500, -200, -2000, 100 });
Console.WriteLine($"Final balance = {finalBalance}");

Console.WriteLine("\n=== Q22: Mahirl Alphabets ===");
Console.WriteLine($"Result = {Question22_MahirlAlphabets.Process("programming", "morning")}");

Console.WriteLine("\n=== Q24: Merge Sorted Arrays ===");
int[] merged = Question24_SortedArrays.MergeSorted(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
Console.WriteLine($"Merged = [{string.Join(", ", merged)}]");

Console.WriteLine("\n=== Q27: Inventory Name Cleanup ===");
Console.WriteLine($"Cleaned = {Question27_InventoryNameCleanup.CleanProductName(" llapppptop bag ")}");
