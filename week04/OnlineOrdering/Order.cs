using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetName() + " - " + product.GetProductId() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "";
        label += _customer.GetName() + "\n";
        label += _customer.GetAddress().GetAddressString();
        return label;
    }

}
