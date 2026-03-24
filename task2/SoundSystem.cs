namespace task2;

public class SoundSystem
{
    public void Sound(DataClass data)
    {
        Console.WriteLine("відтворює звук отримання урону");
        if (data.Health <= 20)
        {
            Console.WriteLine("відтворює звук критичного стану.");
        }
    }
}