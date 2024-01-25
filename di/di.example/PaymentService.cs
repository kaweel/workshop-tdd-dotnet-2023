namespace di.example;



public class PaymentService
{
    private readonly IPayment _payment;
    private readonly OrderService _orderService;

    public PaymentService(IPayment payment, OrderService orderService)
    {
        _payment = payment;
        _orderService = orderService;
    }

    public string PayByOrderNumber(string orderNumber)
    {
        return _payment.Pay(_orderService.GetOutstandingBalance(orderNumber));
    }
}
