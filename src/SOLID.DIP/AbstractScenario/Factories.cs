namespace SOLID.DIP.AbstractScenario;

public static class Factories
{
    public static IServiceFactory ServiceFactory = new ServiceFactoryImpl();
}