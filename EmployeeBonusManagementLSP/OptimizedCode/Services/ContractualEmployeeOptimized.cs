using EmployeeBonusManagementLSP.OptimizedCode.Common;
using EmployeeBonusManagementLSP.OptimizedCode.IServices;

namespace EmployeeBonusManagementLSP.OptimizedCode.Abstract;

public class ContractualEmployeeOptimized : Employee
{
    public ContractualEmployeeOptimized(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {
    }

    public override decimal GetMinimumSalary()
    {
        return Salary / 3;
    }
}

