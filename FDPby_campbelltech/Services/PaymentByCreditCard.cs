namespace FDPby_campbelltech.Services;

public class PaymentByCreditCard : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"BDT {amount} is paied using Credit Card.");
    }
}
