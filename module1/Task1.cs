namespace module1;

public class Task1
{
	public delegate string TextOperation(string text);
	public TextOperation UpperCaseOperation = (text) => text.ToUpper();
	
	//TextOperation CountWordsOperation = (text) => text.Split(" ", "\n", "\t").Length.ToString();
	public TextOperation CountSymbOperation = (text) => text.Split("").Length.ToString();

	public void ProcessFile(string filePathToRead, string filePathToWrite, TextOperation operation)
	{
		string textFile=File.ReadAllText(filePathToRead);
		File.AppendAllText(filePathToWrite, operation(textFile));
	}

	public void Run()
	{
		ProcessFile("textPD21.txt", "resultPD21.txt", UpperCaseOperation);
		//ProcessFile("textPD21.txt", "resultPD21.txt", CountWordsOperation);
		ProcessFile("textPD21.txt", "resultPD21.txt", CountSymbOperation);
	}
}