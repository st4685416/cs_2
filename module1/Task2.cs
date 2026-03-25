
namespace module1;

public class Task2
{
	public void EnterText(string pathFile)
	{
		string? newText = Console.ReadLine();
		File.AppendAllText(pathFile, newText);
	}
}

public class MessegePublisher
{
	public event Action<string>? MessegeSender;
	public void Send(string messege)
	{
		MessegeSender?.Invoke(messege);
	}
}

public class FileLogger
{
	private string _path="resultPD21.txt";
	
	public void Log(string messege)
	{
		File.AppendAllText(_path, $"[{TimeZoneInfo.Local}]{messege}");
	}
}

public class Run()
{
	
}