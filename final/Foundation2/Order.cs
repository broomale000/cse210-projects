
class Order
{

    private Customer _Customer;
    List<Product> Products = new List<Product>();
    decimal _total;

    public Order()
    {
        _Customer = new Customer();
        Products = new List<Product>();
    }

    public void GetTotal()
    {
        foreach (Product product in Products)
        {
            decimal cost = product.CalculateCost();
            product.PrintPriceAndQuantity();
            _total += cost;
            Console.WriteLine($"This is the subtotal: ${_total}");
        }        
        if (_Customer.IsLocal() == "Yes")
            {
                _total += 5m;
                Console.WriteLine("Non-Local Order - +$5");
            }
        else
            {
                _total += 35m;
                Console.WriteLine("Non-Local Order - +$35");
            }
        Console.WriteLine($"This is the final total: ${_total}");
    }

    public string ReturnShipLabel()
    {

        List<string> labels = new List<string>();

        foreach (Product product in Products)
        {
            int productId = product.ReturnProductId();
            string name = product.ReturnName();
            labels.Add($"Product ID: {productId}\nName: {name}");
        }

        return string.Join("\n\n", labels);
    }

    public string ReturnPackLabel()
    {

            string address = _Customer.WriteAddress();
            string customer = _Customer.WriteName();

            return $"Customer: {customer}\nAddress: {address}";
    }

    public decimal FindShippingCost()
    {
        if (_Customer.IsLocal() == "Yes")
            return 5m;
        else
            return 35m;
    }

    public void AddCustomerName(string name)
    {
        _Customer.AddName(name);
    }

    public void AppendProduct(Product product)
    {
        Products.Add(product);
    }

    public void SetAddress(string street, string city, string stateProvince, string country)
    {
        _Customer.AddAddress(street, city, stateProvince, country);
    }

     public void DisplayAddress()
     {
        Console.WriteLine(_Customer.WriteAddress());
     }

}