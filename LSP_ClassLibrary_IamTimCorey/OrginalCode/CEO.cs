using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_ClassLibrary_IamTimCorey.OrginalCode;

public class CEO: Employee
{
    public override void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 150M;
        Salary = baseAmount * rank;
    }

    public override void AssignManager(Employee manager)
    {
        throw new InvalidOperationException("The CEO has no manager.");
    }

    public void GeneratePerformanceReview()
    {
        Console.WriteLine("I am reviewing a direct report's performance.");
    }

    public void FireSomeone()
    {
        Console.WriteLine("You are fired.");
    }
}
