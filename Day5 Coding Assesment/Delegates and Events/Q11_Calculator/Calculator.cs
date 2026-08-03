namespace Q11_Calculator;

public delegate double ArithmeticOperation(double a , double b);

public class Calculator
{
    public static double Add(double a , double b) => a + b;
    public static double Subtract(double a , double b) => a - b;
    public static double Multiply(double a , double b) => a * b;

    public static double Divide(double a , double b)
    {
        if(b == 0)
            throw new DivideByZeroException("Cannot divide by zero");
        return a / b;
    }

    public double Calculate(double a , double b , ArithmeticOperation op)
    {
        return op(a , b);
    }
}
