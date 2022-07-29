namespace SOLID.DIP;

public interface INotifier
{
    void Notify(IPerson person, NotifyTypes notifyType);
}