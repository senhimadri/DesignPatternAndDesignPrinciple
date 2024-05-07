namespace ISP_Demo_IAmTimCorey.OrginalCode;

public class DVD : ILibraryItem
{
    public string Author { get; set; }
    public DateTime BorrowDate { get; set; }
    public string Borrower { get; set; }
    public int CheckOutDurationInDays { get; set; } = 14;
    public string LibraryId { get; set; }
    public int Pages { get; set; } = -1;
    public string Title { get; set; }

    public List<string> Actors { get; set; }
    public int RunTimeInMinutes { get; set; }

    public void CheckIn()
    {
        throw new NotImplementedException();
    }

    public void CheckOut(string borrower)
    {
        throw new NotImplementedException();
    }

    public DateTime GetDueTime()
    {
        throw new NotImplementedException();
    }
}

