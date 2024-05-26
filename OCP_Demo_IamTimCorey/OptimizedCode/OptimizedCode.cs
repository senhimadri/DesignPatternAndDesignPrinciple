using OCP_ClassLibrary_IamTimCorey.OptimizedCode;
using OCP_ClassLibrary_IamTimCorey.OptimizedCode.Accounts;
using OCP_ClassLibrary_IamTimCorey.OptimizedCode.Applicants;

namespace OCP_Demo_IamTimCorey.OptimizedCode;

public class OptimizedCode
{
    public static void Implementation()
    {
        List<IApplicantModel> applicants = new List<IApplicantModel>()
        {
            new PersonModel     { FirstName = "Himadri",    LastName = "Sen"    },
            new ManagerModel    { FirstName = "Shohan",     LastName = "Ahamed" },
            new ExecutiveModel  { FirstName = "Emon",       LastName = "Khan"   }
        };

        List<EmployeeModel> employees = new List<EmployeeModel>();


        foreach (var per in applicants)
        {
            employees.Add(per.AccountProcessor.Create(per));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} , IsManager:  {emp.IsManager} , IsExecutive : {emp.IsExecutive}");
        }

        Console.ReadLine();
    }
}
