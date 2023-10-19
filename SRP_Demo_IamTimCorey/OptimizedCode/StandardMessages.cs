using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OptimizedCode;

internal class StandardMessages
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to my Application. ");
    }

    public static void EndApplication()
    {
        Console.WriteLine("Press enter to close .");
        Console.ReadLine();
    }

    public static void DisplayValidationError(string fildname)
    {
        Console.WriteLine($"You did not give us a valid {fildname} !");
    }
}
