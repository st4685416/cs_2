namespace task6;

class Program
{
	delegate bool Validator(string? s);

	static void Main()
	{
		Validator val3 = GetValidator(3);
		Validator val8 = GetValidator(8);
		Console.WriteLine(val3(Console.ReadLine()));
		Console.WriteLine(val8(Console.ReadLine()));
	}

	static Validator GetValidator(int minLength)
	{
		return (str) => str != null && str.Length >= minLength;
	}
}