using payment_method_strategy_pattern_example;
using payment_method_strategy_pattern_example.Payment_Method;

internal class Program
{
    public static void Main(string[] args)
    {
        Cart cart = new Cart(new List<double>{1,10.5,5.99,2.49});
        PaymentContext context = new PaymentContext();
        context.SetPaymentMethod(new PayPalPaymentMethod());
        context.ExecutePayment(cart);
    }
}