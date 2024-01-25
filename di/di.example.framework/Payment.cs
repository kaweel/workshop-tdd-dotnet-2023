namespace di.example.framework
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

    public class EWallet : IPayment
    {
        public string Channel() => "E-Wallet";
        public string Pay(decimal amount)
        {
            return $"Pay {amount} via E-Wallet success";
        }
    }

    public interface IPaymentFactory
    {
        IPayment GetPayment(string channel);
    }

    public class PaymentFactory : IPaymentFactory
    {
        private readonly IEnumerable<IPayment> _payment;

        public PaymentFactory(IEnumerable<IPayment> payment)
        {
            _payment = payment;
        }

        public IPayment GetPayment(string channel)
        {
            return _payment.FirstOrDefault(p => p.Channel() == channel)
                ?? throw new NotSupportedException();
        }
    }
}