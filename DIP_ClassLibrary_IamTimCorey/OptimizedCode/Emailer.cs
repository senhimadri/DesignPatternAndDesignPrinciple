namespace DIP_ClassLibrary_IamTimCorey.OptimizedCode;

public class Emailer
{

    public void SendEmail(IPerson person, string message)
    {
        Console.WriteLine($"Simulating sending email to {person.EmailAddress}");
    }
}

