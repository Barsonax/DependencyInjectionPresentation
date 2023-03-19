// See https://aka.ms/new-console-template for more information

using DependencyInjectionContainer;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient<IWaitService, WaitService>();
services.AddTransient<Service>();

var serviceProvider = services.BuildServiceProvider();

var service = serviceProvider.GetRequiredService<Service>();

service.DoWork();