namespace pr1;

public class Task1
{
	delegate double MathOperation(double a, double b);

	static void Main()
	{
		MathOperation? mathOperation;

		mathOperation = Add;
		Console.WriteLine(mathOperation(1, 2));

		mathOperation = Subtract;
		Console.WriteLine(mathOperation(1, 2));

		mathOperation = Multiply;
		Console.WriteLine(mathOperation(1, 2));

		mathOperation = Divide;
		Console.WriteLine(mathOperation(1, 2));
	}

	static double Add(double a, double b)
	{
		return a + b;
	}

	static double Subtract(double a, double b)
	{
		return a - b;
	}

	static double Multiply(double a, double b)
	{
		return a * b;
	}

	static double Divide(double a, double b)
	{
		return a / b;
	}
}