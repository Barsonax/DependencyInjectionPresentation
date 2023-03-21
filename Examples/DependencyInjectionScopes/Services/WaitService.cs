using DependencyInjectionScopes.Services.Interfaces;

namespace DependencyInjectionScopes.Services;

public class WaitService : IWaitService, IDisposable
{
    public WaitService()
    {
        Console.WriteLine($"Constructor {nameof(WaitService)}");
    }
    
    public void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }

    public void Dispose()
    {
        Console.WriteLine($"Dispose {nameof(WaitService)}");
    }
}