namespace task3;

class Program
{
	delegate bool FilterPredicate(int number);

	static void Main()
	{
		int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
		FilterArray(numbers, n => n % 2 == 0);
		FilterArray(numbers, n => n > 5);
		FilterArray(numbers, n => n % 2 == 1);
	}

	static void FilterArray(int[] numbers, FilterPredicate predicate)
	{
		foreach (int var in numbers)
		{
			if (predicate(var))
			{
				Console.Write($"{var} ");
			}
		}

		Console.Write("\n");
	}
}