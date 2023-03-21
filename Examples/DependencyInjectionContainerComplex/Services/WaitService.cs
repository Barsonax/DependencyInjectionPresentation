using DependencyInjectionContainerComplex.Services.Interfaces;

namespace DependencyInjectionContainerComplex.Services;

public class WaitService : IWaitService
{
    public void Wait(int milliseconds)
    {
        Thread.Sleep(milliseconds);
    }
}