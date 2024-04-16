using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCP_ClassLibrary_IamTimCorey.OptimizedCode.Applicants;

namespace OCP_ClassLibrary_IamTimCorey.OptimizedCode.Accounts;

public class GeneralAccounts : IAccounts
{
    public EmployeeModel Create(IApplicantModel person)
    {
        EmployeeModel output = new EmployeeModel();

        output.FirstName = person.FirstName;
        output.LastName = person.LastName;
        output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com";

        return output;
    }
}
