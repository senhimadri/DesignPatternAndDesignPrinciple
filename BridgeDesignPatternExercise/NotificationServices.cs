namespace BridgeDesignPatternExercise;

public interface IMessageSender
{
    Task SendMessage();
}

public class EmailSender(EmailNotificationDto emailNotification) : IMessageSender
{
    public Task SendMessage()
    {
        Console.WriteLine($"{emailNotification.HtmlBody } /n Email Notification Sent.");
        return Task.CompletedTask;
    }
}

public class PushSender(PushNotificationDto pushNotification) : IMessageSender
{
    public Task SendMessage()
    {
        Console.WriteLine($" {pushNotification.MessageText} /n Push Notification Sent");
        return Task.CompletedTask;
    }
}

public class SmsSender(SmsNotificationDto smsNotification) : IMessageSender
{
    public Task SendMessage()
    {
        Console.WriteLine($"{smsNotification.MessageText} n/ SMS Notification Sent");
        return Task.CompletedTask;
    }
}


public abstract class Notification(IMessageSender messageSender)
{
    protected IMessageSender _messageSender = messageSender;
    public abstract void Send();

}

public class UrgentNotification(IMessageSender messageSender) : Notification(messageSender)
{
    public override void Send()
    {
        Console.WriteLine("Urgent Notification Sent.");
        _messageSender.SendMessage();
    }
}


public class RegularNotification(IMessageSender messageSender) : Notification(messageSender)
{
    public override void Send()
    {
        Console.WriteLine("Regular Notification Sent.");
        _messageSender.SendMessage();
    }
}


public static class NotificationClassImplementation
{

    public static void Main()
    {
        EmailNotificationDto request = new EmailNotificationDto();
        IMessageSender sendEmail = new EmailSender(request);

        Notification regularEmailNotification = new RegularNotification(sendEmail);

        regularEmailNotification.Send();
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