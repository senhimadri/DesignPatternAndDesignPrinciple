using LSP_ClassLibrary_IamTimCorey.OptimizedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Demo_IamTimCorey.OptimizedCode;

public class OptimizedCode
{
    public static void Implementation()
    {
        Manager accountingVP = new Manager();

        accountingVP.FirstName = "Emon";
        accountingVP.LastName = "Sheck";

        accountingVP.CalculatePerHourRate(4);


        Employee emp = new CEO();

        emp.FirstName = "Himadri";
        emp.LastName = "Sen";

        emp.AssignManager(accountingVP);
        emp.CalculatePerHourRate(2);


        Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/Hour.");

        Console.ReadLine();

    }
