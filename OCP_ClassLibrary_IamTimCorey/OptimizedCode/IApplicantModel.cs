using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_ClassLibrary_IamTimCorey.OptimizedCode;

public interface IApplicantModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    IAccounts AccountProcessor { get; set; }
}
