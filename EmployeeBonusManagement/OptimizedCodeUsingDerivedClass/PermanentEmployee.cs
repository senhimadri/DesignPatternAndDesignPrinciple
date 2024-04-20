namespace EmployeeBonusManagement.OptimizedCodeUsingDeriverClasses;

public class PermanentEmployee : EmployeeUsingDerivedClass
{
    public PermanentEmployee(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId ,_EmployeeName,_Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .1M;
    }
}

