
class Address
{

    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string stateProvince, string country)
    {
        _street = "";
        _city = "";
        _stateProvince = "";
        _country = "";
    }

    public string ReturnIsLocalA()
    {
        if (_country == "United States")
            return "Yes";
        else
            return "No";
    }

    public string ReturnAddressA()
    {
        return $"Street: {_street}\nCity: {_city}\nState/Province: {_stateProvince}\nCountry: {_country}";
    }

    public void AddVariables(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

}