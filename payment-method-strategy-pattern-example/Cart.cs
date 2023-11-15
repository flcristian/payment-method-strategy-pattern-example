namespace payment_method_strategy_pattern_example;

public class Cart
{
    private List<double> _items;

    public Cart(List<double> items)
    {
        _items = items;
    }

    public double GetTotal()
    {
        double sum = 0;
        
        foreach (double item in _items)
        {
            sum += item;
        }

        return sum;
    }
}