namespace SOLID.DIP.AbstractScenario;

public interface IServiceFactory
{
    IService MakeSvc();
}