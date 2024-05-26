using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_ClassLibrary_IamTimCorey.OptimizedCode;

public class Manager : GeneralEmployee,IManager
{
    public override void CalculatePerHourRate(int rank)
    {
        if (rank< 0  || rank >5)
        {
            throw new Exception();
        }

        decimal baseAmount = 19.75M;
        Salary = baseAmount + (rank * 4);
    }

    public void GeneratePerformanceReview()
    {
        Console.WriteLine("I'm reviewing a direct report's performances ");
    }
}
