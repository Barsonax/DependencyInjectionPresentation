using DependencyInjectionComplex.Services;

var waitService = new WaitService();
var dnsService = new DnsService();
var httpService = new HttpService(new WaitService());
var databaseService = new DatabaseService();
var service = new Service(waitService, httpService, dnsService, databaseService);

service.DoWork();