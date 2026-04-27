using System.Text.Json;
using System.Text.Json.Serialization;

namespace pr4;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(Dog), "Dog")]
[JsonDerivedType(typeof(Cat), "Cat")]
public abstract class Animal
{
	public string Name { get; set; }
}

public class Dog : Animal
{
	public int BarkVolume { get; set; }
}

public class Cat : Animal
{
	public int Lives { get; set; }
}

public class Task5
{
	public void Run()
	{
		List<Animal> animals = new List<Animal>();
		animals.Add(new Dog { Name = "Собак", BarkVolume = 10 });
		animals.Add(new Cat { Name = "Котак", Lives = 9 });

		string json = JsonSerializer.Serialize(animals);
        
		List<Animal> loadedAnimals = JsonSerializer.Deserialize<List<Animal>>(json);

		foreach (var animal in loadedAnimals)
		{
			Console.WriteLine(animal.GetType().Name); 
		}
	}
}