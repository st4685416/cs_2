namespace task2;

class Program
{
    
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Player player=new Player();
        UiHealthBar uiHealthBar=new UiHealthBar();
        SoundSystem soundSystem=new SoundSystem();
        AchievementSystem achievementSystem=new AchievementSystem();
        GameLogger gameLogger=new GameLogger();
        
        player.DamageTaken += uiHealthBar.ShowHealthBar;
        player.DamageTaken += soundSystem.Sound;
        player.DamageTaken += achievementSystem.Achievement;
        player.DamageTaken += gameLogger.WriteLog;
        
        player.OnDamageTaken(10);
        player.OnDamageTaken(20);
        player.OnDamageTaken(30);
        player.OnDamageTaken(40);
    }
}

public class DataClass:EventArgs
{
    public int Health{get;init;}
    public int LastDamageTaken{get;init;}
}