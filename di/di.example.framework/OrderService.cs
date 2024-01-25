namespace di.example.framework;

public interface IOrderService
{
    bool GetOutstandingBalance(string orderNumber);
}
public class OrderService : IOrderService
{
    public bool GetOutstandingBalance(string orderNumber)
    {
        return orderNumber == "001" || orderNumber == "002";
    }
}

