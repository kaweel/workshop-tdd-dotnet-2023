using di.example;

string channel = "OddsWallet";
IPayment payment;
switch (channel)
{
    case "CreditCard":
        payment = new CreditCard();
        break;
    case "Promptpay":
        payment = new Promptpay();
        break;
    default:
        payment = new OddsWallet();
        break;
}

var orderService = new OrderService();
var paymentService = new PaymentService(payment, orderService);
Console.WriteLine(paymentService.PayByOrderNumber("001"));

