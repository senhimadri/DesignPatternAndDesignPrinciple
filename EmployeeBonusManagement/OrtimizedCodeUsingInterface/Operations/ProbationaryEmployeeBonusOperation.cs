using EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

namespace EmployeeBonusManagement.OrtimizedCodeUsingInterface.Operations;

public class ProbationaryEmployeeBonusOperation : IEmployeeBonusOperation
{
    public decimal CalculateBonus(IEmployeeInterface employee)
    {
        return employee.Salary * .5M;
    }

    public string EmployeeNameWithDesignation(IEmployeeInterface employee)
    {
        return $"{employee.EmployeeName}[{employee.EmployeeId}] -> Probationary Employee";
    }
}

