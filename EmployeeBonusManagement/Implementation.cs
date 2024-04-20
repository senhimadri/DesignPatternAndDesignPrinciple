using EmployeeBonusManagement.OptimizedCodeUsingDeriverClasses;
using EmployeeBonusManagement.OrginalCode;

namespace EmployeeBonusManagement;
public class Implementation
{
    public void OrginalExecute()
    {
        OrginalEmployee empHim = new OrginalEmployee(1,"Himadri Sen",EnmEmployeeType.Permanent,1000.10M);
        OrginalEmployee empJon = new OrginalEmployee(1,"Jon Deo",EnmEmployeeType.Probitionary,800.10M);

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary }, Bonus: {empHim.CalculateBonus()}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary }, Bonus: {empJon.CalculateBonus()}");
        Console.ReadLine();
    }

    public void OptimizedCodeUsingDerivedClass()
    {
        EmployeeUsingDerivedClass empHim = new PermanentEmployee (1, "Himadri Sen", 1000.10M);
        EmployeeUsingDerivedClass empJon = new PorationaryEmployee (1, "Jon Deo", 800.10M);

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary}, Bonus: {empHim.CalculateBonus()}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary}, Bonus: {empJon.CalculateBonus()}");
        Console.ReadLine();
    }
}

