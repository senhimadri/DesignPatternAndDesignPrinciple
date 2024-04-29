namespace EmployeeBonusManagementLSP.OrginalCode;

public class PermanentEmployee : Employee
{
    public PermanentEmployee(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId ,_EmployeeName,_Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .1M;
    }
}

