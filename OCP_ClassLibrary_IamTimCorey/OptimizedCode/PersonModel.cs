using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_ClassLibrary_IamTimCorey.OptimizedCode;

public class PersonModel : IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public IAccounts AccountProcessor { get ; set ; } = new Accounts();
}
