namespace di.example;

public interface IPaymentService
{
    string PayByOrderNumber(string orderNumber);
}

public class PaymentService : IPaymentService
{
    private IPayment _payment;
    private IOrderService _orderService;

    public PaymentService(IPayment payment, IOrderService orderService)
    {
        _payment = payment;
        _orderService = orderService;
    }

    public string PayByOrderNumber(string orderNumber)
    {
        return _payment.Pay(_orderService.GetOutstandingBalance(orderNumber));
    }
}
