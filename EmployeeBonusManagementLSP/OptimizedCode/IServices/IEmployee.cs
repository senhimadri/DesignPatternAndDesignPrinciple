namespace EmployeeBonusManagementLSP.OptimizedCode.IServices;

public interface IEmployee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public decimal Salary { get; set; }
    public decimal GetMinimumSalary();
}

