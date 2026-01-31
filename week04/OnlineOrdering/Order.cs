
using System.Security.Cryptography;

public class Order
{
    private Customer _customer;
    private int _tax;
    private List<Product> _products;

    public Order(Customer custumer, int tax)
    {
        _customer = custumer;
        _tax = tax;
        tax = 5;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        if (_products == null)
        {
            _products = new List<Product>();
        }
        _products.Add(product);
    }

    public int CalculateTax()
    {
        if (_customer.GetAddress().IsUSA())
        {
            return 5;
        }

        return 35;
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CostOfProduct();
        }
         
         total += _customer.LivesInUSA() ? 5 : 35; 

        return total;
    }

    public string ShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress().StringAddress()}";
    }

    public string PackingLabel()
    {
        string label = "products:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetName()} (ID: {product.GetId()})\n";
        }

        return label;
    }
}