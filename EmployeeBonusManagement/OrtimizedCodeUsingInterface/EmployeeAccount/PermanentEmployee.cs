using EmployeeBonusManagement.OrtimizedCodeUsingInterface.Operations;

namespace EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

public class PermanentEmployee : IEmployeeInterface
{
    public int EmployeeId { get; set; }
    public string? EmployeeName { get; set; }
    public decimal Salary { get; set; }
    public IEmployeeBonusOperation BonusOperation { get; set; } = new PermanentEmployeeBonusOperation();
}

