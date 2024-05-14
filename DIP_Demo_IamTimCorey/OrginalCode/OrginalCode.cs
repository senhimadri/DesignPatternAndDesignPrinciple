using DIP_ClassLibrary_IamTimCorey.OrginalCode;
using System.IO.Pipes;

namespace DIP_Demo_IamTimCorey.OrginalCode;

public static class OrginalCode
{
    public static void OrginalCodeImplementation()
    {
        Person owner = new Person()
        {
            FirstName = "Himadri",
            LastName = "Sen",
            EmailAddress = "senhimadri@gmail.com",
            PhoneNumber = "O1760907933"
        };

        Chore chore = new Chore()
        {
            ChoreName = "Take Out the Trash",
            Owner = owner
        };

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);

        chore.CompleteChore();

        Console.ReadLine();
    }
}

