using EmployeeBonusManagementLSP.OptimizedCode.Common;
using EmployeeBonusManagementLSP.OptimizedCode.IServices;
namespace EmployeeBonusManagementLSP.OptimizedCode.Abstract;

public abstract class EmployeewithBonus :  Employee, IEmployeeWithBonus
{
    protected EmployeewithBonus(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {
    }

    public abstract decimal CalculateBonus();
}

