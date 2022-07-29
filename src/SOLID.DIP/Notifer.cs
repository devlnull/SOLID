using System;

namespace SOLID.DIP;

public class Notifer : INotifier
{
    public void Notify(IPerson person, NotifyTypes notifyType)
    {
        var title = GetNotifyTitle(notifyType);
        var messageBody = GetNotifyMessageBody(person, notifyType);

        Console.WriteLine($"# {title} #");
        Console.WriteLine(messageBody);
        Console.WriteLine();
    }


    private string GetNotifyMessageBody(IPerson person, NotifyTypes notifyType)
    {
        return notifyType switch
        {
            NotifyTypes.Register => $"Congratulations {person.FirstName} {person.LastName}" +
                                    $" for successful registration on DIP.",
            _ => string.Empty
        };
    }
    
    private string GetNotifyTitle(NotifyTypes notifyType)
    {
        return notifyType switch
        {
            NotifyTypes.Register => $"DIP Registration",
            _ => string.Empty
        };
    }
}