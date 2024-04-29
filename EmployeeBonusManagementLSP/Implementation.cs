using EmployeeBonusManagementLSP.OrginalCode;
using EmployeeBonusManagementLSP.OptimizedCode;
using EmployeeBonusManagementLSP.OptimizedCode.Abstract;
namespace EmployeeBonusManagementLSP;

public class Implementation
{
    public void OrginalImplementation()
    {
        Employee empHim = new PermanentEmployee(1, "Himadri Sen", 1000.10M);
        Employee empJon = new PorationaryEmployee(1, "Jon Deo", 800.10M);
        Employee empKarm = new ContractualEmployee(1, "Jon Deo", 800.10M);

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary}, Bonus: {empHim.CalculateBonus()}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary}, Bonus: {empJon.CalculateBonus()}");
        Console.WriteLine($"Employee {empKarm.ToString()}, Salary : {empKarm.Salary}, Bonus: {empKarm.CalculateBonus()}");
        Console.ReadLine();
    }

    public void OptimizedCodeImplementation()
    {
        OptimizedCode.IServices.IEmployeeWithBonus empHim = new PorationaryEmployeeOptimized(1, "Himadri Sen", 1000.10M);
        OptimizedCode.IServices.IEmployeeWithBonus empJon = new PermanentEmployeeOptimized(1, "Jon Deo", 800.10M);
        OptimizedCode.IServices.IEmployee empKarm = new ContractualEmployeeOptimized(1, "Jon Deo", 800.10M);

        Console.WriteLine($"Employee {empHim.ToString()}, Salary : {empHim.Salary}, Bonus: {empHim.CalculateBonus()}");
        Console.WriteLine($"Employee {empJon.ToString()}, Salary : {empJon.Salary}, Bonus: {empJon.CalculateBonus()}");
        Console.WriteLine($"Employee {empKarm.ToString()}, Salary : {empKarm.Salary}");
        Console.ReadLine();
    }
}

