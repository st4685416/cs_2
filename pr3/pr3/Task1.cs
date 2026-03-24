namespace pr3
{
	public class Task1
	{
		public void CountWordsSentenseChars()
		{
			string storyPath = "C:\\Users\\nerar\\OneDrive\\Рабочий стол\\pr3\\story.txt";
			string filePath = "C:\\Users\\nerar\\OneDrive\\Рабочий стол\\pr3\\reports.txt";

			using (FileStream fs = File.OpenRead(storyPath))
			{
				using (StreamReader sr = new StreamReader(fs))
				{
					string content = sr.ReadToEnd();
					string[] words = content.Split(' ', '\n', '\r', '\t');
					int wordCount = words.Length;
					int sentenceCount = content.Split('.', '!', '?').Length - 1;
					int charCount = content.Length;

					using (StreamWriter sw = new StreamWriter(filePath))
					{
						sw.WriteLine($"Total number of words: {wordCount}");
						sw.WriteLine($"Total number of sentences: {sentenceCount}");
						sw.WriteLine($"Total number of chars: {charCount}");
					}
				}
			}
		}
	}
}