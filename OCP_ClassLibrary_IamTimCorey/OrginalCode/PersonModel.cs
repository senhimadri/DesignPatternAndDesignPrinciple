namespace OCP_ClassLibrary_IamTimCorey.OrginalCode;

public class PersonModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public EmployeeType TypeofEmployee { get; set; } = EmployeeType.Staff;
}
