namespace FactoryDesignPatternExercise.NotificationFactory;

public interface INotification
{
    Task SendNotification();
}

public class EmailNotification : INotification
{
    public Task SendNotification()
    {
        Console.WriteLine("Email Notification Sent");
    }
}

public class PushNotification : INotification
{
    public Task SendNotification()
    {
        Console.WriteLine("Push Notification Sent");
    }
}

public class SMSNotification : INotification
{
    public Task SendNotification()
    {
        Console.WriteLine("SMS Notification Sent");
    }
}

public interface INotificationFactory
{
    INotification CreateNotification();
}

public class EmailNotificationFactory : INotificationFactory
{
    public INotification CreateNotification() => new EmailNotification();
}

public class PushNotificationFactory : INotificationFactory
{
    public INotification CreateNotification() => new PushNotification();
}

public class SmsNotificationFactory : INotificationFactory
{
    public INotification CreateNotification() => new SMSNotification();
}

public class NotificationService(INotificationFactory factory)
{
    private INotification notification = factory.CreateNotification();
    public INotification GetNotification() => notification;
}


public class Implementation
{
    public static void Main()
    {
        INotificationFactory emailNotificationFactory = new EmailNotificationFactory();
        NotificationService emailNotificationService = new NotificationService(emailNotificationFactory);
        INotification emailNotification = emailNotificationService.GetNotification();

        emailNotification.SendNotification();
    }
}