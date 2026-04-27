using System.Text.Json;

namespace pr4;

public class Inventory
{
	public List<string> Items { get; set; } = new List<string>();
}

public class Player
{
	public string Name { get; set; }
	public Inventory Inventory { get; set; }
}

public class Task6
{
	public void Run()
	{
		string json = "{ \"Name\": \"Герой\" }"; 

		Player player = JsonSerializer.Deserialize<Player>(json);

		if (player.Inventory == null)
		{
			player.Inventory = new Inventory();
		}

		Console.WriteLine(player.Inventory.Items.Count);
	}
}