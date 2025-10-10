public class Order
{
    private List<Product> _products;
    private Customer _customer;

    private const double ShippingCostUSA = 5.00;
    private const double ShippingCostInternational = 35.00;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double subtotal = 0;
        
        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }

        double shippingCost = _customer.IsUSA() ? ShippingCostUSA : ShippingCostInternational;

        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "-Label-\n";
        foreach (Product product in _products)
        {
            label += $"Name: {product.GetName()}, ID: {product.GetProductID()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = "-Shipping Label-\n";

        label += $"Client: {_customer.GetName()}\n";
        
        label += $"{_customer.GetAddress().GetFullAddressString()}";
        
        return label;
    }
}