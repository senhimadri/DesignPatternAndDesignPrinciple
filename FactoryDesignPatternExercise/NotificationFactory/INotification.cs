namespace FactoryDesignPatternExercise.NotificationFactory;

public interface INotification<TRequest>
{
    Task SendNotification(TRequest request);
}

public class EmailNotification: INotification <EmailNotificationDto>
{
    public Task SendNotification(EmailNotificationDto request)
    {
        Console.WriteLine("Email Notification Sent.");
        return Task.CompletedTask;
    }
}

public class PushNotification : INotification<PushNotificationDto>
{
    public Task SendNotification(PushNotificationDto request)
    {
        Console.WriteLine("Push Notification Sent");
        return Task.CompletedTask;
    }
}

public class SMSNotification : INotification<SmsNotificationDto>
{
    public Task SendNotification(SmsNotificationDto request)
    {
        Console.WriteLine("SMS Notification Sent");
        return Task.CompletedTask;
    }
}

public interface INotificationFactory<TRequest>
{
    INotification<TRequest> CreateNotification();
}

public class EmailNotificationFactory : INotificationFactory<EmailNotificationDto>
{
    public INotification<EmailNotificationDto> CreateNotification() => new EmailNotification();
}

public class PushNotificationFactory : INotificationFactory<PushNotificationDto>
{
    public INotification<PushNotificationDto> CreateNotification() => new PushNotification();
}

public class SmsNotificationFactory : INotificationFactory<SmsNotificationDto>
{
    public INotification<SmsNotificationDto> CreateNotification() => new SMSNotification();
}

public class NotificationService<TRequest>(INotificationFactory<TRequest> factory)
{
    private readonly INotification<TRequest> notification = factory.CreateNotification();
    public INotification<TRequest> GetNotification() => notification;
}

public class Implementation
{
    public static void Main()
    {
        INotificationFactory<EmailNotificationDto> emailNotificationFactory = new EmailNotificationFactory();
        NotificationService<EmailNotificationDto> emailNotificationService = new NotificationService<EmailNotificationDto>(emailNotificationFactory);
        INotification<EmailNotificationDto> emailNotification = emailNotificationService.GetNotification();

        var request = new EmailNotificationDto
        {
            SenderEmail=""
        };

        emailNotification.SendNotification(request);
    }
}


public class EmailNotificationDto
{
    public string SenderEmail { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public List<string>? Cc { get; set; }
    public string? HtmlBody { get; set; }
    public byte[]? Attachment { get; set; }
}

public class PushNotificationDto
{
    public string ClientId { get; set; } = string.Empty;
    public string MessageText { get; set; } = string.Empty;
}

public class SmsNotificationDto
{
    public string PhoneNumber { get; set; } = string.Empty;
    public string MessageText { get; set; } = string.Empty;
}