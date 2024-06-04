namespace FDPby_campbelltech.Services;

public class PaymentByGooglePay : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"BDT {amount} is paied using Google Pay.");
    }
}
