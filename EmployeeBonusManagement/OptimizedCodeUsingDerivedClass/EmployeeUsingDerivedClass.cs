namespace EmployeeBonusManagement.OptimizedCodeUsingDeriverClasses;

public abstract class EmployeeUsingDerivedClass
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public decimal Salary { get; set; }

    public EmployeeUsingDerivedClass(int _EmployeeId, string _EmployeeName, decimal _Salary)
    {
        EmployeeId = _EmployeeId;
        EmployeeName = _EmployeeName;
        Salary = _Salary;
    }

    public abstract decimal CalculateBonus();


    public override string ToString()
    {
        return string.Format($"{EmployeeName}[{EmployeeId}]");
    }
}

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

public class PorationaryEmployee : EmployeeUsingDerivedClass
{
    public PorationaryEmployee(int _EmployeeId, string _EmployeeName, decimal _Salary) : base(_EmployeeId, _EmployeeName, _Salary)
    {

    }
    public override decimal CalculateBonus()
    {
        return Salary * .5M;
    }

}

