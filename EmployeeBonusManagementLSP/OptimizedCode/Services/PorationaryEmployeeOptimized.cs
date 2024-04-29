namespace EmployeeBonusManagementLSP.OptimizedCode.Abstract;

public class PorationaryEmployeeOptimized : EmployeewithBonus
{
    public PorationaryEmployeeOptimized(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .5M;
    }

    public override decimal GetMinimumSalary()
    {
        return Salary / 2;
    }
}

