using SRP_Demo_IamTimCorey.OrginalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OptimizedCode;

internal class PersonValidator
{
    public static bool Validate(Person person)
    {
        if (string.IsNullOrWhiteSpace(person.FirstName))
        {
            StandardMessages.DisplayValidationError(fildname: "First Name");
            return false;
        }

        if (string.IsNullOrWhiteSpace(person.LastName))
        {
            StandardMessages.DisplayValidationError(fildname: "Last Name");
            return false;
        }

        return true;
    }
}
