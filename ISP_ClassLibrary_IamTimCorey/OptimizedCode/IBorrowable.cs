namespace ISP_Demo_IAmTimCorey.OptimizedCode;

public interface IBorrowable 
{
    public DateTime BorrowDate { get; set; }
    public string Borrower { get; set; }
    public int CheckOutDurationInDays { get; set; }
    void CheckIn();
    void CheckOut(string borrower);
    DateTime GetDueTime();
}

