namespace ISP_ClassLibrary_IamTimCorey.OptimizedCode.AudioBook;

public class AudioBook : IBorrowableAudioBook
{
    public string LibraryId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int RunTimeinMinutes { get; set; }

    public string Borrower { get; set; }
    public DateTime BorrowDate { get; set; }
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

