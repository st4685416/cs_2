using System.Text.Json;

namespace pr4;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
	public double AverageScore { get; set; }
}

public class Task2
{
	public void Run()
	{
		List<Student> students = new List<Student>();
		students.Add(new Student { Name = "Іван", Age = 20, AverageScore = 4.5 });
		students.Add(new Student { Name = "Анна", Age = 19, AverageScore = 5.0 });
		students.Add(new Student { Name = "Олег", Age = 21, AverageScore = 3.8 });
		students.Add(new Student { Name = "Марія", Age = 20, AverageScore = 4.9 });
		students.Add(new Student { Name = "Петро", Age = 22, AverageScore = 3.5 });

		string json = JsonSerializer.Serialize(students);
		File.WriteAllText("students.json", json);

		string readJson = File.ReadAllText("students.json");
		List<Student> loadedStudents = JsonSerializer.Deserialize<List<Student>>(readJson);

		foreach (var student in loadedStudents)
		{
			Console.WriteLine($"{student.Name} {student.Age} {student.AverageScore}");
		}
	}
}