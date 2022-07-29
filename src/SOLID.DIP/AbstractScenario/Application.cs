using System;

namespace SOLID.DIP.AbstractScenario;

public class Application
{
    public void Main(string[] args)
    {
        var service = Factories.ServiceFactory.MakeSvc();

        Console.WriteLine($"Operation result: {service.Operate()}");
    }
}