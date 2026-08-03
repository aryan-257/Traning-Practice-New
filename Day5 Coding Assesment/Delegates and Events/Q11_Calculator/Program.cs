using Q11_Calculator;

Calculator calc = new Calculator();

ArithmeticOperation add      = Calculator.Add;
ArithmeticOperation subtract = Calculator.Subtract;
ArithmeticOperation multiply = Calculator.Multiply;
ArithmeticOperation divide   = Calculator.Divide;

Console.WriteLine("10 + 5 = " + calc.Calculate(10 , 5 , add));
Console.WriteLine("10 - 5 = " + calc.Calculate(10 , 5 , subtract));
Console.WriteLine("10 * 5 = " + calc.Calculate(10 , 5 , multiply));
Console.WriteLine("10 / 5 = " + calc.Calculate(10 , 5 , divide));

try
{
    Console.WriteLine("10 / 0 = " + calc.Calculate(10 , 0 , divide));
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Error : " + ex.Message);
}
