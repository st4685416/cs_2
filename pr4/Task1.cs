using System.Text.Json;

namespace pr4;

public class TaskItem
{
	public string Title { get; set; }
	public bool IsCompleted { get; set; }
}

public class Task1
{
	public void Run()
	{
		List<TaskItem> tasks = new List<TaskItem>();
		JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

		if (File.Exists("tasks.json"))
		{
			string jsonRead = File.ReadAllText("tasks.json");
			tasks = JsonSerializer.Deserialize<List<TaskItem>>(jsonRead);
		}

		bool isRunning = true;
		while (isRunning)
		{
			Console.WriteLine("1. Додати | 2. Змінити | 3. Переглянути | 4. Вийти");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					TaskItem newTask = new TaskItem { Title = Console.ReadLine(), IsCompleted = false };
					tasks.Add(newTask);
					break;

				case "2":
					int index = int.Parse(Console.ReadLine());
					tasks[index].IsCompleted = !tasks[index].IsCompleted;
					break;

				case "3":
					foreach (var task in tasks)
					{
						Console.WriteLine($"{task.Title} - Виконано: {task.IsCompleted}");
					}

					break;

				case "4":
					string jsonWrite = JsonSerializer.Serialize(tasks, options);
					File.WriteAllText("tasks.json", jsonWrite);
					isRunning = false;
					break;

				default:
					Console.WriteLine("Невідома команда.");
					break;
			}
		}
	}
}