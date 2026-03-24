namespace task1;

public class TempSensor
{
    private int? _latestTem = null;
    public event Action<int> TempChanged;

    public void OnTempChanged(int temp)
    {
        if (_latestTem != temp)
        {
            TempChanged?.Invoke(temp);
        }
    }
}