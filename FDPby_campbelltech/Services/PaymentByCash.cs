namespace FDPby_campbelltech.Services;

public class PaymentByCash : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"BDT {amount} is paied by Cash.");
    }
}
