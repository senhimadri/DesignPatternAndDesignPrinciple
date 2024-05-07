namespace ISP_Demo_IAmTimCorey.OptimizedCode;

public class DVD : IBorrowableDvd
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public List<string> Actors { get; set; }
    public int RunTimeInMinutes { get; set; }

    public DateTime BorrowDate { get; set; }
    public string Borrower { get; set; }
    public int CheckOutDurationInDays { get; set; } = 14;

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

