using EmployeeBonusManagement.OrtimizedCodeUsingInterface.Operations;

namespace EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

public class ProbationaryEmployee : IEmployeeInterface
{
    public int EmployeeId { get; set; }
    public string? EmployeeName { get; set; }
    public decimal Salary { get; set; }
    public IEmployeeBonusOperation BonusOperation { get; set; } = new ProbationaryEmployeeBonusOperation();
}

