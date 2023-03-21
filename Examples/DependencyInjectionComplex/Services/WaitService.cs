using DependencyInjectionComplex.Services.Interfaces;

namespace DependencyInjectionComplex.Services;

public class WaitService : IWaitService
{
    public void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}