using DependencyInjection;

var waitService = new WaitService();
var service = new Service(waitService);

service.DoWork();