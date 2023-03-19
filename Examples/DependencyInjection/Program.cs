// See https://aka.ms/new-console-template for more information

using DependencyInjection;

var waitService = new WaitService();
var service = new Service(waitService);

service.DoWork();