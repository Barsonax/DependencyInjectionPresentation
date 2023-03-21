using DependencyInjectionComplex.Services.Interfaces;

namespace DependencyInjectionComplex.Services;

public class HttpService : IHttpService
{
    public HttpService(IWaitService waitService)
    {
        
    }
}