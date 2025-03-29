using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Creating Order 1
        Order Order1 = new Order();
        Order1.AddCustomerName("John");
        Order1.SetAddress("1234 Wave Dance", "New York", "New York", "United States");
        Order1.DisplayAddress();
        Product Product1 = new Product("Banana", 239149, 1.53m, 5);
        Order1.AppendProduct(Product1);
        Product Product2 = new Product("Apple", 239150, 1.01m, 6);
        Order1.AppendProduct(Product2);

        // Creating Order 2
        Order Order2 = new Order();
        Order2.AddCustomerName("Jane");
        Order2.SetAddress("567 Tortuga", "Tokyo", "Kanto", "Japan");
        Order2.DisplayAddress();
        Product Product3 = new Product("Orange", 269149, 6.00m, 9);
        Order2.AppendProduct(Product3);
        Product Product4 = new Product("Grapes", 299150, 0.59m, 2);
        Order2.AppendProduct(Product4);

        // Console.WriteLine("-----------Ship Label-----------");
        // Console.WriteLine(Order1.ReturnShipLabel());
        //  Console.WriteLine("----------Pack Label-----------");
        // Console.WriteLine(Order1.ReturnPackLabel());
        // Console.WriteLine("--------------------------------");

        // Account for shipping fee in Address class 'public string IsLocal()' when doing final 

        // Console.WriteLine($"Order Fee: $" + Order1.FindShippingCost());
        // decimal orderFee = Order1.FindShippingCost();
        // Console.WriteLine($"Order Cost: $" + Product1.CalculateCost());
        // decimal productCost = Product1.CalculateCost();
        // decimal grandTotal = orderFee + productCost;
        // Console.WriteLine($"Grand Total: ${grandTotal}");

        Order1.GetTotal();
        Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaa");
        Order2.GetTotal();

    }
}