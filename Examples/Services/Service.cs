namespace Services;

public class Service
{
    public void DoWork()
    {
        var waitService = new WaitService();
        for (int i = 0; i < 10; i++)
        {
            waitService.Wait(10000);
        }
    }
}