using FDPby_campbelltech.Services;

namespace FDPby_campbelltech.Extension;

public class PaymentFactory
{
    public static IPayment create(PaymentMethods paymentMethod)
    {
        switch (paymentMethod)
        {
            case PaymentMethods.GooglePay:
                return new PaymentByGooglePay();

            case PaymentMethods.CreditCard:
                return new PaymentByCreditCard();

            case PaymentMethods.Cash:
                return new PaymentByCash();
            default:
                throw new NotSupportedException($"{paymentMethod} is not supported");
        }
    }
}
