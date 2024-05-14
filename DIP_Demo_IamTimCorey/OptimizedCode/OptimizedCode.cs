using DIP_ClassLibrary_IamTimCorey.OptimizedCode;
using System.Security.Cryptography.X509Certificates;

namespace DIP_Demo_IamTimCorey.OptimizedCode;

public static class OptimizedCode
{
    public static void OptimizedCodeImplementation()
    {
        IPerson owner = Factory.CreatePerson();
        owner.FirstName = "Himadri";
        owner.LastName = "Sen";
        owner.EmailAddress = "senhimadri@gmail.com";
        owner.PhoneNumber = "O1760907933";


        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Take Out the Trash";
        chore.Owner = owner;

        chore.PerformedWork(3);
        chore.PerformedWork(1.5);

        chore.CompleteChore();

        Console.ReadLine();
    }
}

