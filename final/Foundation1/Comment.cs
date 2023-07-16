using System;

public class Comments
{
    public string _name;
    public string _comment;
    

    public void Display()
    {
        Console.Write($"{_name} ({_comment} ");
    }
}