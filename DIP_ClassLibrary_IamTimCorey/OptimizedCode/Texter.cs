namespace DIP_ClassLibrary_IamTimCorey.OptimizedCode;

public class Texter : IMessageSender
{
    public void SendMessage(IPerson person, string message)
    {
        Console.WriteLine($"I am texting {person.FirstName} to say {message}");
    }
}

