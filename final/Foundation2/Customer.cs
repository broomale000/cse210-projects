
class Customer
{

    private string _name;

    private Address _Address;

    public Customer()
    {
        _Address = new Address("", "", "", ""); 
    }

    public string ReturnIsLocalC()
    {
        return _Address.ReturnIsLocalA();
    }

    public string ReturnAddressC()
    {
        return _Address.ReturnAddressA();
    }

    public string ReturnName()
    {
       return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void AddAddress(string street, string city, string stateProvince, string country)
    {
        _Address.AddVariables(street, city, stateProvince, country);
    }


}
