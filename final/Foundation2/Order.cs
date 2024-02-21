public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotal();
        }

        total += _customer.IsInUSA() ? 5 : 35;

        return Math.Round(total, 2);
    }

    public string CreatePackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"Item: {product.GetName()} [ID: {product.GetId()}]\n";
        }

        return label;
    }

    public string CreateShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}";
    }
}