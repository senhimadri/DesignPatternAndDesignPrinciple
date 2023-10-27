using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_ClassLibrary_IamTimCorey.OrginalCode;

public class Accounts
{
    public EmployeeModel Create(PersonModel person)
    {
        EmployeeModel output = new EmployeeModel();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0,1)}{person.LastName}@acme.com";

        //if (person.TypeofEmployee == EmployeeType.Manager)
        //{
        //    output.IsManager = true;
        //}

        switch (person.TypeofEmployee)
        {
            case EmployeeType.Staff:
                break;
            case EmployeeType.Manager:
                output.IsManager = true;
                break;
            case EmployeeType.Executive:
                output.IsExecutive = true;
                break;
        }

        return output;

        return output;
    }
}
