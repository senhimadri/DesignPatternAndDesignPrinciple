using EmployeeBonusManagement.OrtimizedCodeUsingInterface.EmployeeAccount;

namespace EmployeeBonusManagement.OrtimizedCodeUsingInterface.Operations;

public interface IEmployeeBonusOperation
{
    public decimal CalculateBonus(IEmployeeInterface employee);

    public string EmployeeNameWithDesignation(IEmployeeInterface employee);
}

