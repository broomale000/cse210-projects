
class Customer
{

    private string _name;

    private Address _Address;

    public Customer()
    {
        _Address = new Address("", "", "", ""); 
    }

    public string IsLocal()
    {
        return _Address.IsLocal();
    }

    public string WriteAddress()
    {
        return _Address.WriteAddress();
    }

    public string WriteName()
    {
       return _name;
    }

    public void AddName(string name)
    {
        _name = name;
    }

    public void AddAddress(string street, string city, string stateProvince, string country)
    {
        _Address.AddVariables(street, city, stateProvince, country);
    }


}
