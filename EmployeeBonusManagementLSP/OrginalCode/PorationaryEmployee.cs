namespace EmployeeBonusManagementLSP.OrginalCode;

public class PorationaryEmployee : Employee
{
    public PorationaryEmployee(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .5M;
    }
}

