
class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private decimal _quantity;

    public Product(string name, int productId, decimal price, decimal quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateCost()
    
    {
        return _price * _quantity;
    }

    public int ReturnProductId()
    {
        return _productId;
    }

    public string ReturnName()
    {
        return _name;
    }

    public void PrintPriceAndQuantity()
    {
        Console.WriteLine($"Item is: {_name}");
        Console.WriteLine($"Price is: ${_price}.");
        Console.WriteLine($"Quantity is: {_quantity}.");
    }

}