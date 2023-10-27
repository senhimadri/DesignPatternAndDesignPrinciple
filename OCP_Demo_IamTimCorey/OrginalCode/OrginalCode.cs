using OCP_ClassLibrary_IamTimCorey.OrginalCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Demo_IamTimCorey.OrginalCode;

public class OrginalCode
{
    public static void Implementation()
    {
        List<PersonModel> applicants = new List<PersonModel>()
        {
            new PersonModel { FirstName = "Himadri" , LastName = "Sen"},
            new PersonModel { FirstName = "Shohan", LastName = "Ahamed" , TypeofEmployee = EmployeeType.Manager},
            new PersonModel { FirstName = "Emon", LastName = "Khan" , TypeofEmployee = EmployeeType.Executive}
        };

        List<EmployeeModel> employees = new List<EmployeeModel>();

        Accounts accountProcessor = new Accounts();

        foreach (var per in applicants)
        {
            employees.Add(accountProcessor.Create(per));
        }

        foreach (var emp in employees)
        {
            Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} , IsManager:  {emp.IsManager} , IsExecutive : {emp.IsExecutive}");
        }

        Console.ReadLine();
    }
}
