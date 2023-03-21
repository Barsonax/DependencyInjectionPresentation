using DependencyInjectionScopes.Services;
using DependencyInjectionScopes.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IWaitService, WaitService>();
services.AddScoped<IDatabaseService, DatabaseService>();

var serviceProvider = services.BuildServiceProvider();

Console.WriteLine("Before Scope");
using (var scope = serviceProvider.CreateScope())
{
    Console.WriteLine("Inside Scope");
    scope.ServiceProvider.GetRequiredService<IWaitService>();
    scope.ServiceProvider.GetRequiredService<IWaitService>();
    scope.ServiceProvider.GetRequiredService<IWaitService>();
    
    scope.ServiceProvider.GetRequiredService<IDatabaseService>();
    scope.ServiceProvider.GetRequiredService<IDatabaseService>();
    scope.ServiceProvider.GetRequiredService<IDatabaseService>();
}
Console.WriteLine("After Scope");