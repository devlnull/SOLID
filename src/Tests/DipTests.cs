using SOLID.DIP;
using Xunit;

namespace Tests;

public class DipTests
{
    [Fact]
    public void RegisterWithAbstracts_WithCorrectInversion_MustUseCorrectConcretes()
    {
        var logger = DipFactory.GetLogger();
        var notifier = DipFactory.GetNotifier();
        var registerHandler = new RegisterHandler(notifier, logger);
        var person = DipFactory.GetPerson();
        person.NationalCode = "1920000000";
        person.FirstName = "Amirhossein";
        person.LastName = "Ghorbani";
        person.EmailAddress = "amirhosseinghorbani7@gmail.com";


        var registerResult = registerHandler.Register(person);
        
        Assert.True(registerResult);
    }
}