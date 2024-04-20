using EmployeeBonusManagement.OptimizedCodeUsingDeriverClasses;
using EmployeeBonusManagement.OrginalCode;
using EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

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
        EmployeeUsingDerivedClass empHim = new OptimizedCodeUsingDeriverClasses.PermanentEmployee (1, "Himadri Sen", 1000.10M);
        EmployeeUsingDerivedClass empJon = new PorationaryEmployee (1, "Jon Deo", 800.10M);

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary}, Bonus: {empHim.CalculateBonus()}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary}, Bonus: {empJon.CalculateBonus()}");
        Console.ReadLine();
    }

    public void OptimizedCodeUsingInterface()
    {
        IEmployeeInterface empHim = new OrtimizedCodeUsingInterface.EmployeeAccount.ProbationaryEmployee()
        {
            EmployeeId=1,
            EmployeeName="Himadri Sen",
            Salary=1000.0M
        };
        IEmployeeInterface empJon = new OrtimizedCodeUsingInterface.EmployeeAccount.PermanentEmployee()
        { 
            EmployeeId=2,
            EmployeeName="Jone Dey",
            Salary =8000.0M
        };

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary}, Bonus: {empHim.BonusOperation.CalculateBonus(empHim)}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary}, Bonus: {empJon.BonusOperation.CalculateBonus(empJon)}");
        Console.ReadLine();

    }
}

