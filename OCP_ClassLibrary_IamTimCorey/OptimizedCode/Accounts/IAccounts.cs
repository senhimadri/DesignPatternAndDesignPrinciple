using OCP_ClassLibrary_IamTimCorey.OptimizedCode.Applicants;

namespace OCP_ClassLibrary_IamTimCorey.OptimizedCode.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}