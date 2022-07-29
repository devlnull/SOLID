namespace SOLID.DIP.AbstractScenario;

public class ServiceFactoryImpl : IServiceFactory
{
    public IService MakeSvc()
    {
        return new ConcreteImpl();
    }
}