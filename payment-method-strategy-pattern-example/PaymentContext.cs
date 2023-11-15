using payment_method_strategy_pattern_example.Payment_Method;

namespace payment_method_strategy_pattern_example;

public class PaymentContext
{
    private IPaymentMethod _paymentMethod;

    public void SetPaymentMethod(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ExecutePayment(Cart cart)
    {
        _paymentMethod.Pay(cart.GetTotal());
    }
}