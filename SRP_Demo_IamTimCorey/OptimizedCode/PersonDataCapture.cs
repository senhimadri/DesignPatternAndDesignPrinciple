using SRP_Demo_IamTimCorey.OrginalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OptimizedCode;

internal class PersonDataCapture
{
    public static Person capture()
    {
        Person output = new Person();

        Console.WriteLine("What is your first name: ");
        output.FirstName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine("What is your last name : ");
        output.LastName = Console.ReadLine() ?? string.Empty;

        return output;
    }
}
