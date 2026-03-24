namespace task5;

class Program
{
	static void Main()
	{
		Logger myLogger = new Logger();

		myLogger.LogHandler = (msg) => Console.WriteLine($"{msg}");
		myLogger.Log("ффф");

		myLogger.LogHandler = (msg) => Console.WriteLine($"{msg.ToUpper()}");
		myLogger.Log("ффф");
	}
}