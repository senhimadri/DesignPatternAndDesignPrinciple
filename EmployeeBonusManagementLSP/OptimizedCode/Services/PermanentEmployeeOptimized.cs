namespace EmployeeBonusManagementLSP.OptimizedCode.Abstract;

public class PermanentEmployeeOptimized : EmployeewithBonus
{
    public PermanentEmployeeOptimized(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .1M;
    }

    public override decimal GetMinimumSalary()
    {
        return Salary;
    }
}

