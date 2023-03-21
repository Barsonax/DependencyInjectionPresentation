using DependencyInjectionContainerComplex.Services.Interfaces;

namespace DependencyInjectionContainerComplex.Services;

public class HttpService : IHttpService
{
    public HttpService(IWaitService waitService)
    {
        
    }
}