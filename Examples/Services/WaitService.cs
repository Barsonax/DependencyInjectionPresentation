namespace NoDependencyInjection;

public class WaitService
{
    public void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}