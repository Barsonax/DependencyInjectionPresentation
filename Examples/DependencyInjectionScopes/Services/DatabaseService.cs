using DependencyInjectionScopes.Services.Interfaces;

namespace DependencyInjectionScopes.Services;

public class DatabaseService : IDatabaseService, IDisposable
{
    public DatabaseService()
    {
        Console.WriteLine($"Constructor {nameof(DatabaseService)}");
    }
    
    public void Dispose()
    {
        Console.WriteLine($"Dispose {nameof(DatabaseService)}");
    }
}