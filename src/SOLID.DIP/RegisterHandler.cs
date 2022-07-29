namespace SOLID.DIP;

public class RegisterHandler
{
    private readonly INotifier _notifier;
    private readonly ILogger _logger;

    public RegisterHandler(INotifier notifier, ILogger logger)
    {
        _notifier = notifier;
        _logger = logger;
    }
    
    public bool Register(IPerson person)
    {
        if (person == null)
            return false;
        
        _logger.Log($"{person.FirstName} {person.LastName} with" +
                          $" national code {person.NationalCode} has been registered.");

        _notifier.Notify(person, NotifyTypes.Register);

        return true;
    }
}