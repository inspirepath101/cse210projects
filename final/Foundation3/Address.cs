public class Address : Event
{
    private string _address;


    public Address(string name, string address) : base(name)
    {
      _address = address;
    }

    public string GetAddress()
    {
        return _address;
    }
}