namespace FactoryDesignPatternExercise.LeaveRequestHandler;

public interface ILeaveManagement
{
    Task ApplyForLeave();
    Task<bool> CheckLeaveAvliablity();
    Task<bool> DeductLeaveBalance();
}
public enum LeaveType
{
    Casual,
    Sick,
    Special,
    Earned,
    Maternity,
    Paternity,
    LWP
}

public interface IStandardLeaveManagement : ILeaveManagement;
public interface IEarnLeaveManagement : ILeaveManagement
{
    Task EarnLeaveEncashment();
}
public interface IMaternityManagement : ILeaveManagement
{
    Task ValidateMaternity();
}
public interface ILWPLeaveManagement : ILeaveManagement
{
    Task AddLwpAmountToSalaryDeduction();
}



public abstract class StandardLeaveManagement : ILeaveManagement
{
    public virtual async Task ApplyForLeave()
    {
        Console.WriteLine("Standard Leave Application Supmitted");
        await Task.CompletedTask;
    }

    public virtual Task<bool> CheckLeaveAvliablity()
    {
        Console.WriteLine("Standard Leave Baclanced Checked");
        return Task.FromResult(true);
    }

    public virtual Task<bool> DeductLeaveBalance()
    {
        Console.WriteLine("Standard Leave Baclanced Deducted");
        return Task.FromResult(true);
    }
}
public class EarnLeaveManagement : StandardLeaveManagement, IEarnLeaveManagement
{
    public async override Task ApplyForLeave()
    {
        Console.WriteLine("Earn Leave Application Supmitted");
        await Task.CompletedTask;
    }

    public async Task EarnLeaveEncashment()
    {
        Console.WriteLine("Earn Leave Encashed Successfully.");
        await Task.CompletedTask;
    }
}
public class MaternityLeaveManagement : StandardLeaveManagement, IMaternityManagement
{
    public async override Task ApplyForLeave()
    {
        Console.WriteLine("Earn Leave Application Supmitted");
        await Task.CompletedTask;
    }

    public async override Task<bool> CheckLeaveAvliablity()
    {
        Console.WriteLine("Maternity Leave Available");
        return await Task.FromResult(true);
    }

    public async Task ValidateMaternity()
    {
        Console.WriteLine("Valied for Maternity Leave");
        await Task.CompletedTask;
    }
}
public class LWPLeaveManagement : StandardLeaveManagement, ILWPLeaveManagement
{
    public async Task AddLwpAmountToSalaryDeduction()
    {
        Console.WriteLine("LWP is add to the Salary Deduction.");
        await Task.CompletedTask;
    }

    public async override Task ApplyForLeave()
    {
        Console.WriteLine("LWP is Applied Successfully.");
        await Task.CompletedTask;
    }

    public async override Task<bool> CheckLeaveAvliablity()
    {
        Console.WriteLine("LWP Leave Available");
        return await Task.FromResult(true);
    }

    public async override Task<bool> DeductLeaveBalance()
    {
        Console.WriteLine("LWP Leave Available");
        return await Task.FromResult(true);
    }
}


public class LeaveApplicationDto
{
    public LeaveType LeaveType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string? Details { get; set; }
    public byte[]? Attachments { get; set; }
}
