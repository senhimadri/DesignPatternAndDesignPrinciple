using SRP_Demo_IamTimCorey.OrginalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Demo_IamTimCorey.OptimizedCode;

internal class OptimizedCode
{
    static void Implementation()
    {
        StandardMessages.WelcomeMessage();

        // Ask for user information

        Person user = PersonDataCapture.capture();

        // Check to be sure that the first name and last name are valid

        bool isUserValid = PersonValidator.Validate(user);

        if (!isUserValid)
        {
            StandardMessages.EndApplication();
            return;
        }


        // Create a user name for this person .

        AccountGenerator.CreateAccount(user);

        StandardMessages.EndApplication();

    }
}
