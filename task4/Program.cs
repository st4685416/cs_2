namespace task4;

public class Task4
{
	public static Func<double, double, double>? MathOperation;

	static void Main()
	{
		MathOperation = null;

		MathOperation = Add;
		Console.WriteLine(MathOperation(1, 2));

		MathOperation = Subtract;
		Console.WriteLine(MathOperation(1, 2));

		MathOperation = Multiply;
		Console.WriteLine(MathOperation(1, 2));

		MathOperation = Divide;
		Console.WriteLine(MathOperation(1, 2));
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