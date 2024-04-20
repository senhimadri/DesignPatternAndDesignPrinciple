using EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

namespace EmployeeBonusManagement.OrtimizedCodeUsingInterface.Operations;

public class PermanentEmployeeBonusOperation : IEmployeeBonusOperation
{
    public decimal CalculateBonus(IEmployeeInterface employee)
    {
        return employee.Salary * .1M;
    }

    public string EmployeeNameWithDesignation(IEmployeeInterface employee)
    {
        return $"{employee.EmployeeName}[{employee.EmployeeId}] -> Permanent Employee";
    }
}

