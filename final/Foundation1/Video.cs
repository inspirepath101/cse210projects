using System;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    

    public void Display()
    {
        Console.Write($"{_title} ({_author}) {_length} ");
    }
}