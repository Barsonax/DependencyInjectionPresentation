namespace DependencyInjectionOpenGeneric.Services;

public class Validator<T> : IValidator<T>
{
    public Validator()
    {
     Console.WriteLine($"This is a validator with the generic type parameter {typeof(T).Name}");   
    }
}