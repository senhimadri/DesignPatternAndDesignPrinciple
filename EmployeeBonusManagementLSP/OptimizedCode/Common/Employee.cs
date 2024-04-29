using EmployeeBonusManagementLSP.OptimizedCode.IServices;

namespace EmployeeBonusManagementLSP.OptimizedCode.Common;

public abstract class Employee : IEmployee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public Employee(int _EmployeeId, string _EmployeeName, decimal _Salary)
    {
        EmployeeId = _EmployeeId;
        EmployeeName = _EmployeeName;
        Salary = _Salary;
    }

    public abstract decimal GetMinimumSalary();
}

