namespace di.example;
public class OrderService
{
    public decimal GetOutstandingBalance(string orderNumber)
    {
        if (orderNumber == "001")
        {
            return decimal.Parse("100");
        }
        if (orderNumber == "002")
        {
            return decimal.Parse("200");
        }
        return decimal.Parse("0");
    }
}

