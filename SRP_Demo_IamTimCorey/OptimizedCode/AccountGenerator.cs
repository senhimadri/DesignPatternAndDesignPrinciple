using SRP_Demo_IamTimCorey.OrginalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OptimizedCode;

internal class AccountGenerator
{
    public static void CreateAccount(Person person)
    {
        Console.WriteLine($"Your username is {person.FirstName.Substring(0, 1)} {person.LastName}");

    }
}
