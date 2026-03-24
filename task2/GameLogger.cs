namespace task2;

public class GameLogger
{
    public void WriteLog(DataClass data)
    {
        Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} Message: damage taken: {data.LastDamageTaken} current health: {data.Health}");
    }
}