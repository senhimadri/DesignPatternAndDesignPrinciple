using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OrginalCode;

internal class OrginalCode
{
    static void Implementation()
    {
        Console.WriteLine("Welcome to my Application. ");

        // Ask for user information
        Person user = new Person();

        Console.WriteLine("What is your first name: ");
        user.FirstName = Console.ReadLine();

        Console.WriteLine("What is your last name : ");
        user.LastName = Console.ReadLine();


        // Check to be sure that the first name and last name are valid

        if (string.IsNullOrWhiteSpace(user.FirstName))
        {
            Console.WriteLine("You didn't give us a valid First Name. ");
            Console.ReadLine();
            return;
        }

        if (string.IsNullOrWhiteSpace(user.LastName))
        {
            Console.WriteLine("You didn't give us a valid Last Name. ");
            Console.ReadLine();
            return;
        }

        // Create a user name for this person .
        Console.WriteLine($"Your username is {user.FirstName.Substring(0,1)} {user.LastName }");

        Console.ReadLine();    

    }
}
