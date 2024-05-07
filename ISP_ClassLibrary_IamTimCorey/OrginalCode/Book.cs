
namespace ISP_ClassLibrary_IamTimCorey.OrginalCode;

public class Book : ILibraryItem
{
    public string Author { get ; set ; }
    public DateTime BorrowDate { get ; set ; }
    public string Borrower { get ; set ; }
    public int CheckOutDurationInDays { get; set; } = 14;
    public string LibraryId { get ; set ; }
    public int Pages { get ; set ; }
    public string Title { get ; set ; }

    public void CheckIn()
    {
        Borrower = string.Empty;
    }

    public void CheckOut(string borrower)
    {
        Borrower = borrower;
        BorrowDate = DateTime.Now;
    }

    public DateTime GetDueTime()
    {
        throw new NotImplementedException();
    }
}

