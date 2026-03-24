namespace task2;

public class AchievementSystem
{
    private bool _f1 = true;
    private bool _f2 = true;

    public void Achievement(DataClass data)
    {
        if (_f1 & data.Health <= 50)
        {
            _f1 = false;
            Console.WriteLine("Half Health");
        }

        if (_f2 & data.Health <= 0)
        {
            _f2 = false;
            Console.WriteLine("First Death");
        }
    }
}