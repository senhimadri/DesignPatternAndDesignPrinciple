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
        IManager accountingVP = new Manager();
       
        accountingVP.FirstName = "Emon";
        accountingVP.LastName = "Sheck";

        accountingVP.CalculatePerHourRate(4);

        IManager accountingVP2 = new CEO();

        accountingVP2.FirstName = "Emon";
        accountingVP2.LastName = "Sheck";

        accountingVP2.CalculatePerHourRate(4);


        IManaged emp = new GeneralEmployee();

        emp.FirstName = "Himadri";
        emp.LastName = "Sen";

        emp.AssignManager(accountingVP);
        emp.CalculatePerHourRate(2);



        IManaged empManager = new Manager();

        emp.FirstName = "Himadri";
        emp.LastName = "Sen";

        emp.AssignManager(accountingVP2);
        emp.CalculatePerHourRate(2);


        Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/Hour.");

        Console.ReadLine();

    }
}
