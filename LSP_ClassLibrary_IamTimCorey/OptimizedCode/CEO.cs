using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_ClassLibrary_IamTimCorey.OptimizedCode;

public class CEO: Employee, IManager
{
    public override void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 150M;
        Salary = baseAmount * rank;
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
