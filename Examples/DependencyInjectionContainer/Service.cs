namespace DependencyInjectionContainer;

public class Service
{
    private readonly IWaitService _waitService;

    public Service(IWaitService waitService)
    {
        _waitService = waitService;
    }

    public void DoWork()
    {
        for (int i = 0; i < 10; i++)
        {
            _waitService.Wait(10000);
        }
    }
}