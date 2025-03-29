class Address
{
    protected string _location;
    public Address(string location)
    {
        _location = location;
    }

    public override string ToString()
    {
        return _location;
    }

}