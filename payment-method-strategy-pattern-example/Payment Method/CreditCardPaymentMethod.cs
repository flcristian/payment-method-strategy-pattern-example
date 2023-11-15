namespace payment_method_strategy_pattern_example.Payment_Method;

public class CreditCardPaymentMethod : IPaymentMethod
{
    private const string PAYMENT_METHOD_NAME = "Credit Card";
    
    public void Pay(double ammount)
    {
        Console.WriteLine($"Paid ${ammount.ToString("F")} trough {PAYMENT_METHOD_NAME}.");
    }
}