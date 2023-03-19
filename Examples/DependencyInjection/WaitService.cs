namespace DependencyInjection;

public class WaitService : IWaitService
{
    public void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}