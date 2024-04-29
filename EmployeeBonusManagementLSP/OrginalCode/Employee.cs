namespace EmployeeBonusManagementLSP.OrginalCode;

public abstract class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public decimal Salary { get; set; }

    public Employee(int _EmployeeId, string _EmployeeName, decimal _Salary)
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

