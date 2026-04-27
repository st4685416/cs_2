using System.Text.Json;
using System.Text.Json.Serialization;

namespace pr4;

public class Author
{
	public string Name { get; set; }
	public List<Book> Books { get; set; } = new List<Book>();
}

public class Book
{
	public string Title { get; set; }
	public Author Author { get; set; }
}

public class Task3
{
	public void Run()
	{
		Author author = new Author { Name = "Шевченко" };
		Book book = new Book { Title = "Кобзар", Author = author };
		author.Books.Add(book);

		JsonSerializerOptions options = new JsonSerializerOptions 
		{ 
			ReferenceHandler = ReferenceHandler.Preserve 
		};

		string json = JsonSerializer.Serialize(author, options);
		Console.WriteLine(json);
	}
}