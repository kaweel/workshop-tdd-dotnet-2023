namespace di.example.framework.test;

public class PaymentService_PayByOrderNumberTest
{
    // PayByOrderNumber
    
    // verify order number exist
    // input order number 001
    // output do next step

    // verify order number doesn't exist
    // input order number 002
    // output exception "invalid order number"

    // payment success with order number 001 by channel Promptpay
    // input order number 001, channel promptpay, amount 100
    // output "Pay 100 via Promptpay success"

    // payment fail with order number 001 by channel Promptpay
    // input order number 001, channel promptpay, amount 100
    // output thorw exception "payment Promptpay fail"

    // payment success with order number 001 by channel CreditCard
    // input order number 001, channel promptpay, amount 100
    // output $"Pay 100 via CreditCard success"

    // payment fail with order number 001 by channel CreditCard
    // input order number 001, channel promptpay, amount 100
    // output thorw exception "payment CreditCard fail"

    // payment success with order number 001 by channel E-Wallet
    // input order number 001, channel promptpay, amount 100
    // output $"Pay 100 via E-Wallet success"

    // payment fail with order number 001 by channel E-Wallet
    // input order number 001, channel promptpay, amount 100
    // output thorw exception "payment E-Wallet fail"
}