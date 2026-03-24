namespace task2;

public class Player
{
    private int _health=100;
    public event Action<DataClass>? DamageTaken;
    
    public void OnDamageTaken(int damage)
    {
        _health -= damage;
        DamageTaken?.Invoke(new DataClass{Health = _health,LastDamageTaken = damage});
    }
}