using System.Text.Json;

namespace pr4;

public class PlayerV2
{
	public string Name { get; set; }
    
	public int Level { get; set; } = 1; 
}

public class Task7
{
	public void Run()
	{
		string oldJson = "{ \"Name\": \"Маг\" }"; 

		PlayerV2 player = JsonSerializer.Deserialize<PlayerV2>(oldJson);

		Console.WriteLine($"Ім'я: {player.Name}, Рівень: {player.Level}"); 
	}
}