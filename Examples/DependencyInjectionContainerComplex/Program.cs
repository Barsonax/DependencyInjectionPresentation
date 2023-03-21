using DependencyInjectionContainerComplex.Services;
using DependencyInjectionContainerComplex.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IWaitService, WaitService>();
services.AddTransient<IDnsService, DnsService>();
services.AddTransient<IHttpService, HttpService>();
services.AddTransient<IDatabaseService, DatabaseService>();
services.AddTransient<Service>();

var serviceProvider = services.BuildServiceProvider();

var service = serviceProvider.GetRequiredService<Service>();

service.DoWork();