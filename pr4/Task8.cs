using System.Text.Json;

namespace pr4;

public class Task8
{
	public void Run()
	{
		string badJson = "це не json формат";

		try
		{
			JsonSerializer.Deserialize<object>(badJson);
		}
		catch (JsonException ex)
		{
			Console.WriteLine("Сталася помилка при читанні JSON!");
		}
	}
}