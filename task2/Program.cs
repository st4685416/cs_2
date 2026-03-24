namespace task2;

class Program
{
	delegate void NotificationHandler(string message);

	static void Main()
	{
		NotificationHandler? notificationHandler = null;
		notificationHandler += SendEmail;
		notificationHandler += SendSMS;
		notificationHandler("my message");
	}

	static void SendEmail(string message)
	{
		Console.WriteLine($"Email sent: {message}");
	}

	static void SendSMS(string message)
	{
		Console.WriteLine($"SMS sent: {message}");
	}
}