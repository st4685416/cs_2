namespace task1;

public class AirConditioner
{
    public void ChangeMode(int temp)
    {
        switch (temp)
        {
            case >25:
                Console.WriteLine("увімкнути обігрів");
                break;
            case <17:
                Console.WriteLine("кондиціонер вимкнений");;
                break;
            default:
                Console.WriteLine("увімкнути охолодження");
                break;
        }
    }
}