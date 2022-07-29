namespace SOLID.DIP;

public static class DipFactory
{
    public static ILogger GetLogger() => new Logger();
    public static INotifier GetNotifier() => new Notifer();
    public static IPerson GetPerson() => new Person();
}