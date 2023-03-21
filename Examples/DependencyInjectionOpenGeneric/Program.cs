using DependencyInjectionOpenGeneric;
using DependencyInjectionOpenGeneric.Services;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

services.AddTransient(typeof(IValidator<>), typeof(Validator<>));

var serviceProvider = services.BuildServiceProvider();

serviceProvider.GetRequiredService<IValidator<Customer>>();