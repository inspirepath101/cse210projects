using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");  
    }
public class Customer
{
    private string _name;
    private string _address;
    
    public string GetCustomerInfo()
    {
        return "Thanks, " + _name;
    }


    public string GetCustomerInfo()
    {
        return "Sincerely, " + GetFullName();
    }

    private string GetFullName()
    {
        return _name + " " + _address;
    }
   
}
}