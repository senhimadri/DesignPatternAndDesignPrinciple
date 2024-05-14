namespace DIP_ClassLibrary_IamTimCorey.OrginalCode;

public class Emailer
{

    public void SendEmail(Person person, string message)
    {
        Console.WriteLine($"Simulating sending email to {person.EmailAddress}");
    }
}

