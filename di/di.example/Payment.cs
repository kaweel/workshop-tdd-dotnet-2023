namespace di.example
{
    public interface IPayment
    {
        public string Channel();
        public string Pay(decimal amount);
    }

    public class Promptpay : IPayment
    {
        public string Channel() => "Promptpay";
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via Promptpay success";
        }
    }

    public class CreditCard : IPayment
    {
        public string Channel() => "CreditCard";
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via CreditCard success";
        }
    }

    public class OddsWallet : IPayment
    {
        public string Channel() => "OddsWallet";
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via OddsWallet success";
        }
    }

    public class PaymentFactory
    {
        private readonly IEnumerable<IPayment> _payment;

        public PaymentFactory(IEnumerable<IPayment> payment)
        {
            _payment = payment;
        }

        public IPayment GetPaymentService(string channel)
        {
            return _payment.FirstOrDefault(p => p.Channel() == channel)
                ?? throw new NotSupportedException();
        }
    }
}