using System;
using CodingProblems;

int x = 10, y = 20;
Console.WriteLine($"Before ref swap: x={x}, y={y}");
Question1_Swapping.SwapWithRef(ref x, ref y);
Console.WriteLine($"After ref swap: x={x}, y={y}");

Question1_Swapping.SwapWithOut(30, 40, out int p, out int q);
Console.WriteLine($"Out swap result: p={p}, q={q}");

int[] table = Question2_MultiplicationTable.GetMultiplicationRow(3, 5);
Console.WriteLine($"\nMultiplication table (3 x 5): [{string.Join(", ", table)}]");

string[] students = { "Alice:85", "Bob:60", "Charlie:90", "Dave:70" };
string json = Question4_StringFormat.FilterAndSerialize(students, 70);
Console.WriteLine($"\nFiltered students JSON:\n{json}");

Console.WriteLine($"\n10 + 5 = {Question9_ArithmeticExpressions.EvaluateExpression("10 + 5")}");
Console.WriteLine($"10 / 0 = {Question9_ArithmeticExpressions.EvaluateExpression("10 / 0")}");
Console.WriteLine($"abc + 5 = {Question9_ArithmeticExpressions.EvaluateExpression("abc + 5")}");

Console.WriteLine($"\nLargest of 10, 30, 20 = {Question10_LargestInteger.FindLargest(10, 30, 20)}");
