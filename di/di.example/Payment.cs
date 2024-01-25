namespace di.example
{
    public interface IPayment
    {
        public string Pay(decimal amount);
    }

    public class Promptpay : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via Promptpay success";
        }
    }

    public class CreditCard : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via CreditCard success";
        }
    }

    public class OddsWallet : IPayment
    {
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via OddsWallet success";
        }
    }
}