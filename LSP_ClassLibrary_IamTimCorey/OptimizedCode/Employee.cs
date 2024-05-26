using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_ClassLibrary_IamTimCorey.OptimizedCode;

public abstract class Employee : IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public GeneralEmployee Manager { get; set; } = null;
    public decimal Salary { get; set; }


    public virtual void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 12.50M;

        Salary = baseAmount + (rank * 2);
    }

}
