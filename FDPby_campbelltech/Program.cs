using FDPby_campbelltech.Extension;
using FDPby_campbelltech.Services;

IPayment payment = PaymentFactory.Create(PaymentMethods.Cash);

payment.Pay(6000.09M);

Console.ReadLine();
