namespace di.example.framework;

public interface IPaymentService
{
    string PayByOrderNumber(string channel, string orderNumber, decimal amount);
}

public class PaymentService : IPaymentService
{
    private readonly IPaymentFactory _paymentFactory;
    private readonly IOrderService _orderService;

    public PaymentService(IPaymentFactory paymentFactory, IOrderService orderService)
    {
        _paymentFactory = paymentFactory;
        _orderService = orderService;
    }

    public string PayByOrderNumber(string channel, string orderNumber, decimal amount)
    {
        var validOrderNumber = _orderService.GetOutstandingBalance(orderNumber);
        if (!validOrderNumber)
            throw new Exception("invalid order number");
        return _paymentFactory.GetPayment(channel).Pay(amount);
    }
}
