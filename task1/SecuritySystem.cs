namespace task1;

public class SecuritySystem
{
    public void ShowWarning(int temp)
    {
        switch (temp)
        {
            case > 40:
                Console.WriteLine("повідомлення про перегрів");
                break;
            case < 5:
                Console.WriteLine("попередження про ризик замерзання систем");
                break;
        }
    }
}