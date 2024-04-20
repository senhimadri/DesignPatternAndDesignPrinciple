namespace EmployeeBonusManagement.OrginalCode;

public class OrginalEmployee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }

    public EnmEmployeeType EmployeeType { get; set; }
    public decimal Salary { get; set; }

    public OrginalEmployee(int _EmployeeId, string _EmployeeName, EnmEmployeeType _EmployeeType, decimal _Salary)
    {
        EmployeeId = _EmployeeId;
        EmployeeName = _EmployeeName;
        EmployeeType = _EmployeeType;
        Salary = _Salary;
    }

    public decimal CalculateBonus()
    {
        if (EmployeeType == EnmEmployeeType.Permanent)
        {
            return (Salary * .1M);
        }
        else 
        {
            return (Salary * .5M);
        }
        
    }

    public override string ToString()
    {
        return string.Format($"{EmployeeName}[{EmployeeId}]");
    }
}

